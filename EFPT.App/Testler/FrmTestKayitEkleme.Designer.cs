namespace EFPT.App.Testler
{
    partial class FrmTestKayitEkleme
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
            this.TpcIslem = new FarsiLibrary.Win.FATabStrip();
            this.TpcIslemPIslemler = new FarsiLibrary.Win.FATabStripItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnSonucGoster = new System.Windows.Forms.Button();
            this.NmrTekrarSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.NUDKayitSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVtSecimOracle = new System.Windows.Forms.Button();
            this.btnVtSecimMysql = new System.Windows.Forms.Button();
            this.btnVtSecimMssql = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtTestAciklama = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtTestAd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TpLog = new FarsiLibrary.Win.FATabStripItem();
            this.TxtPerformansLog = new System.Windows.Forms.TextBox();
            this.AracCubugu = new System.Windows.Forms.ToolStrip();
            this.btnLogKayit = new System.Windows.Forms.ToolStripButton();
            this.btnLogEkranTemizle = new System.Windows.Forms.ToolStripButton();
            this.TPRAPORLIST = new FarsiLibrary.Win.FATabStrip();
            this.TpPGiris = new FarsiLibrary.Win.FATabStripItem();
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).BeginInit();
            this.TpcIslem.SuspendLayout();
            this.TpcIslemPIslemler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrTekrarSayisi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDKayitSayisi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TpLog.SuspendLayout();
            this.AracCubugu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPRAPORLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // TpcIslem
            // 
            this.TpcIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpcIslem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TpcIslem.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.TpcIslemPIslemler,
            this.TpLog});
            this.TpcIslem.Location = new System.Drawing.Point(0, 0);
            this.TpcIslem.Name = "TpcIslem";
            this.TpcIslem.SelectedItem = this.TpcIslemPIslemler;
            this.TpcIslem.Size = new System.Drawing.Size(1119, 601);
            this.TpcIslem.TabIndex = 1;
            // 
            // TpcIslemPIslemler
            // 
            this.TpcIslemPIslemler.CanClose = false;
            this.TpcIslemPIslemler.Controls.Add(this.TPRAPORLIST);
            this.TpcIslemPIslemler.Controls.Add(this.groupBox1);
            this.TpcIslemPIslemler.Controls.Add(this.groupBox2);
            this.TpcIslemPIslemler.Controls.Add(this.groupBox4);
            this.TpcIslemPIslemler.Controls.Add(this.groupBox3);
            this.TpcIslemPIslemler.IsDrawn = true;
            this.TpcIslemPIslemler.Name = "TpcIslemPIslemler";
            this.TpcIslemPIslemler.Selected = true;
            this.TpcIslemPIslemler.Size = new System.Drawing.Size(1117, 580);
            this.TpcIslemPIslemler.TabIndex = 0;
            this.TpcIslemPIslemler.Title = "İşlemler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDurdur);
            this.groupBox1.Controls.Add(this.btnSonucGoster);
            this.groupBox1.Controls.Add(this.NmrTekrarSayisi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBaslat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 241);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1117, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ekleme Test İşlemleri";
            // 
            // btnDurdur
            // 
            this.btnDurdur.Enabled = false;
            this.btnDurdur.Location = new System.Drawing.Point(540, 11);
            this.btnDurdur.Margin = new System.Windows.Forms.Padding(4);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(117, 44);
            this.btnDurdur.TabIndex = 9;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnSonucGoster
            // 
            this.btnSonucGoster.Location = new System.Drawing.Point(664, 11);
            this.btnSonucGoster.Name = "btnSonucGoster";
            this.btnSonucGoster.Size = new System.Drawing.Size(117, 44);
            this.btnSonucGoster.TabIndex = 8;
            this.btnSonucGoster.Text = "Sonucu Göster";
            this.btnSonucGoster.UseVisualStyleBackColor = true;
            this.btnSonucGoster.Click += new System.EventHandler(this.btnSonucGoster_Click);
            // 
            // NmrTekrarSayisi
            // 
            this.NmrTekrarSayisi.Location = new System.Drawing.Point(187, 23);
            this.NmrTekrarSayisi.Name = "NmrTekrarSayisi";
            this.NmrTekrarSayisi.Size = new System.Drawing.Size(204, 23);
            this.NmrTekrarSayisi.TabIndex = 6;
            this.NmrTekrarSayisi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tekrar Sayısı";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(416, 11);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(117, 44);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoruntule);
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.NUDKayitSayisi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1117, 68);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veri Kümesi Oluşturma İşlemleri";
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(540, 16);
            this.btnGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(117, 44);
            this.btnGoruntule.TabIndex = 3;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(416, 16);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(117, 44);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // NUDKayitSayisi
            // 
            this.NUDKayitSayisi.Location = new System.Drawing.Point(187, 28);
            this.NUDKayitSayisi.Margin = new System.Windows.Forms.Padding(4);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oluşturulacak Kayıt Sayısı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVtSecimOracle);
            this.groupBox4.Controls.Add(this.btnVtSecimMysql);
            this.groupBox4.Controls.Add(this.btnVtSecimMssql);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(0, 87);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1117, 86);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Veri Tabanı Seçimi";
            // 
            // btnVtSecimOracle
            // 
            this.btnVtSecimOracle.Image = global::EFPT.App.Icons.Oracle;
            this.btnVtSecimOracle.Location = new System.Drawing.Point(164, 24);
            this.btnVtSecimOracle.Margin = new System.Windows.Forms.Padding(4);
            this.btnVtSecimOracle.Name = "btnVtSecimOracle";
            this.btnVtSecimOracle.Size = new System.Drawing.Size(70, 55);
            this.btnVtSecimOracle.TabIndex = 2;
            this.btnVtSecimOracle.UseVisualStyleBackColor = true;
            this.btnVtSecimOracle.Click += new System.EventHandler(this.btnVtSecimOracle_Click);
            // 
            // btnVtSecimMysql
            // 
            this.btnVtSecimMysql.Image = global::EFPT.App.Icons.Mysql;
            this.btnVtSecimMysql.Location = new System.Drawing.Point(86, 24);
            this.btnVtSecimMysql.Margin = new System.Windows.Forms.Padding(4);
            this.btnVtSecimMysql.Name = "btnVtSecimMysql";
            this.btnVtSecimMysql.Size = new System.Drawing.Size(70, 55);
            this.btnVtSecimMysql.TabIndex = 1;
            this.btnVtSecimMysql.UseVisualStyleBackColor = true;
            this.btnVtSecimMysql.Click += new System.EventHandler(this.btnVtSecimMysql_Click);
            // 
            // btnVtSecimMssql
            // 
            this.btnVtSecimMssql.Image = global::EFPT.App.Icons.Mssql;
            this.btnVtSecimMssql.Location = new System.Drawing.Point(8, 24);
            this.btnVtSecimMssql.Margin = new System.Windows.Forms.Padding(4);
            this.btnVtSecimMssql.Name = "btnVtSecimMssql";
            this.btnVtSecimMssql.Size = new System.Drawing.Size(70, 55);
            this.btnVtSecimMssql.TabIndex = 0;
            this.btnVtSecimMssql.UseVisualStyleBackColor = true;
            this.btnVtSecimMssql.Click += new System.EventHandler(this.btnVtSecimMssql_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1117, 87);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Bilgileri";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1109, 31);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TxtTestAciklama);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(130, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(979, 31);
            this.panel5.TabIndex = 1;
            // 
            // TxtTestAciklama
            // 
            this.TxtTestAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtTestAciklama.Location = new System.Drawing.Point(0, 0);
            this.TxtTestAciklama.Multiline = true;
            this.TxtTestAciklama.Name = "TxtTestAciklama";
            this.TxtTestAciklama.Size = new System.Drawing.Size(979, 31);
            this.TxtTestAciklama.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(130, 31);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtTestAd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(130, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 31);
            this.panel3.TabIndex = 1;
            // 
            // TxtTestAd
            // 
            this.TxtTestAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtTestAd.Location = new System.Drawing.Point(0, 0);
            this.TxtTestAd.Multiline = true;
            this.TxtTestAd.Name = "TxtTestAd";
            this.TxtTestAd.Size = new System.Drawing.Size(979, 31);
            this.TxtTestAd.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 31);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı";
            // 
            // TpLog
            // 
            this.TpLog.CanClose = false;
            this.TpLog.Controls.Add(this.TxtPerformansLog);
            this.TpLog.Controls.Add(this.AracCubugu);
            this.TpLog.IsDrawn = true;
            this.TpLog.Name = "TpLog";
            this.TpLog.Size = new System.Drawing.Size(1117, 580);
            this.TpLog.TabIndex = 1;
            this.TpLog.Title = "İşlem Geçmişi";
            // 
            // TxtPerformansLog
            // 
            this.TxtPerformansLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPerformansLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPerformansLog.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.TxtPerformansLog.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtPerformansLog.Location = new System.Drawing.Point(0, 25);
            this.TxtPerformansLog.Multiline = true;
            this.TxtPerformansLog.Name = "TxtPerformansLog";
            this.TxtPerformansLog.Size = new System.Drawing.Size(1117, 555);
            this.TxtPerformansLog.TabIndex = 2;
            // 
            // AracCubugu
            // 
            this.AracCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogKayit,
            this.btnLogEkranTemizle});
            this.AracCubugu.Location = new System.Drawing.Point(0, 0);
            this.AracCubugu.Name = "AracCubugu";
            this.AracCubugu.Size = new System.Drawing.Size(1117, 25);
            this.AracCubugu.TabIndex = 1;
            this.AracCubugu.Text = "toolStrip1";
            // 
            // btnLogKayit
            // 
            this.btnLogKayit.Image = global::EFPT.App.Icons.Kaydet;
            this.btnLogKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogKayit.Name = "btnLogKayit";
            this.btnLogKayit.Size = new System.Drawing.Size(63, 22);
            this.btnLogKayit.Text = "Kaydet";
            this.btnLogKayit.Click += new System.EventHandler(this.btnLogKayit_Click);
            // 
            // btnLogEkranTemizle
            // 
            this.btnLogEkranTemizle.Image = global::EFPT.App.Icons.Temizle;
            this.btnLogEkranTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogEkranTemizle.Name = "btnLogEkranTemizle";
            this.btnLogEkranTemizle.Size = new System.Drawing.Size(68, 22);
            this.btnLogEkranTemizle.Text = "Temizle";
            this.btnLogEkranTemizle.Click += new System.EventHandler(this.btnLogEkranTemizle_Click);
            // 
            // TPRAPORLIST
            // 
            this.TPRAPORLIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TPRAPORLIST.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TPRAPORLIST.Location = new System.Drawing.Point(0, 301);
            this.TPRAPORLIST.Name = "TPRAPORLIST";
            this.TPRAPORLIST.SelectedItem = this.TpPGiris;
            this.TPRAPORLIST.Size = new System.Drawing.Size(1117, 279);
            this.TPRAPORLIST.TabIndex = 14;
            // 
            // TpPGiris
            // 
            this.TpPGiris.IsDrawn = true;
            this.TpPGiris.Name = "TpPGiris";
            this.TpPGiris.Size = new System.Drawing.Size(1115, 258);
            this.TpPGiris.TabIndex = 0;
            this.TpPGiris.Title = "Giriş";
            // 
            // FrmTestKayitEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 601);
            this.Controls.Add(this.TpcIslem);
            this.Name = "FrmTestKayitEkleme";
            this.Text = "Test 1 : Kayıt Ekleme";
            this.Load += new System.EventHandler(this.FrmTestKayitEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).EndInit();
            this.TpcIslem.ResumeLayout(false);
            this.TpcIslemPIslemler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrTekrarSayisi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDKayitSayisi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TpLog.ResumeLayout(false);
            this.TpLog.PerformLayout();
            this.AracCubugu.ResumeLayout(false);
            this.AracCubugu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPRAPORLIST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.FATabStrip TpcIslem;
        private FarsiLibrary.Win.FATabStripItem TpcIslemPIslemler;
        private FarsiLibrary.Win.FATabStripItem TpLog;
        private System.Windows.Forms.TextBox TxtPerformansLog;
        private System.Windows.Forms.ToolStrip AracCubugu;
        private System.Windows.Forms.ToolStripButton btnLogKayit;
        private System.Windows.Forms.ToolStripButton btnLogEkranTemizle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox TxtTestAciklama;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox TxtTestAd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSonucGoster;
        private System.Windows.Forms.NumericUpDown NmrTekrarSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.NumericUpDown NUDKayitSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVtSecimOracle;
        private System.Windows.Forms.Button btnVtSecimMysql;
        private System.Windows.Forms.Button btnVtSecimMssql;
        private System.Windows.Forms.Button btnDurdur;
        private FarsiLibrary.Win.FATabStrip TPRAPORLIST;
        private FarsiLibrary.Win.FATabStripItem TpPGiris;
    }
}