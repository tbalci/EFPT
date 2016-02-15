namespace EFPT.App
{
    partial class FrmSihirbaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StrpStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDKayitSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnTestiBaslat = new System.Windows.Forms.Button();
            this.TlStrpDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnVtSecimOracle = new System.Windows.Forms.Button();
            this.btnVtSecimMysql = new System.Windows.Forms.Button();
            this.btnVtSecimMssql = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.StrpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDKayitSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVtSecimOracle);
            this.groupBox1.Controls.Add(this.btnVtSecimMysql);
            this.groupBox1.Controls.Add(this.btnVtSecimMssql);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1053, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri Tabanı Seçimi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoruntule);
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.NUDKayitSayisi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1053, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veri Kümesi Oluşturma İşlemleri";
            // 
            // StrpStatus
            // 
            this.StrpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpDurum,
            this.toolStripStatusLabel1});
            this.StrpStatus.Location = new System.Drawing.Point(0, 686);
            this.StrpStatus.Name = "StrpStatus";
            this.StrpStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StrpStatus.Size = new System.Drawing.Size(1053, 22);
            this.StrpStatus.TabIndex = 2;
            this.StrpStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1017, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oluşturulacak Kayıt Sayısı";
            // 
            // NUDKayitSayisi
            // 
            this.NUDKayitSayisi.Location = new System.Drawing.Point(244, 27);
            this.NUDKayitSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUDKayitSayisi.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUDKayitSayisi.Name = "NUDKayitSayisi";
            this.NUDKayitSayisi.Size = new System.Drawing.Size(204, 23);
            this.NUDKayitSayisi.TabIndex = 1;
            this.NUDKayitSayisi.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(9, 75);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(117, 44);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(135, 75);
            this.btnGoruntule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(117, 44);
            this.btnGoruntule.TabIndex = 3;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnTestiBaslat
            // 
            this.btnTestiBaslat.Location = new System.Drawing.Point(316, 389);
            this.btnTestiBaslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestiBaslat.Name = "btnTestiBaslat";
            this.btnTestiBaslat.Size = new System.Drawing.Size(324, 81);
            this.btnTestiBaslat.TabIndex = 3;
            this.btnTestiBaslat.Text = "Oluştur";
            this.btnTestiBaslat.UseVisualStyleBackColor = true;
            // 
            // TlStrpDurum
            // 
            this.TlStrpDurum.Image = global::EFPT.App.Icons.DurumBilgi;
            this.TlStrpDurum.Name = "TlStrpDurum";
            this.TlStrpDurum.Size = new System.Drawing.Size(16, 16);
            // 
            // btnVtSecimOracle
            // 
            this.btnVtSecimOracle.Image = global::EFPT.App.Icons.Oracle;
            this.btnVtSecimOracle.Location = new System.Drawing.Point(419, 37);
            this.btnVtSecimOracle.Margin = new System.Windows.Forms.Padding(4);
            this.btnVtSecimOracle.Name = "btnVtSecimOracle";
            this.btnVtSecimOracle.Size = new System.Drawing.Size(125, 97);
            this.btnVtSecimOracle.TabIndex = 2;
            this.btnVtSecimOracle.UseVisualStyleBackColor = true;
            this.btnVtSecimOracle.Click += new System.EventHandler(this.btnVtSecimOracle_Click);
            // 
            // btnVtSecimMysql
            // 
            this.btnVtSecimMysql.Image = global::EFPT.App.Icons.Mysql;
            this.btnVtSecimMysql.Location = new System.Drawing.Point(232, 37);
            this.btnVtSecimMysql.Margin = new System.Windows.Forms.Padding(4);
            this.btnVtSecimMysql.Name = "btnVtSecimMysql";
            this.btnVtSecimMysql.Size = new System.Drawing.Size(125, 97);
            this.btnVtSecimMysql.TabIndex = 1;
            this.btnVtSecimMysql.UseVisualStyleBackColor = true;
            this.btnVtSecimMysql.Click += new System.EventHandler(this.btnVtSecimMysql_Click);
            // 
            // btnVtSecimMssql
            // 
            this.btnVtSecimMssql.Image = global::EFPT.App.Icons.Mssql;
            this.btnVtSecimMssql.Location = new System.Drawing.Point(45, 37);
            this.btnVtSecimMssql.Margin = new System.Windows.Forms.Padding(4);
            this.btnVtSecimMssql.Name = "btnVtSecimMssql";
            this.btnVtSecimMssql.Size = new System.Drawing.Size(125, 97);
            this.btnVtSecimMssql.TabIndex = 0;
            this.btnVtSecimMssql.UseVisualStyleBackColor = true;
            this.btnVtSecimMssql.Click += new System.EventHandler(this.btnVtSecimMssql_Click);
            // 
            // FrmSihirbaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 708);
            this.Controls.Add(this.btnTestiBaslat);
            this.Controls.Add(this.StrpStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSihirbaz";
            this.Text = "FrmSihirbaz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSihirbaz_FormClosed);
            this.Load += new System.EventHandler(this.FrmSihirbaz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StrpStatus.ResumeLayout(false);
            this.StrpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDKayitSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip StrpStatus;
        private System.Windows.Forms.ToolStripStatusLabel TlStrpDurum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnVtSecimMssql;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.NumericUpDown NUDKayitSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVtSecimOracle;
        private System.Windows.Forms.Button btnVtSecimMysql;
        private System.Windows.Forms.Button btnTestiBaslat;
    }
}