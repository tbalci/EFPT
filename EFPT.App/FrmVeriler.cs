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
        }

        private void FrmVeriler_Load(object sender, EventArgs e)
        {
            GrdVeri.DataSource = Userlistesi;
        }
    }
}
