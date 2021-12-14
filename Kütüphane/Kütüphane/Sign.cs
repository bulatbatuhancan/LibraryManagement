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
    public partial class Sign : Form
    {

        public Sign()
        {
            InitializeComponent();
        }


        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
        }


        private string rütbeBul()
        {
            string DByolu = "Server=BULAT;Database=Kütüphane;Uid=sa;Password=12;";
            string query = "Select *from Öğretmenler";
            SqlConnection con = new SqlConnection(DByolu);
            SqlCommand command = new SqlCommand(query,con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (GirOkulNo.Text.Trim()==reader["ÖğretmenNo"].ToString().Trim())
                {
                    reader.Close();
                    con.Close();
                    return "Öğretmen";
                }
            }
            reader.Close();
            con.Close();
            return "Öğrenci";
        }


        private void btnGiriş_Click(object sender, EventArgs e)
        {
            string SifrelenmişMetin = sha_256(GirŞifre.ToString());



            string query = "select * from Giriş_Paneli where OgrNo=@OgrNo AND Sifre=@Sifre";

            string DByolu = "Server=BULAT;Database=Kütüphane;Uid=sa;Password=12;";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@OgrNo", GirOkulNo.Text);
            cmd.Parameters.AddWithValue("@Sifre", SifrelenmişMetin);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız");
                string kullanıcıRütbe = rütbeBul();
                GirişPaneli frm = new GirişPaneli();
                frm.OkulNumarası = Convert.ToInt32(GirOkulNo.Text.Trim());
                frm.rütbe = kullanıcıRütbe;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola Hatalı");
            }
            con.Close();
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
