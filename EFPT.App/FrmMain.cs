using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFPT.App
{
    public partial class FrmMain : Form
    {
        public static FrmMain AktifMainForm=null;

        public void DurumBilgisiVer(string Mesaj)
        {
            TlStrpDurum.Text = string.Format("{0} : {1}",DateTime.Now.ToString(), Mesaj);
        }
        public FrmMain()
        {
            InitializeComponent();
            AktifMainForm= this;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DurumBilgisiVer("Sistem Açıldı.");
        }

        private void FrmMain_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        private void TlstrpBtnYeniPerformansTest_Click(object sender, EventArgs e)
        {
            FrmSihirbaz YeniSihirbaz = new FrmSihirbaz();
            YeniSihirbaz.Text = "Yeni Performans Test İşlemleri";
            YeniSihirbaz.WindowState = FormWindowState.Normal;
            YeniSihirbaz.StartPosition = FormStartPosition.CenterParent;
            YeniSihirbaz.MaximizeBox = false;
            YeniSihirbaz.MinimizeBox = false;
            DialogResult Sonuc = YeniSihirbaz.ShowDialog();
            if (Sonuc == DialogResult.OK)
            {

            }
            else
            {

            }
        }
    }
}
