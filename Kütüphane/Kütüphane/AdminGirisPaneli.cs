using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class AdminGirişPaneli : Form
    {
        public AdminGirişPaneli()
        {
            InitializeComponent();
        }


        private void btnGiriş_Click(object sender, EventArgs e)
        {
            string query = "select * from Admins where AdminNo=@AdminNo AND Şifre=@Şifre";

            string DByolu = "Server=BULAT;Database=Kütüphane;Uid=sa;Password=12;";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@AdminNo", txtAdminNo.Text);
            cmd.Parameters.AddWithValue("@Şifre", txtAdminŞif.Text);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız");

                Admin frm = new Admin();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola Hatalı");
            }
            con.Close();
        }

    }
}
