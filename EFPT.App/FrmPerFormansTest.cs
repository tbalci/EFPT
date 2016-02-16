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
    public partial class FrmPerFormansTest : Form
    {
        public PeromasnTestBilgi TestBilgileri { get; set; }
        public FrmPerFormansTest()
        {
            InitializeComponent();
        }

        public void LogEkle(string Mesaj)
        {
            TxtPerformansLog.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString(), Mesaj, Environment.NewLine);
        }


        private void FrmPerFormansTest_Load(object sender, EventArgs e)
        {
            AracCubugu.ImageScalingSize = new Size(32, 32);
            TpcIslem.SelectedItem = TpcIslemPIslemler;
            TpcIslemPIslemler.TabIndex = 0;

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            LogEkle("test Başlatıldı");
        }

        private void btnVerileriGoruntule_Click(object sender, EventArgs e)
        {
            LogEkle("Veriler Görüntülendi.");
            FrmVeriler YeniVeriler = new FrmVeriler();
            YeniVeriler.Text = "Dumy Veriler";
            YeniVeriler.WindowState = FormWindowState.Normal;
            YeniVeriler.StartPosition = FormStartPosition.CenterParent;
            YeniVeriler.MaximizeBox = false;
            YeniVeriler.MinimizeBox = false;
            YeniVeriler.Userlistesi = TestBilgileri.UserListesi;
            DialogResult Sonuc = YeniVeriler.ShowDialog();

        }

        private void btnLogEkranTemizle_Click(object sender, EventArgs e)
        {
            TxtPerformansLog.Text = "";
        }
        private void LogKayitDisk(string FileName)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName))
            {
                string Veri = string.Format("{0}\r\n{1}\r\n{2}{3}",
                    string.Format("{0} Log Kayıtları", this.Text),
                    "-----------------------------------------------------------------------------------------------------",
                    TxtPerformansLog.Text,
                    "-----------------------------------------------------------------------------------------------------"
                    );
                file.Write(Veri);
                file.Close();
            }
        }
        private void btnLogKayit_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog KayitEkran=new SaveFileDialog() {Title="Log Kayıt İşlemleri",Filter="Text Dosya|*.txt"})
            {
                if (KayitEkran.ShowDialog()==DialogResult.OK)
                {
                    LogKayitDisk(KayitEkran.FileName);
                }
            }
        }
    }
}
