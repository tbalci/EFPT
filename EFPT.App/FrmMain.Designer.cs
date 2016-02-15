namespace EFPT.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.UstMenu = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TlstrpBtnYeniPerformansTest = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StrpStatus = new System.Windows.Forms.StatusStrip();
            this.TlStrpDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.TlStrpVersiyon = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TpIslem = new System.Windows.Forms.TabControl();
            this.TpGiris = new System.Windows.Forms.TabPage();
            this.UstMenu.SuspendLayout();
            this.StrpStatus.SuspendLayout();
            this.TpIslem.SuspendLayout();
            this.SuspendLayout();
            // 
            // UstMenu
            // 
            this.UstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.UstMenu.Location = new System.Drawing.Point(0, 0);
            this.UstMenu.Name = "UstMenu";
            this.UstMenu.Size = new System.Drawing.Size(1147, 24);
            this.UstMenu.TabIndex = 0;
            this.UstMenu.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlstrpBtnYeniPerformansTest});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // TlstrpBtnYeniPerformansTest
            // 
            this.TlstrpBtnYeniPerformansTest.Name = "TlstrpBtnYeniPerformansTest";
            this.TlstrpBtnYeniPerformansTest.Size = new System.Drawing.Size(189, 22);
            this.TlstrpBtnYeniPerformansTest.Text = "Yeni Performans Testi";
            this.TlstrpBtnYeniPerformansTest.Click += new System.EventHandler(this.TlstrpBtnYeniPerformansTest_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // StrpStatus
            // 
            this.StrpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpDurum,
            this.toolStripStatusLabel1,
            this.TlStrpVersiyon});
            this.StrpStatus.Location = new System.Drawing.Point(0, 693);
            this.StrpStatus.Name = "StrpStatus";
            this.StrpStatus.Size = new System.Drawing.Size(1147, 22);
            this.StrpStatus.TabIndex = 1;
            this.StrpStatus.Text = "statusStrip1";
            // 
            // TlStrpDurum
            // 
            this.TlStrpDurum.Image = global::EFPT.App.Icons.DurumBilgi;
            this.TlStrpDurum.Name = "TlStrpDurum";
            this.TlStrpDurum.Size = new System.Drawing.Size(16, 17);
            // 
            // TlStrpVersiyon
            // 
            this.TlStrpVersiyon.Image = global::EFPT.App.Icons.Versiyon;
            this.TlStrpVersiyon.Name = "TlStrpVersiyon";
            this.TlStrpVersiyon.Size = new System.Drawing.Size(79, 17);
            this.TlStrpVersiyon.Text = "Ver. 1.0.0.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1037, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // TpIslem
            // 
            this.TpIslem.Controls.Add(this.TpGiris);
            this.TpIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpIslem.Location = new System.Drawing.Point(0, 24);
            this.TpIslem.Name = "TpIslem";
            this.TpIslem.SelectedIndex = 0;
            this.TpIslem.Size = new System.Drawing.Size(1147, 669);
            this.TpIslem.TabIndex = 3;
            // 
            // TpGiris
            // 
            this.TpGiris.Location = new System.Drawing.Point(4, 22);
            this.TpGiris.Name = "TpGiris";
            this.TpGiris.Padding = new System.Windows.Forms.Padding(3);
            this.TpGiris.Size = new System.Drawing.Size(1139, 643);
            this.TpGiris.TabIndex = 0;
            this.TpGiris.Text = "Giriş";
            this.TpGiris.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 715);
            this.Controls.Add(this.TpIslem);
            this.Controls.Add(this.StrpStatus);
            this.Controls.Add(this.UstMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.UstMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Framework Performans Aracı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmMain_ResizeEnd);
            this.UstMenu.ResumeLayout(false);
            this.UstMenu.PerformLayout();
            this.StrpStatus.ResumeLayout(false);
            this.StrpStatus.PerformLayout();
            this.TpIslem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UstMenu;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TlstrpBtnYeniPerformansTest;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StrpStatus;
        private System.Windows.Forms.ToolStripStatusLabel TlStrpDurum;
        private System.Windows.Forms.ToolStripStatusLabel TlStrpVersiyon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl TpIslem;
        private System.Windows.Forms.TabPage TpGiris;
    }
}

