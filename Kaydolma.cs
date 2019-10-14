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
    public partial class Kaydolma : Form
    {
        public Kaydolma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NQ4NLGI5\\SQLEXPRESS;Initial Catalog=BahisUygulama;Integrated Security=True");
       
        private void mskKaydol2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into User_Entrance (Adi,Soyadi,Numara,Mail,Password) values (@adi,@soyad,@num,@mail,@pass)",baglanti);
            komut.Parameters.AddWithValue("@adi", mskAd.Text);
            komut.Parameters.AddWithValue("@soyad", mskSoyad.Text);
            komut.Parameters.AddWithValue("@num", mskNumara.Text);
            komut.Parameters.AddWithValue("@mail", mskMail.Text);
            komut.Parameters.AddWithValue("@pass", mskPassword.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Başarılı", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
