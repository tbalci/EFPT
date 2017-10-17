using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSKTS.App.Ekranlar
{
    public partial class FrmBrowser : Form
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);


        public List<string> UrlListesi { get; set; }

        public bool Durum { get; set; }
        public string Url { get; set; }
        public int SaniyeIlk { get; set; }
        public int SaniyeSon { get; set; }

        public bool SiteGezinmeDurumu { get; set; }
        public bool CerezDurumu { get; set; }

        public DateTime Zaman { get; set; }

        public int Saniye { get; set; }
        Random Rnd = new Random();

        private void SaniyeHesapla()
        {
            Saniye = Rnd.Next(SaniyeIlk, SaniyeSon)*1000;
        }
        public FrmBrowser()
        {
            InitializeComponent();
            UrlListesi = new List<string>();
            SaniyeHesapla();
        }

        private void AltUrlListesiHazirla()
        {
            UrlListesi = new List<string>();
            UrlListesi.Clear();
            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = hw.Load(Url);
            List<string> ExculudeList = new List<string>();
            ExculudeList.Add("#");
            ExculudeList.Add(this.Url);
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                HtmlAttribute Lnk = link.Attributes["href"];
                if (!ExculudeList.Contains(Lnk.Value))
                {
                    if (!Lnk.Value.ToLower().StartsWith("http://"))
                    {
                        if (!Lnk.Value.ToLower().StartsWith("#"))
                        {
                            string LnkTxt = this.Url + Lnk.Value;
                            if (!UrlListesi.Contains(LnkTxt))
                            {
                                UrlListesi.Add(LnkTxt);
                            }
                        }
                    }
                }
            }
            FrmWsBrowser.AktifWsBrowserForm.LogEkle(string.Format("{0} : {1}", this.Text, "Site Gezinti Linkleri Oluşturuldu"));
        }

        

        private void FrmBrowser_Load(object sender, EventArgs e)
        {
            Durum = true;
            if (SiteGezinmeDurumu)
            {
                AltUrlListesiHazirla();
            }
           
            //Browser.Navigate(Url);
            Zaman = DateTime.Now.AddMilliseconds(Saniye);
            var th = new Thread(() =>
            {

                while (true)
                {
                    if (DateTime.Now > Zaman)
                    {
                        FrmMain.AktifMainForm.RndProxDegistir();

                        if (UrlListesi.Count>0)
                        {
                            if (Browser.Url == null)
                            {
                                
                            }
                            else {
                                if (CerezDurumu)
                                {
                                    Browser.Navigate("javascript:void((function(){var a,b,c,e,f;f=0;a=document.cookie.split('; ');for(e=0;e<a.length&&a[e];e++){f++;for(b='.'+location.host;b;b=b.replace(/^(?:%5C.|[^%5C.]+)/,'')){for(c=location.pathname;c;c=c.replace(/.$/,'')){document.cookie=(a[e]+'; domain='+b+'; path='+c+'; expires='+new Date((new Date()).getTime()-1e11).toGMTString());}}}})())");
                                }
                                

                            }
                            int Sayi = Rnd.Next(0, UrlListesi.Count - 1);
                            string AdresTxt = UrlListesi[Sayi];
                            Browser.Navigate(AdresTxt);
                            FrmWsBrowser.AktifWsBrowserForm.LogEkle(string.Format("{0} : {1}", this.Text, AdresTxt +" Görüntülendi"));
                        }
                        else
                        {
                            if (Browser.Url == null)
                            {
                                Browser.Navigate(Url);
                            }
                            else
                            {
                                if (CerezDurumu)
                                {
                                    Browser.Navigate("javascript:void((function(){var a,b,c,e,f;f=0;a=document.cookie.split('; ');for(e=0;e<a.length&&a[e];e++){f++;for(b='.'+location.host;b;b=b.replace(/^(?:%5C.|[^%5C.]+)/,'')){for(c=location.pathname;c;c=c.replace(/.$/,'')){document.cookie=(a[e]+'; domain='+b+'; path='+c+'; expires='+new Date((new Date()).getTime()-1e11).toGMTString());}}}})())");
                                }
                                Browser.Refresh();
                            }
                            FrmWsBrowser.AktifWsBrowserForm.LogEkle(string.Format("{0} : {1}", this.Text,
                             Browser.Url + " Yenilendi"));
                        }
                        SaniyeHesapla();
                        Zaman = DateTime.Now.AddMilliseconds(Saniye);
                    }
                    Application.DoEvents();
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }
        private void Browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
               
        }
        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (Browser.Document.Body!=null)
            {
                int x = 0;
                int y = 0;
                x = Rnd.Next(0, Browser.Document.Body.ScrollRectangle.Width - 1);
                y = Rnd.Next(0, Browser.Document.Body.ScrollRectangle.Height - 1);
                Browser.Document.Window.ScrollTo(x, y);
            }
            
        }
    }
}
