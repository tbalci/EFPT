using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WSKTS.Lib
{
    public static class Json
    {

        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static string ToJson(this object obj, int recursionDepth)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RecursionLimit = recursionDepth;
            return serializer.Serialize(obj);
        }

        public static T FromJson<T>(this object obj)
        {
            string Sonuc = "";
            if (obj!=null)
            {
                Sonuc = obj.ToString();
            }
            return JsonConvert.DeserializeObject<T>(Sonuc);
        }
    }
}
