using WSKTS.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSKTS.App
{
    public partial class FrmSihirbaz : Form
    {

        public FrmSihirbaz()
        {
            InitializeComponent();
            this.Icon = FrmMain.AktifMainForm.Icon;
        }

        private void FrmSihirbaz_Load(object sender, EventArgs e)
        {
            FrmMain.AktifMainForm.DurumBilgisiVer("Yeni Performans Test Sihirbazı Başlatıldı");
        }

        private void FrmSihirbaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.AktifMainForm.DurumBilgisiVer("Yeni Performans Test Sihirbazı Kapatıldı");
        }

        private void btnVtSecimMssql_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVtSecimMysql_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVtSecimOracle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {

       }

        private void btnTestiBaslat_Click(object sender, EventArgs e)
        {

        }
    }
}
