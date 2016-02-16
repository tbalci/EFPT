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

        public void FormEkle(Form Form)
        {
            FarsiLibrary.Win.FATabStripItem Tp = new FarsiLibrary.Win.FATabStripItem();
            Tp.Title = Form.Text;
            Form.TopLevel = false;
            Form.Visible = true;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            Tp.Controls.Add(Form);
            Tp.CanClose = false;
            Tp.Image = Form.Icon.ToBitmap();
            TpcIslem.AddTab(Tp,true);
            DurumBilgisiVer(string.Format("{0} Ekranı Oluşturuldu",Form.Text));
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
                FrmPerFormansTest FrmPerFormansTest = new FrmPerFormansTest();
                FrmPerFormansTest.Text = YeniSihirbaz.TxtTestAd.Text.Trim()==""?"Yeni Performans Testi": YeniSihirbaz.TxtTestAd.Text.Trim();
                FrmPerFormansTest.TestBilgileri = new PeromasnTestBilgi() { VeriTabaniTipi = YeniSihirbaz.VeriTabaniTipi, UserListesi = YeniSihirbaz.Userlistesi };
                FrmMain.AktifMainForm.FormEkle(FrmPerFormansTest);

            }
            else
            {

            }
        }
    }
}
