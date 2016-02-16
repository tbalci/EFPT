using EFPT.Lib;
using EFPT.Model;
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
    public partial class FrmSihirbaz : Form
    {
        public List<User> Userlistesi { get; set; }
        private VeriTabaniTipi _VeriTabaniTipi = VeriTabaniTipi.Mssql;

        public VeriTabaniTipi VeriTabaniTipi
        {
            get
            {
                return _VeriTabaniTipi;
            }

            set
            {
                _VeriTabaniTipi = value;
                btnVtSecimMssql.Enabled = true;
                btnVtSecimMysql.Enabled = true;
                btnVtSecimOracle.Enabled = true;
                switch (value)
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
        }

        public FrmSihirbaz()
        {
            InitializeComponent();
            this.Icon = FrmMain.AktifMainForm.Icon;
            this.Userlistesi = new List<User>();
        }

        private void FrmSihirbaz_Load(object sender, EventArgs e)
        {
            this.VeriTabaniTipi = VeriTabaniTipi.Mssql;
            FrmMain.AktifMainForm.DurumBilgisiVer("Yeni Performans Test Sihirbazı Başlatıldı");
        }

        private void FrmSihirbaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.AktifMainForm.DurumBilgisiVer("Yeni Performans Test Sihirbazı Kapatıldı");
        }

        private void btnVtSecimMssql_Click(object sender, EventArgs e)
        {
            this.VeriTabaniTipi = VeriTabaniTipi.Mssql;
        }

        private void btnVtSecimMysql_Click(object sender, EventArgs e)
        {
            this.VeriTabaniTipi = VeriTabaniTipi.Mysql;
        }

        private void btnVtSecimOracle_Click(object sender, EventArgs e)
        {
            this.VeriTabaniTipi = VeriTabaniTipi.Oracle;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            this.Userlistesi = new List<User>();
            int KayitSayisi = (int)NUDKayitSayisi.Value;
            for (int i = 0; i < KayitSayisi; i++)
            {
                User Usr = new User()
                {
                    Ad = string.Format("Ad {0}", i.ToString()),
                    Soyad = string.Format("Soyad {0}", i.ToString()),
                    Mail = string.Format("mail{0}@mail.com", i.ToString())
                };
                Userlistesi.Add(Usr);
            }
            FrmMain.AktifMainForm.DurumBilgisiVer("Veriler Oluşturuldu.");
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            FrmVeriler YeniVeriler = new FrmVeriler();
            YeniVeriler.Text = "Dumy Veriler";
            YeniVeriler.WindowState = FormWindowState.Normal;
            YeniVeriler.StartPosition = FormStartPosition.CenterParent;
            YeniVeriler.MaximizeBox = false;
            YeniVeriler.MinimizeBox = false;
            YeniVeriler.Userlistesi = this.Userlistesi;

            DialogResult Sonuc = YeniVeriler.ShowDialog();

        }

        private void btnTestiBaslat_Click(object sender, EventArgs e)
        {
            if (TxtTestAd.Text.Trim() != "")
            {
                if (Userlistesi.Count()>0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    TlStrpDurum.Text = "Veriler Oluşturulmamış. Lütfen Verileri Oluşturunuz..!";
                }
            }
            else
            {
                TlStrpDurum.Text = "Test Adı Boş Olamaz.! Lütfen Test adı Giriniz.";
            }
        }
    }
}
