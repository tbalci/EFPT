using RazorHosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSKTS.App.Ekranlar
{
    public enum KontrolDurum
    {
        Pasif=0,
        Calisiyor=1,
        Duraklatildi=3,
        Durduruldu=4
    }
    public partial class FrmWsBrowser : Form
    {

        public static FrmWsBrowser AktifWsBrowserForm = null;

        public bool LogKayitDurum { get; set; }

        public KontrolDurum Durum { get; set; }
        public GezginAyar GezginAyar { get; set; }
        private void btnVtSecimMssql_Click(object sender, EventArgs e)
        {
            SecimVeriTabaniTipiniEkranaYansit();
        }

        private void btnVtSecimMysql_Click(object sender, EventArgs e)
        {
            SecimVeriTabaniTipiniEkranaYansit();
        }

        private void btnVtSecimOracle_Click(object sender, EventArgs e)
        {
            SecimVeriTabaniTipiniEkranaYansit();
        }

        private void SecimVeriTabaniTipiniEkranaYansit()
        {
           

        }
        public FrmWsBrowser()
        {
            InitializeComponent();
            GezginAyar = new GezginAyar();
            Durum = KontrolDurum.Pasif;
            AktifWsBrowserForm = this;
            LogKayitDurum = true;
        }



        private void btnOlustur_Click(object sender, EventArgs e)
        {
            FrmMain.AktifMainForm.DurumBilgisiVer("Veriler Oluşturuldu.");
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
        }

        

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            LogEkle("test Başlatıldı");
        }
        private void SomeMethod()
        {
            for (int Don = 0; Don < 1000; Don++)
            {
                Thread.Sleep(1);
            }
        }
        private void Tester_IslemTamam()
        {
        }

        delegate void LogmetinDegistirDelegate(string text);

        private void LogMetinGuncelle(string text)
        {
            //bu metod thread2 içinden erişildi! 

            if (this.TxtPerformansLog.InvokeRequired)
            {
                LogmetinDegistirDelegate d = new LogmetinDegistirDelegate(LogMetinGuncelle); //bu metodu tekrar çağıracaz delegate diğer thread in(ana thread) bellekteki 
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.TxtPerformansLog.Text+= text;
            }
        }

        public void LogEkle(string Mesaj)
        {
            string MesajTxt = string.Format("{0} : {1}{2}", DateTime.Now.ToString(), Mesaj, Environment.NewLine);
            LogMetinGuncelle(MesajTxt);
        }
        private void Islem()
        {
            for (int Don = 0; Don < 10000; Don++)
            {
                Application.DoEvents();
                LogEkle("test Başlatıldı" + Don.ToString());
            }
        }

        private void FrmTestKayitEkleme_Load(object sender, EventArgs e)
        {
            AracCubugu.ImageScalingSize = new Size(32, 32);
            TpcIslem.SelectedItem = TpcIslemPIslemler;
            TpcIslemPIslemler.TabIndex = 0;
            SecimVeriTabaniTipiniEkranaYansit();
        }
        private void btnLogEkranTemizle_Click(object sender, EventArgs e)
        {
            TxtPerformansLog.Text = "";
        }
        private void btnLogKayit_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog KayitEkran = new SaveFileDialog() { Title = "Log Kayıt İşlemleri", Filter = "Text Dosya|*.txt" })
            {
                if (KayitEkran.ShowDialog() == DialogResult.OK)
                {
                    LogKayitDisk(KayitEkran.FileName);
                }
            }
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


        private void btnSonucGoster_Click(object sender, EventArgs e)
        {

        }
        private void btnDurdur_Click(object sender, EventArgs e)
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
            Tp.CanClose = true;
            Tp.Image = Form.Icon.ToBitmap();
            fTpBrowserListesi.AddTab(Tp, true);
        }


        private void TlStrpBtnYeni_Click(object sender, EventArgs e)
        {
            using (Ekranlar.FrmShrGezgin FrmShrGezgin = new FrmShrGezgin())
            {
                FrmShrGezgin.WindowState = FormWindowState.Normal;
                FrmShrGezgin.StartPosition = FormStartPosition.CenterScreen;
                FrmShrGezgin.MaximizeBox = false;
                FrmShrGezgin.MinimizeBox = false;
                if (FrmShrGezgin.ShowDialog()==DialogResult.OK)
                {
                    GezginAyar = FrmShrGezgin.GezginAyar;
                    Random Rnd = new Random();
                    for (int i = GezginAyar.Adet;  i>0 ; i--)
                    {
                        Ekranlar.FrmBrowser FrmBrowser = new FrmBrowser();
                        FrmBrowser.Text = string.Format("{0} | {1}", (i - 1)+1, GezginAyar.Ad);
                        FrmBrowser.Url = GezginAyar.Url;
                        FrmBrowser.SaniyeIlk = GezginAyar.SaniyeIlk;
                        FrmBrowser.SaniyeSon = GezginAyar.SaniyeSon;
                        FrmBrowser.Saniye = 0;
                        FrmBrowser.SiteGezinmeDurumu = GezginAyar.SiteGezinmeDurumu;
                        FrmBrowser.CerezDurumu = GezginAyar.CerezDurumu;
                        FormEkle(FrmBrowser);
                        Thread.Sleep(100);
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //foreach (var item in fTpBrowserListesi.Items)
            //{
            //    FarsiLibrary.Win.FATabStripItem Tp = (FarsiLibrary.Win.FATabStripItem)item;
            //    if (Tp.Controls.Count>0)
            //    {
            //        Ekranlar.FrmBrowser Frm = (Ekranlar.FrmBrowser)Tp.Controls[0];
            //        if (Frm!=null)
            //        {
            //            Frm.KontrolEt();
            //            Application.DoEvents();
            //        }
            //    }
            //}
        }

        private void tlStrpAktifPasif_Click(object sender, EventArgs e)
        {
            LogKayitDurum = !LogKayitDurum;
            if (this.LogKayitDurum)
            {
                tlStrpAktifPasif.Text = "Log Pasif Yap";
            }
            else
            {
                tlStrpAktifPasif.Text = "Log Aktif Yap";
            }
        }
    }
}
