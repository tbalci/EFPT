namespace WSKTS.App.Ekranlar
{
    partial class FrmShrGezgin
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
            this.btnIslemiBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.Url = new System.Windows.Forms.Label();
            this.NAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NSaniyeIlk = new System.Windows.Forms.NumericUpDown();
            this.NSaniyeSon = new System.Windows.Forms.NumericUpDown();
            this.ChkSiteGezinmeDurumu = new System.Windows.Forms.CheckBox();
            this.ChkCerezDurumu = new System.Windows.Forms.CheckBox();
            this.NProxySaniyeSon = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NProxySaniyeIlk = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSaniyeIlk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSaniyeSon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NProxySaniyeSon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NProxySaniyeIlk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIslemiBaslat
            // 
            this.btnIslemiBaslat.Location = new System.Drawing.Point(110, 210);
            this.btnIslemiBaslat.Name = "btnIslemiBaslat";
            this.btnIslemiBaslat.Size = new System.Drawing.Size(377, 63);
            this.btnIslemiBaslat.TabIndex = 0;
            this.btnIslemiBaslat.Text = "İşlemi Başlat";
            this.btnIslemiBaslat.UseVisualStyleBackColor = true;
            this.btnIslemiBaslat.Click += new System.EventHandler(this.btnIslemiBaslat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(65, 21);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(506, 20);
            this.txtAd.TabIndex = 2;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(65, 47);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(506, 20);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // Url
            // 
            this.Url.AutoSize = true;
            this.Url.Location = new System.Drawing.Point(24, 51);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(20, 13);
            this.Url.TabIndex = 3;
            this.Url.Text = "Url";
            // 
            // NAdet
            // 
            this.NAdet.Location = new System.Drawing.Point(65, 74);
            this.NAdet.Name = "NAdet";
            this.NAdet.Size = new System.Drawing.Size(120, 20);
            this.NAdet.TabIndex = 5;
            this.NAdet.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saniye";
            // 
            // NSaniyeIlk
            // 
            this.NSaniyeIlk.Location = new System.Drawing.Point(65, 100);
            this.NSaniyeIlk.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NSaniyeIlk.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NSaniyeIlk.Name = "NSaniyeIlk";
            this.NSaniyeIlk.Size = new System.Drawing.Size(120, 20);
            this.NSaniyeIlk.TabIndex = 7;
            this.NSaniyeIlk.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // NSaniyeSon
            // 
            this.NSaniyeSon.Location = new System.Drawing.Point(191, 100);
            this.NSaniyeSon.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NSaniyeSon.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NSaniyeSon.Name = "NSaniyeSon";
            this.NSaniyeSon.Size = new System.Drawing.Size(120, 20);
            this.NSaniyeSon.TabIndex = 9;
            this.NSaniyeSon.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // ChkSiteGezinmeDurumu
            // 
            this.ChkSiteGezinmeDurumu.AutoSize = true;
            this.ChkSiteGezinmeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChkSiteGezinmeDurumu.ForeColor = System.Drawing.Color.Red;
            this.ChkSiteGezinmeDurumu.Location = new System.Drawing.Point(65, 150);
            this.ChkSiteGezinmeDurumu.Name = "ChkSiteGezinmeDurumu";
            this.ChkSiteGezinmeDurumu.Size = new System.Drawing.Size(208, 19);
            this.ChkSiteGezinmeDurumu.TabIndex = 10;
            this.ChkSiteGezinmeDurumu.Text = "Url İçinme Gezinme Durumu";
            this.ChkSiteGezinmeDurumu.UseVisualStyleBackColor = true;
            // 
            // ChkCerezDurumu
            // 
            this.ChkCerezDurumu.AutoSize = true;
            this.ChkCerezDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChkCerezDurumu.ForeColor = System.Drawing.Color.Red;
            this.ChkCerezDurumu.Location = new System.Drawing.Point(65, 175);
            this.ChkCerezDurumu.Name = "ChkCerezDurumu";
            this.ChkCerezDurumu.Size = new System.Drawing.Size(171, 19);
            this.ChkCerezDurumu.TabIndex = 11;
            this.ChkCerezDurumu.Text = "Çerez Silinme Durumu";
            this.ChkCerezDurumu.UseVisualStyleBackColor = true;
            // 
            // NProxySaniyeSon
            // 
            this.NProxySaniyeSon.Location = new System.Drawing.Point(191, 126);
            this.NProxySaniyeSon.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NProxySaniyeSon.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NProxySaniyeSon.Name = "NProxySaniyeSon";
            this.NProxySaniyeSon.Size = new System.Drawing.Size(120, 20);
            this.NProxySaniyeSon.TabIndex = 14;
            this.NProxySaniyeSon.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Proxy";
            // 
            // NProxySaniyeIlk
            // 
            this.NProxySaniyeIlk.Location = new System.Drawing.Point(65, 126);
            this.NProxySaniyeIlk.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NProxySaniyeIlk.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NProxySaniyeIlk.Name = "NProxySaniyeIlk";
            this.NProxySaniyeIlk.Size = new System.Drawing.Size(120, 20);
            this.NProxySaniyeIlk.TabIndex = 12;
            this.NProxySaniyeIlk.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // FrmShrGezgin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 320);
            this.Controls.Add(this.NProxySaniyeSon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NProxySaniyeIlk);
            this.Controls.Add(this.ChkCerezDurumu);
            this.Controls.Add(this.ChkSiteGezinmeDurumu);
            this.Controls.Add(this.NSaniyeSon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NSaniyeIlk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NAdet);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIslemiBaslat);
            this.Name = "FrmShrGezgin";
            this.Text = "FrmShrGezgin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmShrGezgin_FormClosed);
            this.Load += new System.EventHandler(this.FrmShrGezgin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSaniyeIlk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSaniyeSon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NProxySaniyeSon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NProxySaniyeIlk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIslemiBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label Url;
        private System.Windows.Forms.NumericUpDown NAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NSaniyeIlk;
        private System.Windows.Forms.NumericUpDown NSaniyeSon;
        private System.Windows.Forms.CheckBox ChkSiteGezinmeDurumu;
        private System.Windows.Forms.CheckBox ChkCerezDurumu;
        private System.Windows.Forms.NumericUpDown NProxySaniyeSon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NProxySaniyeIlk;
    }
}