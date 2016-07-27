﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using RazorHosting.Properties;

namespace RazorHosting
{
    /// <summary>
    /// This class is a caching directory based host wrapper around
    /// the RazorHost classes to provide directory based Razor
    /// template execution. Templates are compiled on 
    /// the fly, and cached unless the templates on disk are changed.
    /// 
    /// Runs Razor Templates in a seperate AppDomain
    /// 
    /// Uses the RazorTemplateFolderHost base template by default.
    /// For any other template implementation use the generic parameter
    /// to specify the template type.
    /// </summary>
 
    public class RazorFolderHostContainer : RazorFolderHostContainer<RazorTemplateFolderHost>
    {     
    }

    /// <summary>
    /// This class is a caching directory based host wrapper around
    /// the RazorHost classes to provide directory based Razor
    /// template execution. Templates are compiled on 
    /// the fly, and cached unless the templates on disk are changed.
    /// 
    /// Runs Razor Templates in a seperate AppDomain
    /// </summary>
    /// <typeparam name="TBaseTemplate">The type of the base template to use</typeparam>
    public class RazorFolderHostContainer<TBaseTemplate> : RazorBaseHostContainer<RazorTemplateFolderHost>
    {
        /// <summary>
        /// The Path where templates live
        /// </summary>
        public string TemplatePath  {get; set; }

        /// <summary>
        /// When rendering to a file render output to this
        /// file.
        /// </summary>
        public string RenderingOutputFile { get; set; }
        
        public RazorFolderHostContainer()
        {
            BaseBinaryFolder = Environment.CurrentDirectory;

            // Default the template path underneath the binary folder as \templates
            TemplatePath = Path.Combine(BaseBinaryFolder, "templates");
        }
        
        /// <summary>
        /// Renders a template to a TextWriter. Useful to write output into a stream or
        /// the Response object. Used for partial rendering.
        /// </summary>
        /// <param name="relativePath">Relative path to the file in the folder structure</param>
        /// <param name="context">Optional context object or null</param>
        /// <param name="writer">The textwriter to write output into</param>
        /// <returns></returns>
        public bool RenderTemplate(string relativePath, object context, TextWriter writer)
        {

            // Set configuration data that is to be passed to the template (any object) 
            Engine.TemplatePerRequestConfigurationData = new RazorFolderHostTemplateConfiguration()
            {
                TemplatePath = Path.Combine(this.TemplatePath, relativePath),
                TemplateRelativePath = relativePath,
            };
           
            CompiledAssemblyItem item = GetAssemblyFromFileAndCache(relativePath);

            if (item == null)
            {
                writer.Close();
                return false;
            }

            try
            {
                // String result will be empty as output will be rendered into the
                // Response object's stream output. However a null result denotes
                // an error 
                string result = Engine.RenderTemplateFromAssembly(item.AssemblyId, context, writer);

                if (result == null)
                {
                    this.SetError(Engine.ErrorMessage);
                    return false;
                }
            }
            catch (Exception ex)
            {
                this.SetError(ex.Message);
                return false;
            }
            finally
            {
                writer.Close();
            }

            return true;
        }

        /// <summary>
        /// Render a template from a source file on disk to a specified outputfile.
        /// </summary>
        /// <param name="relativePath">Relative path off the template root folder. Format: path/filename.cshtml</param>
        /// <param name="context">Any object that will be available in the template as a dynamic of this.Context</param>
        /// <param name="outputFile">Optional - output file where output is written to. If not specified the 
        /// RenderingOutputFile property is used instead
        /// </param>       
        /// <returns>true if rendering succeeds, false on failure - check ErrorMessage</returns>
        public bool RenderTemplate(string relativePath, object context, string outputFile)
        {
            if (outputFile == null)
                outputFile = RenderingOutputFile;

            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile, false,
                                                                Engine.Configuration.OutputEncoding,
                                                                Engine.Configuration.StreamBufferSize))
                {
                    return RenderTemplate(relativePath, context, writer);
                }
            }
            catch (Exception ex)
            {
                this.SetError(ex.Message);
                return false;
            }

            return true;
        }


        /// <summary>
        /// Renders a template to string. Useful for RenderTemplate 
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string RenderTemplateToString(string relativePath, object context)
        {
            string result = string.Empty;

            try
            {
                using (StringWriter writer = new StringWriter())
                {
                    // String result will be empty as output will be rendered into the
                    // Response object's stream output. However a null result denotes
                    // an error 
                    if (!RenderTemplate(relativePath, context, writer))
                    {
                        this.SetError(Engine.ErrorMessage);
                        return null;
                    }

                    result = writer.ToString();
                }
            }
            catch (Exception ex)
            {
                this.SetError(ex.Message);
                return null;
            }

            return result;
        }

        /// <summary>
        /// Internally checks if a cached assembly exists and if it does uses it
        /// else creates and compiles one. Returns an assembly Id to be 
        /// used with the LoadedAssembly list.
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        protected virtual CompiledAssemblyItem GetAssemblyFromFileAndCache(string relativePath)
        {
            string fileName = Path.Combine(TemplatePath, relativePath).ToLower();
            int fileNameHash = fileName.GetHashCode();
            if (!File.Exists(fileName))
            {
                this.SetError(Resources.TemplateFileDoesnTExist + fileName);
                return null;
            }

            CompiledAssemblyItem item = null;
            this.LoadedAssemblies.TryGetValue(fileNameHash, out item);

            string assemblyId = null;

            // Check for cached instance
            if (item != null)
            {
                var fileTime = File.GetLastWriteTimeUtc(fileName);
                if (fileTime <= item.CompileTimeUtc)
                    assemblyId = item.AssemblyId;
            }
            else
                item = new CompiledAssemblyItem();

            // No cached instance - create assembly and cache
            if (assemblyId == null)
            {
                string safeClassName = GetSafeClassName(fileName);
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(fileName, true);
                }
                catch (Exception ex)
                {
                    this.SetError(Resources.ErrorReadingTemplateFile + fileName);
                    return null;
                }

                assemblyId = Engine.ParseAndCompileTemplate(this.ReferencedAssemblies.ToArray(), reader);

                // need to ensure reader is closed
                if (reader != null)
                    reader.Close();

                if (assemblyId == null)
                {
                    this.SetError(Engine.ErrorMessage);
                    return null;
                }

                item.AssemblyId = assemblyId;
                item.CompileTimeUtc = DateTime.UtcNow;
                item.FileName = fileName;
                item.SafeClassName = safeClassName;

                this.LoadedAssemblies[fileNameHash] = item;
            }

            return item;
        }

        /// <summary>
        /// Determine if a file has been changed since a known date.
        /// Dates are specified in UTC format.
        /// </summary>
        /// <param name="relativePath">relative path to the template root.</param>
        /// <param name="originalTimeUtc"></param>
        /// <returns></returns>
        protected virtual bool HasFileChanged(string relativePath, DateTime originalTimeUtc)
        {
            string fileName = Path.Combine(this.TemplatePath, relativePath);
            DateTime lastWriteTime = File.GetLastWriteTimeUtc(fileName);

            if (lastWriteTime > originalTimeUtc)
                return true;

            return false;
        }

        /// <summary>
        /// Overridden to return a unique name based on the filename
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected override string GetSafeClassName(object objectId)
        {
            string fileName = objectId as string;
            fileName = Utilities.GetRelativePath(fileName, TemplatePath);
            return Path.GetFileNameWithoutExtension(fileName).Replace("\\", "_");
        }
    }

    public class CompiledAssemblyItem
    {
        public string AssemblyId { get; set; }
        public DateTime CompileTimeUtc { get; set; }
        public string FileName { get; set; }
        public string SafeClassName { get; set; }
        public string Namespace { get; set; }
    }

    [Serializable]
    public class RazorFolderHostTemplateConfiguration
    {
        public string TemplatePath = string.Empty;
        public string TemplateRelativePath = string.Empty;
        public string PhysicalPath = string.Empty;
    }
}
