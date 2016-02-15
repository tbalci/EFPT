namespace EFPT.App
{
    partial class FrmVeriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrdVeri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdVeri
            // 
            this.GrdVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdVeri.Location = new System.Drawing.Point(0, 0);
            this.GrdVeri.Name = "GrdVeri";
            this.GrdVeri.Size = new System.Drawing.Size(1080, 713);
            this.GrdVeri.TabIndex = 0;
            // 
            // FrmVeriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 713);
            this.Controls.Add(this.GrdVeri);
            this.Name = "FrmVeriler";
            this.Text = "FrmVeriler";
            this.Load += new System.EventHandler(this.FrmVeriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdVeri;
    }
}