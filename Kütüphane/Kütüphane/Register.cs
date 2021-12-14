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
using System.Security.Cryptography;

namespace Kütüphane
{
    public partial class Register : Form
    {


        public Register()
        {
            InitializeComponent();
        }


        public static string Şifre;


        private void btnKayıt_Click(object sender, EventArgs e)
        {
            int Öğretmen = 0;

            string SifrelenmişMetin = sha_256(Sifre.ToString());


            if (cbÖğretmen.Checked == true)
            {
                Öğretmen = 1;
            }

            string DByolu = "data source = BULAT ; database = Kütüphane ; Integrated Security = SSPI";


            SqlConnection con = new SqlConnection(DByolu);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string Reg = "insert into Giriş_Paneli(İsim," +
                   "Soyisim," +
                   "OgrNo," +
                   "Mail," +
                   "Sifre," +
                   "Öğretmen)" +
                   "values (@İsim," +
                    "@Soyisim," +
                    "@OgrNo," +
                    "@Mail," +
                    "@Sifre," +
                    "@Öğretmen)";

            SqlCommand cmd = new SqlCommand(Reg, con);


            cmd.Parameters.AddWithValue("@İsim", İsim.Text);
            cmd.Parameters.AddWithValue("@Soyisim", Soyisim.Text);
            cmd.Parameters.AddWithValue("@OgrNo", OgrNo.Text);
            cmd.Parameters.AddWithValue("@Mail", Mail.Text);
            cmd.Parameters.AddWithValue("@Sifre", SifrelenmişMetin.ToString());
            cmd.Parameters.AddWithValue("@Öğretmen", Öğretmen);


            cmd.ExecuteNonQuery();

            con.Close();

            if (İsim.Text != "" && Soyisim.Text != "" && OgrNo.Text != "" && Mail.Text != "" && Sifre.Text != "")
            {
                Sign frm = new Sign();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect registration", "REGISTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public static string sha_256(string değer)
        {
            SHA256 sha = SHA256.Create();
            byte[] değerBytes = Encoding.UTF8.GetBytes(değer);
            byte[] shaBytes = sha.ComputeHash(değerBytes);
            return HashToByte(shaBytes);
            
        }


        public static string HashToByte(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte item in hash)
            {
                result.Append(item.ToString("x2"));

            }

            return result.ToString();
        }


    }
}
