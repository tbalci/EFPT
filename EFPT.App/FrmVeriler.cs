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
        public List<User> UserListesi { get; set; }

        public static FrmVeriler ActiveForm
        {
            get
            {
                return _ActiveForm;
            }
        }

        private static FrmVeriler _ActiveForm = null;

        public FrmVeriler()
        {
            InitializeComponent();
            this.Icon = FrmMain.AktifMainForm.Icon;
        }
        private void FrmVeriler_Load(object sender, EventArgs e)
        {
            this.Text = "Test Verileri";
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (UserListesi!=null)
            {
                var result = UserListesi
                           .Select((user, index) => new   // project in the index
            {
                               Sıra = index + 1,
                               Adı_Soyadı = string.Format("{0} {1}", user.Ad, user.Soyad),
                               Mail = user.Mail,
                               Tarih = user.Tarih
                           });
                GrdVeri.DataSource = result.ToList();
            }
           
        }
    }
}
