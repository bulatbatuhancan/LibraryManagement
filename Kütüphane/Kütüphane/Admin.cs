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
using DevExpress.XtraGrid.Views.Grid;

namespace Kütüphane
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource3.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource5.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource6.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource4.FillAsync();
        }


        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string DByolu = "Server=BULAT;Database=Kütüphane;Uid=sa;Password=12;";

            SqlConnection con = new SqlConnection(DByolu);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string Reg = "insert into Kitap_Bilgi(KitapAdı," +
                "SayfaSayısı" +
                ",Kategori," +
                "Yazarı," +
                "YılBilgisi," +
                "Adet) " +
                "values (@KitapAdı," +
                "@SayfaSayısı," +
                "@Kategori," +
                "@Yazarı," +
                "@YılBilgisi," +
                "@Adet)";

            SqlCommand cmd = new SqlCommand(Reg, con);

            cmd.Parameters.AddWithValue("@KitapAdı", txtKitap.Text);
            cmd.Parameters.AddWithValue("@SayfaSayısı", txtSayfa.Text);
            cmd.Parameters.AddWithValue("@Kategori", txtKategori.Text);
            cmd.Parameters.AddWithValue("@Yazarı", txtYazar.Text);
            cmd.Parameters.AddWithValue("@YılBilgisi", txtYıl.Text);
            cmd.Parameters.AddWithValue("@Adet", txtAdet.Text);


            cmd.ExecuteNonQuery();
            con.Close();

            sqlDataSource1.FillAsync();

        }


        private void btnOnay_click(object sender, EventArgs e)
        {


            string DByolu = "Server=BULAT;Database=Kütüphane;Uid=sa;Password=12;";

            SqlConnection con = new SqlConnection(DByolu);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string Reg = "insert into Öğretmenler(İsim," +
                "Soyisim" +
                ",ÖğretmenNo," +
                "Mail," +
                "Şifre) " +
                "values (@İsim," +
                "@Soyisim," +
                "@ÖğretmenNo," +
                "@Mail," +
                "@Şifre)";

            SqlCommand cmd = new SqlCommand(Reg, con);

            cmd.Parameters.AddWithValue("@İsim", txtİsim.Text.Trim());
            cmd.Parameters.AddWithValue("@Soyisim", txtSoy.Text.Trim());
            cmd.Parameters.AddWithValue("@ÖğretmenNo", txtOgrNo.Text.Trim());
            cmd.Parameters.AddWithValue("@Mail", txtMail.Text.Trim());
            cmd.Parameters.AddWithValue("@Şifre", txtŞifre.Text.Trim());


            cmd.ExecuteNonQuery();
            con.Close();


            string komut = "   update Giriş_Paneli set Öğretmen ='" + 0 + "'where OgrNo ='" + txtOgrNo.Text + "'     ";

            con.Open();

            SqlCommand cd = new SqlCommand(komut, con);

            cd.ExecuteNonQuery();


            con.Close();


            sqlDataSource5.FillAsync();


        }


        private void gridView3_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            int Miktar = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Adet"));
            if (Miktar == 0)
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.BackColor2 = Color.Yellow;
                e.Appearance.ForeColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.BackColor2 = Color.GreenYellow;
                e.Appearance.ForeColor = Color.White;
            }
        }


        private void gridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            int Miktar = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Adet"));
            if (Miktar == 0)
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.BackColor2 = Color.Yellow;
                e.Appearance.ForeColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.BackColor2 = Color.GreenYellow;
                e.Appearance.ForeColor = Color.White;
            }
        }


        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                txtİsim.Text = dr[0].ToString();
                txtSoy.Text = dr[1].ToString();
                txtOgrNo.Text = dr[2].ToString();
                txtMail.Text = dr[3].ToString();
                txtŞifre.Text = dr[4].ToString();
                txtOnay.Text = dr[5].ToString();
            }
        }


        private void Düzenle(int newValue,string column)
        {
            string DByolu = "Server=BULAT;Database=Kütüphane;Uid=sa;Password=12;";

            SqlConnection con = new SqlConnection(DByolu);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string komut = "   update Kitap_Ayarları set "+column+"='" + newValue + "'where ID ='" + 1 + "'     ";


            SqlCommand cd = new SqlCommand(komut, con);

            cd.ExecuteNonQuery();


            con.Close();
        }


        private void BtnDüzenleÖgrKAS_Click_1(object sender, EventArgs e)
        {
            Düzenle(Convert.ToInt32(txtÖgrKAS.Text.Trim()), "ÖğrenciKitapAlmaSınırı");

        }


        private void btnÖğrKİS_Click(object sender, EventArgs e)
        {
            Düzenle(Convert.ToInt32(txtÖgrKİS.Text.Trim()), "ÖğrenciİadeSüresi");

        }


        private void btnÖKAS_Click(object sender, EventArgs e)
        {
            Düzenle(Convert.ToInt32(txtÖKAS.Text.Trim()), "ÖğretmenKitapAlmaSınırı");

        }


        private void btnÖKİS_Click(object sender, EventArgs e)
        {
            Düzenle(Convert.ToInt32(txtÖKİS.Text.Trim()), "ÖğretmenİadeSüresi");

        }


        private void btnBildirimGönder_Click(object sender, EventArgs e)
        {
            string DByolu = "Server=BULAT;Database=Kütüphane;Uid=sa;Password=12;";

            SqlConnection con = new SqlConnection(DByolu);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string Reg = "insert into Bildirimler(ÖğrNo," +
                "Mesaj" +
                ",Kitapİsmi) " +
                "values (@ÖğrNo," +
                "@Mesaj," +
                "@Kitapİsmi)";

            SqlCommand cmd = new SqlCommand(Reg, con);

            cmd.Parameters.AddWithValue("@ÖğrNo", txtÖğrNo.Text.Trim());
            cmd.Parameters.AddWithValue("@Mesaj", lblMesaj.Text.Trim());
            cmd.Parameters.AddWithValue("@Kitapİsmi", txtKitapİsim.Text.Trim());



            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}



