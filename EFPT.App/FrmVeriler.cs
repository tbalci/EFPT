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
    public partial class FrmVeriler : Form
    {
        public List<User> Userlistesi { get; set; }

        public FrmVeriler()
        {
            InitializeComponent();
            this.Icon = FrmMain.AktifMainForm.Icon;
        }

        private void FrmVeriler_Load(object sender, EventArgs e)
        {
            var result = Userlistesi
            .Select((user, index) => new   // project in the index
            {
                Sıra = index+1,
                Adı_Soyadı = string.Format("{0} {1}",user.Ad,user.Soyad),
                Mail = user.Mail,
                Tarih = user.Tarih
            });
            GrdVeri.DataSource = result.ToList();
        }
    }
}
