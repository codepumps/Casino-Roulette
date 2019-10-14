using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gorsel_Bahis_Uygulamasi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=LAPTOP-NQ4NLGI5\\SQLEXPRESS;Initial Catalog=BahisUygulama;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("Select * From User_Entrance where Mail=@mail and Password=@passw",baglanti);
            komut.Parameters.AddWithValue("@mail", mskGirisMail.Text);
            komut.Parameters.AddWithValue("@passw", mskGirisPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Bahis bahisform=new Bahis();
                bahisform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı mail veya hatalı şifre girdiniz.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            baglanti.Close();

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kaydolma frmkaydol=new Kaydolma();
            frmkaydol.Show();
        }
    }
}
