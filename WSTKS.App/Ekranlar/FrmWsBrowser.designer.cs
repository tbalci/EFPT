namespace WSKTS.App.Ekranlar
{
    partial class FrmWsBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWsBrowser));
            this.TpcIslem = new FarsiLibrary.Win.FATabStrip();
            this.TpcIslemPIslemler = new FarsiLibrary.Win.FATabStripItem();
            this.fTpBrowserListesi = new FarsiLibrary.Win.FATabStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TlStrpBtnYeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TpLog = new FarsiLibrary.Win.FATabStripItem();
            this.TxtPerformansLog = new System.Windows.Forms.TextBox();
            this.AracCubugu = new System.Windows.Forms.ToolStrip();
            this.btnLogKayit = new System.Windows.Forms.ToolStripButton();
            this.btnLogEkranTemizle = new System.Windows.Forms.ToolStripButton();
            this.faTabStripItem1 = new FarsiLibrary.Win.FATabStripItem();
            this.faTabStripItem2 = new FarsiLibrary.Win.FATabStripItem();
            this.TpPGiris = new FarsiLibrary.Win.FATabStripItem();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.tlStrpAktifPasif = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).BeginInit();
            this.TpcIslem.SuspendLayout();
            this.TpcIslemPIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fTpBrowserListesi)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.TpLog.SuspendLayout();
            this.AracCubugu.SuspendLayout();
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
            this.TpcIslem.TabIndex = 0;
            // 
            // TpcIslemPIslemler
            // 
            this.TpcIslemPIslemler.CanClose = false;
            this.TpcIslemPIslemler.Controls.Add(this.fTpBrowserListesi);
            this.TpcIslemPIslemler.Controls.Add(this.toolStrip1);
            this.TpcIslemPIslemler.IsDrawn = true;
            this.TpcIslemPIslemler.Name = "TpcIslemPIslemler";
            this.TpcIslemPIslemler.Selected = true;
            this.TpcIslemPIslemler.Size = new System.Drawing.Size(1117, 580);
            this.TpcIslemPIslemler.TabIndex = 0;
            this.TpcIslemPIslemler.Title = "İşlemler";
            // 
            // fTpBrowserListesi
            // 
            this.fTpBrowserListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fTpBrowserListesi.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fTpBrowserListesi.Location = new System.Drawing.Point(0, 25);
            this.fTpBrowserListesi.Name = "fTpBrowserListesi";
            this.fTpBrowserListesi.Size = new System.Drawing.Size(1117, 555);
            this.fTpBrowserListesi.TabIndex = 17;
            this.fTpBrowserListesi.Text = "faTabStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpBtnYeni,
            this.toolStripButton2,
            this.tlStrpAktifPasif});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1117, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TlStrpBtnYeni
            // 
            this.TlStrpBtnYeni.Image = global::WSKTS.App.Icons.Yeni;
            this.TlStrpBtnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnYeni.Name = "TlStrpBtnYeni";
            this.TlStrpBtnYeni.Size = new System.Drawing.Size(50, 22);
            this.TlStrpBtnYeni.Text = "Yeni";
            this.TlStrpBtnYeni.Click += new System.EventHandler(this.TlStrpBtnYeni_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::WSKTS.App.Icons.Temizle;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton2.Text = "Temizle";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.TxtPerformansLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
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
            this.btnLogKayit.Image = global::WSKTS.App.Icons.Kaydet;
            this.btnLogKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogKayit.Name = "btnLogKayit";
            this.btnLogKayit.Size = new System.Drawing.Size(63, 22);
            this.btnLogKayit.Text = "Kaydet";
            this.btnLogKayit.Click += new System.EventHandler(this.btnLogKayit_Click);
            // 
            // btnLogEkranTemizle
            // 
            this.btnLogEkranTemizle.Image = global::WSKTS.App.Icons.Temizle;
            this.btnLogEkranTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogEkranTemizle.Name = "btnLogEkranTemizle";
            this.btnLogEkranTemizle.Size = new System.Drawing.Size(68, 22);
            this.btnLogEkranTemizle.Text = "Temizle";
            this.btnLogEkranTemizle.Click += new System.EventHandler(this.btnLogEkranTemizle_Click);
            // 
            // faTabStripItem1
            // 
            this.faTabStripItem1.IsDrawn = true;
            this.faTabStripItem1.Name = "faTabStripItem1";
            this.faTabStripItem1.Selected = true;
            this.faTabStripItem1.Size = new System.Drawing.Size(1115, 236);
            this.faTabStripItem1.TabIndex = 0;
            this.faTabStripItem1.Title = "TabStrip Page 1";
            // 
            // faTabStripItem2
            // 
            this.faTabStripItem2.IsDrawn = true;
            this.faTabStripItem2.Name = "faTabStripItem2";
            this.faTabStripItem2.Size = new System.Drawing.Size(1115, 128);
            this.faTabStripItem2.TabIndex = 1;
            this.faTabStripItem2.Title = "TabStrip Page 2";
            // 
            // TpPGiris
            // 
            this.TpPGiris.IsDrawn = true;
            this.TpPGiris.Name = "TpPGiris";
            this.TpPGiris.Selected = true;
            this.TpPGiris.Size = new System.Drawing.Size(1115, 258);
            this.TpPGiris.TabIndex = 0;
            this.TpPGiris.Title = "Giriş";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(140, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1109, 25);
            this.miniToolStrip.TabIndex = 4;
            // 
            // tlStrpAktifPasif
            // 
            this.tlStrpAktifPasif.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlStrpAktifPasif.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlStrpAktifPasif.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpAktifPasif.Image")));
            this.tlStrpAktifPasif.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpAktifPasif.Name = "tlStrpAktifPasif";
            this.tlStrpAktifPasif.Size = new System.Drawing.Size(82, 22);
            this.tlStrpAktifPasif.Text = "Log Pasif Yap";
            this.tlStrpAktifPasif.Click += new System.EventHandler(this.tlStrpAktifPasif_Click);
            // 
            // FrmWsBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 601);
            this.Controls.Add(this.TpcIslem);
            this.Name = "FrmWsBrowser";
            this.Text = "Test 1 : Kayıt Ekleme";
            this.Load += new System.EventHandler(this.FrmTestKayitEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).EndInit();
            this.TpcIslem.ResumeLayout(false);
            this.TpcIslemPIslemler.ResumeLayout(false);
            this.TpcIslemPIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fTpBrowserListesi)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TpLog.ResumeLayout(false);
            this.TpLog.PerformLayout();
            this.AracCubugu.ResumeLayout(false);
            this.AracCubugu.PerformLayout();
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
        private FarsiLibrary.Win.FATabStripItem TpPGiris;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TlStrpBtnYeni;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem1;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem2;
        private FarsiLibrary.Win.FATabStrip fTpBrowserListesi;
        private System.Windows.Forms.ToolStripButton tlStrpAktifPasif;
    }
}