namespace EFPT.Performans.ServerApp
{
    partial class FrmMain
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
            this.StrpStatus = new System.Windows.Forms.StatusStrip();
            this.TlStrpDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TlStrpVersiyon = new System.Windows.Forms.ToolStripStatusLabel();
            this.UstMenu = new System.Windows.Forms.MenuStrip();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtPerformansLog = new System.Windows.Forms.TextBox();
            this.AracCubugu = new System.Windows.Forms.ToolStrip();
            this.btnLogKayit = new System.Windows.Forms.ToolStripButton();
            this.btnLogEkranTemizle = new System.Windows.Forms.ToolStripButton();
            this.StrpStatus.SuspendLayout();
            this.UstMenu.SuspendLayout();
            this.AracCubugu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StrpStatus
            // 
            this.StrpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpDurum,
            this.toolStripStatusLabel1,
            this.TlStrpVersiyon});
            this.StrpStatus.Location = new System.Drawing.Point(0, 595);
            this.StrpStatus.Name = "StrpStatus";
            this.StrpStatus.Size = new System.Drawing.Size(1056, 22);
            this.StrpStatus.TabIndex = 3;
            this.StrpStatus.Text = "statusStrip1";
            // 
            // TlStrpDurum
            // 
            this.TlStrpDurum.Name = "TlStrpDurum";
            this.TlStrpDurum.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(978, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // TlStrpVersiyon
            // 
            this.TlStrpVersiyon.Name = "TlStrpVersiyon";
            this.TlStrpVersiyon.Size = new System.Drawing.Size(63, 17);
            this.TlStrpVersiyon.Text = "Ver. 1.0.0.0";
            // 
            // UstMenu
            // 
            this.UstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CikisToolStripMenuItem});
            this.UstMenu.Location = new System.Drawing.Point(0, 0);
            this.UstMenu.Name = "UstMenu";
            this.UstMenu.Size = new System.Drawing.Size(1056, 24);
            this.UstMenu.TabIndex = 2;
            this.UstMenu.Text = "menuStrip1";
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.CikisToolStripMenuItem.Text = "Çıkış";
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.CikisToolStripMenuItem_Click);
            // 
            // TxtPerformansLog
            // 
            this.TxtPerformansLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPerformansLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPerformansLog.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.TxtPerformansLog.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtPerformansLog.Location = new System.Drawing.Point(0, 49);
            this.TxtPerformansLog.Multiline = true;
            this.TxtPerformansLog.Name = "TxtPerformansLog";
            this.TxtPerformansLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtPerformansLog.Size = new System.Drawing.Size(1056, 546);
            this.TxtPerformansLog.TabIndex = 5;
            // 
            // AracCubugu
            // 
            this.AracCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogKayit,
            this.btnLogEkranTemizle});
            this.AracCubugu.Location = new System.Drawing.Point(0, 24);
            this.AracCubugu.Name = "AracCubugu";
            this.AracCubugu.Size = new System.Drawing.Size(1056, 25);
            this.AracCubugu.TabIndex = 4;
            this.AracCubugu.Text = "toolStrip1";
            // 
            // btnLogKayit
            // 
            this.btnLogKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogKayit.Name = "btnLogKayit";
            this.btnLogKayit.Size = new System.Drawing.Size(47, 22);
            this.btnLogKayit.Text = "Kaydet";
            // 
            // btnLogEkranTemizle
            // 
            this.btnLogEkranTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogEkranTemizle.Name = "btnLogEkranTemizle";
            this.btnLogEkranTemizle.Size = new System.Drawing.Size(52, 22);
            this.btnLogEkranTemizle.Text = "Temizle";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 617);
            this.Controls.Add(this.TxtPerformansLog);
            this.Controls.Add(this.AracCubugu);
            this.Controls.Add(this.StrpStatus);
            this.Controls.Add(this.UstMenu);
            this.Name = "FrmMain";
            this.Text = "EFPT Server Performans Kayit Uygulaması";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.StrpStatus.ResumeLayout(false);
            this.StrpStatus.PerformLayout();
            this.UstMenu.ResumeLayout(false);
            this.UstMenu.PerformLayout();
            this.AracCubugu.ResumeLayout(false);
            this.AracCubugu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StrpStatus;
        private System.Windows.Forms.ToolStripStatusLabel TlStrpDurum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TlStrpVersiyon;
        private System.Windows.Forms.MenuStrip UstMenu;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtPerformansLog;
        private System.Windows.Forms.ToolStrip AracCubugu;
        private System.Windows.Forms.ToolStripButton btnLogKayit;
        private System.Windows.Forms.ToolStripButton btnLogEkranTemizle;
    }
}

