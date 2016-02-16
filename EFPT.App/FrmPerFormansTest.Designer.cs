namespace EFPT.App
{
    partial class FrmPerFormansTest
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
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnVerileriGoruntule = new System.Windows.Forms.Button();
            this.TpLog = new FarsiLibrary.Win.FATabStripItem();
            this.AracCubugu = new System.Windows.Forms.ToolStrip();
            this.TxtPerformansLog = new System.Windows.Forms.TextBox();
            this.btnLogKayit = new System.Windows.Forms.ToolStripButton();
            this.btnLogEkranTemizle = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).BeginInit();
            this.TpcIslem.SuspendLayout();
            this.TpcIslemPIslemler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TpLog.SuspendLayout();
            this.AracCubugu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TpcIslem
            // 
            this.TpcIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpcIslem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TpcIslem.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.TpLog,
            this.TpcIslemPIslemler});
            this.TpcIslem.Location = new System.Drawing.Point(0, 0);
            this.TpcIslem.Name = "TpcIslem";
            this.TpcIslem.SelectedItem = this.TpLog;
            this.TpcIslem.Size = new System.Drawing.Size(893, 636);
            this.TpcIslem.TabIndex = 0;
            this.TpcIslem.Text = "faTabStrip1";
            // 
            // TpcIslemPIslemler
            // 
            this.TpcIslemPIslemler.CanClose = false;
            this.TpcIslemPIslemler.Controls.Add(this.groupBox1);
            this.TpcIslemPIslemler.IsDrawn = true;
            this.TpcIslemPIslemler.Name = "TpcIslemPIslemler";
            this.TpcIslemPIslemler.Size = new System.Drawing.Size(891, 615);
            this.TpcIslemPIslemler.TabIndex = 0;
            this.TpcIslemPIslemler.Title = "Test İşlemleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBaslat);
            this.groupBox1.Controls.Add(this.btnVerileriGoruntule);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(891, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ekleme Test İşlemleri";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(195, 24);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(177, 52);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Test\'i Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnVerileriGoruntule
            // 
            this.btnVerileriGoruntule.Location = new System.Drawing.Point(8, 24);
            this.btnVerileriGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerileriGoruntule.Name = "btnVerileriGoruntule";
            this.btnVerileriGoruntule.Size = new System.Drawing.Size(177, 52);
            this.btnVerileriGoruntule.TabIndex = 2;
            this.btnVerileriGoruntule.Text = "Verileri Görüntüle";
            this.btnVerileriGoruntule.UseVisualStyleBackColor = true;
            this.btnVerileriGoruntule.Click += new System.EventHandler(this.btnVerileriGoruntule_Click);
            // 
            // TpLog
            // 
            this.TpLog.CanClose = false;
            this.TpLog.Controls.Add(this.TxtPerformansLog);
            this.TpLog.Controls.Add(this.AracCubugu);
            this.TpLog.IsDrawn = true;
            this.TpLog.Name = "TpLog";
            this.TpLog.Selected = true;
            this.TpLog.Size = new System.Drawing.Size(891, 615);
            this.TpLog.TabIndex = 1;
            this.TpLog.Title = "İşlem Geçmişi";
            // 
            // AracCubugu
            // 
            this.AracCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogKayit,
            this.btnLogEkranTemizle});
            this.AracCubugu.Location = new System.Drawing.Point(0, 0);
            this.AracCubugu.Name = "AracCubugu";
            this.AracCubugu.Size = new System.Drawing.Size(891, 25);
            this.AracCubugu.TabIndex = 1;
            this.AracCubugu.Text = "toolStrip1";
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
            this.TxtPerformansLog.Size = new System.Drawing.Size(891, 590);
            this.TxtPerformansLog.TabIndex = 2;
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
            // FrmPerFormansTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 636);
            this.Controls.Add(this.TpcIslem);
            this.Name = "FrmPerFormansTest";
            this.Text = "FrmPerFormansTest";
            this.Load += new System.EventHandler(this.FrmPerFormansTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).EndInit();
            this.TpcIslem.ResumeLayout(false);
            this.TpcIslemPIslemler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnVerileriGoruntule;
        private System.Windows.Forms.ToolStrip AracCubugu;
        private System.Windows.Forms.ToolStripButton btnLogKayit;
        private System.Windows.Forms.ToolStripButton btnLogEkranTemizle;
        private System.Windows.Forms.TextBox TxtPerformansLog;
    }
}