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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TlStrpVersiyon = new System.Windows.Forms.ToolStripStatusLabel();
            this.TpcIslem = new FarsiLibrary.Win.FATabStrip();
            this.TpPGiris = new FarsiLibrary.Win.FATabStripItem();
            this.faTabStripItem2 = new FarsiLibrary.Win.FATabStripItem();
            this.faTabStripItem3 = new FarsiLibrary.Win.FATabStripItem();
            this.UstMenu.SuspendLayout();
            this.StrpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).BeginInit();
            this.TpcIslem.SuspendLayout();
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1037, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // TlStrpVersiyon
            // 
            this.TlStrpVersiyon.Image = global::EFPT.App.Icons.Versiyon;
            this.TlStrpVersiyon.Name = "TlStrpVersiyon";
            this.TlStrpVersiyon.Size = new System.Drawing.Size(79, 17);
            this.TlStrpVersiyon.Text = "Ver. 1.0.0.0";
            // 
            // TpcIslem
            // 
            this.TpcIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpcIslem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TpcIslem.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.TpPGiris});
            this.TpcIslem.Location = new System.Drawing.Point(0, 24);
            this.TpcIslem.Name = "TpcIslem";
            this.TpcIslem.SelectedItem = this.TpPGiris;
            this.TpcIslem.Size = new System.Drawing.Size(1147, 669);
            this.TpcIslem.TabIndex = 2;
            // 
            // TpPGiris
            // 
            this.TpPGiris.IsDrawn = true;
            this.TpPGiris.Name = "TpPGiris";
            this.TpPGiris.Selected = true;
            this.TpPGiris.Size = new System.Drawing.Size(1145, 648);
            this.TpPGiris.TabIndex = 0;
            this.TpPGiris.Title = "Giriş";
            // 
            // faTabStripItem2
            // 
            this.faTabStripItem2.IsDrawn = true;
            this.faTabStripItem2.Name = "faTabStripItem2";
            this.faTabStripItem2.Selected = true;
            this.faTabStripItem2.Size = new System.Drawing.Size(1145, 648);
            this.faTabStripItem2.TabIndex = 1;
            this.faTabStripItem2.Title = "TabStrip Page 2";
            // 
            // faTabStripItem3
            // 
            this.faTabStripItem3.IsDrawn = true;
            this.faTabStripItem3.Name = "faTabStripItem3";
            this.faTabStripItem3.Size = new System.Drawing.Size(1145, 648);
            this.faTabStripItem3.TabIndex = 2;
            this.faTabStripItem3.Title = "TabStrip Page 3";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 715);
            this.Controls.Add(this.TpcIslem);
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
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).EndInit();
            this.TpcIslem.ResumeLayout(false);
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
        private FarsiLibrary.Win.FATabStrip TpcIslem;
        private FarsiLibrary.Win.FATabStripItem TpPGiris;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem2;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem3;
    }
}

