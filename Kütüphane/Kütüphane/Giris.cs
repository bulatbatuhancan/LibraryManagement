using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminGirişPaneli frm = new AdminGirişPaneli();
            frm.Show();
            this.Hide();
        }


        private void btnÖgr_Click(object sender, EventArgs e)
        {
            Sign frm = new Sign();
            frm.Show();
            this.Hide();
        }

    }
}
