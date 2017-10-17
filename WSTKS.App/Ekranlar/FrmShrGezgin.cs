using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSKTS.App.Ekranlar
{
    
    public partial class FrmShrGezgin : Form
    {
        public GezginAyar GezginAyar { get; set; }
        public FrmShrGezgin()
        {
            InitializeComponent();
            GezginAyar = new GezginAyar();
        }

        private void FrmShrGezgin_Load(object sender, EventArgs e)
        {
            ChkSiteGezinmeDurumu.Checked = this.GezginAyar.SiteGezinmeDurumu;
            NAdet.Value = this.GezginAyar.Adet;
            NSaniyeIlk.Value = this.GezginAyar.SaniyeIlk;
            NSaniyeSon.Value = this.GezginAyar.SaniyeSon;
            NProxySaniyeIlk.Value = this.GezginAyar.ProxySaniyeIlk;
            NProxySaniyeSon.Value = this.GezginAyar.ProxySaniyeSon;
            txtUrl.Text =this.GezginAyar.Url;
            ChkCerezDurumu.Checked = this.GezginAyar.CerezDurumu;
            txtAd.Text = this.GezginAyar.Ad;
        }

        private void btnIslemiBaslat_Click(object sender, EventArgs e)
        {
            this.GezginAyar.Ad = txtAd.Text.Trim();
            this.GezginAyar.Adet = (int)NAdet.Value;
            this.GezginAyar.SaniyeIlk = (int)NSaniyeIlk.Value;
            this.GezginAyar.SaniyeSon = (int)NSaniyeSon.Value;
            this.GezginAyar.ProxySaniyeIlk = (int)NProxySaniyeIlk.Value;
            this.GezginAyar.ProxySaniyeSon = (int)NProxySaniyeSon.Value;
            this.GezginAyar.Url = txtUrl.Text.Trim();
            this.GezginAyar.CerezDurumu = ChkCerezDurumu.Checked;
            this.GezginAyar.SiteGezinmeDurumu = ChkSiteGezinmeDurumu.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmShrGezgin_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            if (!txtUrl.Text.Trim().ToLower().StartsWith("http://"))
            {
                txtUrl.Text = "http://" + txtUrl.Text.Trim();
            }
        }
    }
}
