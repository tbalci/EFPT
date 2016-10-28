using EFPT.Lib;
using EFPT.Model;
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

namespace EFPT.App.Testler
{
    public partial class FrmTestKayitEkleme : Form
    {

        private EFPT.Performans.Istemci tester = new EFPT.Performans.Istemci();
        public PeromasnTestBilgi TestBilgileri { get; set; }
        private EFPT.Data.IDatabaseEngine Istemci;


        private void btnVtSecimMssql_Click(object sender, EventArgs e)
        {
            this.TestBilgileri.VeriTabaniTipi = VeriTabaniTipi.Mssql;
            SecimVeriTabaniTipiniEkranaYansit();
        }

        private void btnVtSecimMysql_Click(object sender, EventArgs e)
        {
            this.TestBilgileri.VeriTabaniTipi = VeriTabaniTipi.Mysql;
            SecimVeriTabaniTipiniEkranaYansit();
        }

        private void btnVtSecimOracle_Click(object sender, EventArgs e)
        {
            this.TestBilgileri.VeriTabaniTipi = VeriTabaniTipi.Oracle;
            SecimVeriTabaniTipiniEkranaYansit();
        }

        private void SecimVeriTabaniTipiniEkranaYansit()
        {
            btnVtSecimMssql.Enabled = true;
            btnVtSecimMysql.Enabled = true;
            btnVtSecimOracle.Enabled = true;
            switch (this.TestBilgileri.VeriTabaniTipi)
            {
                case VeriTabaniTipi.Mssql:
                    btnVtSecimMssql.Enabled = false;
                    break;
                case VeriTabaniTipi.Mysql:
                    btnVtSecimMysql.Enabled = false;
                    break;
                case VeriTabaniTipi.Oracle:
                    btnVtSecimOracle.Enabled = false;
                    break;
                default:
                    break;
            }

        }
        public FrmTestKayitEkleme()
        {
            InitializeComponent();
        }



        private void btnOlustur_Click(object sender, EventArgs e)
        {

            this.TestBilgileri.UserListesi = new List<User>();
            int KayitSayisi = (int)NUDKayitSayisi.Value;
            for (int i = 0; i < KayitSayisi; i++)
            {
                User Usr = new User()
                {
                    Ad = string.Format("Ad {0}", i.ToString()),
                    Soyad = string.Format("Soyad {0}", i.ToString()),
                    Mail = string.Format("mail{0}@mail.com", i.ToString())
                };
                this.TestBilgileri.UserListesi.Add(Usr);
            }
            FrmMain.AktifMainForm.DurumBilgisiVer("Veriler Oluşturuldu.");
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            FrmVeriler YeniVeriler = new FrmVeriler();
            YeniVeriler.UserListesi = this.TestBilgileri.UserListesi;
            YeniVeriler.ShowDialog();
        }

        

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            LogEkle("test Başlatıldı");
            btnBaslat.Enabled = false;
            btnDurdur.Enabled = true;
            switch (this.TestBilgileri.VeriTabaniTipi)
            {
                case Lib.VeriTabaniTipi.Mssql:
                    {
                        Istemci = new EFPT.Mssql.Istemci();
                        break;
                    }
                case Lib.VeriTabaniTipi.Mysql:
                    Istemci = new EFPT.Mysql.Istemci();
                    break;
                case Lib.VeriTabaniTipi.Oracle:
                    break;
                default:
                    break;
            }
            tester = new EFPT.Performans.Istemci(() => Istemci.Ekle(this.TestBilgileri.UserListesi));
            tester.Ad = TxtTestAd.Text.Trim();
            tester.Aciklama = TxtTestAciklama.Text.Trim();
            tester.IslemTamam += Tester_IslemTamam;
            FrmMain.AktifMainForm.KomutGonder("Baslat");
            tester.MeasureExecTimeWithMetrics((int)NmrTekrarSayisi.Value);
            FrmMain.AktifMainForm.KomutGonder("Durdur");
            Thread.Sleep(1000);
            btnBaslat.Enabled = true;
            btnDurdur.Enabled = false;
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
        public void LogEkle(string Mesaj)
        {
            TxtPerformansLog.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString(), Mesaj, Environment.NewLine);
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
            this.TestBilgileri = new PeromasnTestBilgi();
            AracCubugu.ImageScalingSize = new Size(32, 32);
            TpcIslem.SelectedItem = TpcIslemPIslemler;
            TpcIslemPIslemler.TabIndex = 0;
            this.TestBilgileri.VeriTabaniTipi = VeriTabaniTipi.Mssql;
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

            tester.SonucListesi = FrmMain.AktifMainForm.AlinanSonuclar.FromJson<List<EFPT.Performans.PerformansInfo>>();
            FrmRaporTestKayitEkleme YeniRapor = new FrmRaporTestKayitEkleme();
            YeniRapor.Context.Ad = tester.Ad;
            YeniRapor.Context.Aciklama = tester.Aciklama;
            YeniRapor.Context.SonucListesi = tester.SonucListesi;
            YeniRapor.Context.GrafikData = tester.SonucListesi.ToJson();// FrmMain.AktifMainForm.AlinanSonuclar.Replace("\0","");
            YeniRapor.Text = string.Format("{0} Raporu", tester.Ad);
            FrmMain.AktifMainForm.FormEkle(YeniRapor);
        }
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            FrmMain.AktifMainForm.KomutGonder("Durdur");
            btnBaslat.Enabled = true;
            btnDurdur.Enabled = false;
        }
    }
}
