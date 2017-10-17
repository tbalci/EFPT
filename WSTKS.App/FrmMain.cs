using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Net;

namespace WSKTS.App
{
    public partial class FrmMain : Form
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        static bool settingsReturn, refreshReturn;

        public List<string> ProxyListesi = new List<string>();

        public int ProxySaniye { get; set; }
        Random Rnd = new Random();

        public DateTime ProxyDegismeZaman { get; set; }

        private void ProxySaniyeHesapla(int IlkSaniye=45,int SonSaniye=90)
        {
           ProxySaniye = Rnd.Next(IlkSaniye, SonSaniye) * 1000;
        }


        public void SetProxy(string ProxyServer, bool Enable = true)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            if (Enable)
            {
                registry.SetValue("ProxyEnable",1);
            }
            else
            {
                registry.SetValue("ProxyEnable", 0);
            }
            registry.SetValue("ProxyServer", ProxyServer);
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public void RndProxDegistir()
        {
            //if (DateTime.Now>ProxyDegismeZaman)
            //{
            //    Random rnd = new Random();
            //    int rndSayi = 0;
            //    //bool Sonuc = false;

            //    //while (!Sonuc)
            //    //{

            //    //    Sonuc = TestProxy(Adres);
            //    //    if (Sonuc)
            //    //    {
            //    //        break;
            //    //    }
            //    //    Application.DoEvents();
            //    //}
            //    string Adres = "";
            //    rndSayi = rnd.Next(0, ProxyListesi.Count - 1);
            //    Adres = ProxyListesi[rndSayi].ToString();
            //    ProxySaniyeHesapla();
            //    ProxyDegismeZaman = DateTime.Now.AddMilliseconds(ProxySaniye);
            //    SetProxy(Adres);

            //}

            Random rnd = new Random();
            int rndSayi = 0;
            string Adres = "";
            rndSayi = rnd.Next(0, ProxyListesi.Count - 1);
            Adres = ProxyListesi[rndSayi].ToString();
            SetProxy(Adres);

        }

        public bool TestProxy(string Adres)
        {
            string Url =Adres;
            int Port = 80;
            List<string> Prs = Adres.Split(':').ToList();
            if (Prs.Count==2)
            {
                Url = Prs[0];
                Port = Convert.ToInt32(Prs[1].ToString());
            }
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://google.com");
            request.Proxy = new WebProxy(Url, Port);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36";
            request.Timeout = 2000;
            try
            {
                WebResponse response = request.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }



        public string AlinanSonuclar { get; set; }

        public static FrmMain AktifMainForm=null;

        public void DurumBilgisiVer(string Mesaj)
        {
            TlStrpDurum.Text = string.Format("{0}:{1}",DateTime.Now.ToString(), Mesaj);
        }
        public FrmMain()
        {
            InitializeComponent();
            AktifMainForm = this;
            ProxySaniye = 0;
            string ProxyFileAdres = Application.StartupPath + "\\Proxy.txt";
            System.IO.FileInfo ProxyFileBilgi = new System.IO.FileInfo(ProxyFileAdres);
            if (ProxyFileBilgi.Exists)
            {
                var ProxyFile = System.IO.File.ReadAllLines(ProxyFileBilgi.FullName);
                ProxyListesi = new List<string>(ProxyFile);
            }

            //if (ProxySaniye==0)
            //{
            //    ProxySaniyeHesapla();
            //    ProxyDegismeZaman = DateTime.Now.AddMilliseconds(ProxySaniye);
            //}
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DurumBilgisiVer("Sistem Açıldı.");
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                TlStrpVersiyon.Text = string.Format("Ver.{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
            else {
                TlStrpVersiyon.Text = string.Format("Ver.{0}", "Developer");
            }
            SetProxy("",false);
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
            Tp.CanClose = true;
            Tp.Image = Form.Icon.ToBitmap();
            TpcIslem.AddTab(Tp,true);
            DurumBilgisiVer(string.Format("{0} Ekranı Oluşturuldu",Form.Text));
        }

        private void TlstrpBtnYeniPerformansTest_Click(object sender, EventArgs e)
        {
            KayitEklemeTestFormuAc();
        }

        private void KayitEklemeTestFormuAc()
        {
            Ekranlar.FrmWsBrowser FrmWsBrowser = new Ekranlar.FrmWsBrowser();
            FrmWsBrowser.Text = "Yeni Web Site Gezgini";
            FrmMain.AktifMainForm.FormEkle(FrmWsBrowser);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnKayitEklemeTestFormuAc_Click(object sender, EventArgs e)
        {
            KayitEklemeTestFormuAc();
        }

        private void btnWebSiteGezginOlustur_Click(object sender, EventArgs e)
        {
            Ekranlar.FrmWsBrowser FrmWsBrowser = new Ekranlar.FrmWsBrowser();
            FrmWsBrowser.Text = "Yeni Web Site Gezgini";
            FrmMain.AktifMainForm.FormEkle(FrmWsBrowser);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
            Application.ExitThread();
        }

        
    }
}
