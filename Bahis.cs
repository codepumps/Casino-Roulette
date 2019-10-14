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
    public partial class Bahis : Form
    {
        public Bahis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NQ4NLGI5\\SQLEXPRESS;Initial Catalog=BahisUygulama;Integrated Security=True");

        Button[] sayi = new Button[50];
        private int kn = 1,bask=100;
        private int toplamKredi = 300;
        private int saniye=0;
        Random rastgele=new Random();
        private int rastgeleGelen;
        int oyunSayisi = 0;
        private int oddTutucu100 = 0,oddTutucu300=0,oddTutucu500=0;//Tutucular kazanılan oyunun hangi yerden kazanıldığını belirtme de görev alır.
        private int evenTutucu100 = 0, evenTutucu300 = 0, evenTutucu500 = 0;
        private int redTutucu100 = 0, redTutucu300 = 0, redTutucu500 = 0;
        private int blackTutucu100 = 0, blackTutucu300 = 0, blackTutucu500 = 0;
        private int seckTutucu100 = 0, secTutucu300 = 0, secTutucu500 = 0;
        private int karZarar = 0;

        private void btn100_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LblKredim.Text)<= 500)
            {
                toplamKredi += 100;
                LblKredim.Text = toplamKredi.ToString();
                listBoxKrediler.Items.Add("100 TL Kredi Aldınız.");
                karZarar = karZarar - 100;
                LblKarZarar.Text = karZarar.ToString();
            }
            else
            {
                MessageBox.Show("Paranız 500 TL' nin üstünde.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LblKredim.Text) <= 500)
            {
                toplamKredi += 200;
                LblKredim.Text = toplamKredi.ToString();
                listBoxKrediler.Items.Add("200 TL Kredi Aldınız.");
                karZarar = karZarar - 200;
                LblKarZarar.Text = karZarar.ToString();
            }
            else
            {
                MessageBox.Show("Paranız 500 TL' nin üstünde.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LblKredim.Text) <= 500)
            {
                toplamKredi += 500;
                LblKredim.Text = toplamKredi.ToString();
                listBoxKrediler.Items.Add("500 TL Kredi Aldınız.");
                karZarar = karZarar - 500;
                LblKarZarar.Text = karZarar.ToString();
            }
            else
            {
                MessageBox.Show("Paranız 500 TL' nin üstünde.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LblKredim.Text) <= 500)
            {
                toplamKredi += 1000;
                LblKredim.Text = toplamKredi.ToString();
                listBoxKrediler.Items.Add("1000 TL Kredi Aldınız.");
                karZarar = karZarar - 1000;
                LblKarZarar.Text = karZarar.ToString();
            }
            else
            {
                MessageBox.Show("Paranız 500 TL' nin üstünde.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = false;
            btnRed.Enabled = false;
            btnBlack.Enabled = false;
            btnSec.Enabled = false;
            btnOdd.Enabled = false;
            rastgeleGelen = rastgele.Next(1, 37);
            if (btnYatır100.Enabled == false)
            {
                if (toplamKredi >= 100)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır100);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır100.Enabled = true;
                    timerHesap.Stop();
                }
                //Kazanilan oyun
                blackTutucu100++;
            }
            else if (btnYatır300.Enabled == false)
            {
                if (toplamKredi >= 300)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır300);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır300.Enabled = true;
                    timerHesap.Stop();
                }

                blackTutucu300++;

            }
            else if (btnYatır500.Enabled == false)
            {
                if (toplamKredi >= 500)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır500);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır500.Enabled = true;
                    timerHesap.Stop();
                }
                blackTutucu500++;

            }
        }


        private void btnSec_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = false;
            btnRed.Enabled = false;
            btnBlack.Enabled = false;
            btnSec.Enabled = false;
            btnOdd.Enabled = false;
            rastgeleGelen = rastgele.Next(1, 37);
            if (btnYatır100.Enabled == false)
            {
                if (toplamKredi >= 100)
                {
                    if (Convert.ToInt32(mskTahmin.Text) >= 0 && Convert.ToInt32(mskTahmin.Text) <= 37)
                    {
                        timerHesap.Start();
                        krediHesaplama(btnYatır100);
                        oyunSayisi++;
                        LblOyunSayisi.Text = oyunSayisi.ToString();
                        if (oyunSayisi >= 10)
                        {
                            btnEven.Enabled = false;
                            btnRed.Enabled = false;
                            btnBlack.Enabled = false;
                            btnSec.Enabled = false;
                            btnOdd.Enabled = false;
                            MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            timerHesap.Stop();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tahmininiz 0 ile 36 arasında bir sayı olmalıdır.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnOdd.Enabled = true;
                        btnEven.Enabled = true;
                        btnRed.Enabled = true;
                        btnBlack.Enabled = true;
                        btnSec.Enabled = true;
                        btnYatır100.Enabled = true;
                        mskTahmin.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır100.Enabled = true;
                    timerHesap.Stop();
                    mskTahmin.Clear();
                }
                //Kazanilan oyun
                seckTutucu100++;
            }
            else if (btnYatır300.Enabled == false)
            {
                if (toplamKredi >= 300)
                {
                    if (Convert.ToInt32(mskTahmin.Text) >= 0 && Convert.ToInt32(mskTahmin.Text) <= 37)
                    {
                        timerHesap.Start();
                        krediHesaplama(btnYatır300);
                        oyunSayisi++;
                        LblOyunSayisi.Text = oyunSayisi.ToString();
                        if (oyunSayisi >= 10)
                        {
                            btnEven.Enabled = false;
                            btnRed.Enabled = false;
                            btnBlack.Enabled = false;
                            btnSec.Enabled = false;
                            btnOdd.Enabled = false;
                            MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            timerHesap.Stop();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tahmininiz 0 ile 36 arasında bir sayı olmalıdır.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnOdd.Enabled = true;
                        btnEven.Enabled = true;
                        btnRed.Enabled = true;
                        btnBlack.Enabled = true;
                        btnSec.Enabled = true;
                        btnYatır300.Enabled = true;
                        mskTahmin.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır300.Enabled = true;
                    timerHesap.Stop();
                    mskTahmin.Clear();
                }

                secTutucu300++;

            }
            else if (btnYatır500.Enabled == false)
            {
                if (toplamKredi >= 500)
                {
                    if (Convert.ToInt32(mskTahmin.Text) >= 0 && Convert.ToInt32(mskTahmin.Text) <= 37)
                    {
                        timerHesap.Start();
                        krediHesaplama(btnYatır500);
                        oyunSayisi++;
                        LblOyunSayisi.Text = oyunSayisi.ToString();
                        if (oyunSayisi >= 10)
                        {
                            btnEven.Enabled = false;
                            btnRed.Enabled = false;
                            btnBlack.Enabled = false;
                            btnSec.Enabled = false;
                            btnOdd.Enabled = false;
                            MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            timerHesap.Stop();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tahmininiz 0 ile 36 arasında bir sayı olmalıdır.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnOdd.Enabled = true;
                        btnEven.Enabled = true;
                        btnRed.Enabled = true;
                        btnBlack.Enabled = true;
                        btnSec.Enabled = true;
                        btnYatır500.Enabled = true;
                        mskTahmin.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır500.Enabled = true;
                    timerHesap.Stop();
                    mskTahmin.Clear();
                }
                secTutucu500++;

            }
        }

        void krediHesaplama(Button a)
        {
            if (a == btnYatır100)
            {
                btnYatır100.Enabled = false;
                btnYatır300.Enabled = false;
                btnYatır500.Enabled = false;
                toplamKredi = toplamKredi - 100;
                LblKredim.Text = toplamKredi.ToString();
                karZarar = karZarar - 100;
                LblKarZarar.Text = karZarar.ToString();
            }
            else if (a == btnYatır300)
            {
                btnYatır100.Enabled = false;
                btnYatır300.Enabled = false;
                btnYatır500.Enabled = false;
                toplamKredi = toplamKredi - 300;
                LblKredim.Text = toplamKredi.ToString();
                karZarar = karZarar - 300;
                LblKarZarar.Text = karZarar.ToString();

            }
            else if (a == btnYatır500)
            {
                btnYatır100.Enabled = false;
                btnYatır300.Enabled = false;
                btnYatır500.Enabled = false;
                toplamKredi = toplamKredi - 500;
                LblKredim.Text = toplamKredi.ToString();
                karZarar = karZarar - 500;
                LblKarZarar.Text = karZarar.ToString();
            }


        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = false;
            btnRed.Enabled = false;
            btnBlack.Enabled = false;
            btnSec.Enabled = false;
            btnOdd.Enabled = false;
            rastgeleGelen = rastgele.Next(1, 37);
            if (btnYatır100.Enabled==false)
            {
                if (toplamKredi >= 100)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır100);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi>=10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır100.Enabled = true;
                    timerHesap.Stop();
                }
                //Kazanilan oyun
                oddTutucu100++;
                

            }               
            else if (btnYatır300.Enabled == false)
            {
                if (toplamKredi >= 300)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır300);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır300.Enabled = true;
                    timerHesap.Stop();
                }
                oddTutucu300++;
                
            }
            else if (btnYatır500.Enabled == false)
            {
                if (toplamKredi >= 500)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır500);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır500.Enabled = true;
                    timerHesap.Stop();
                }
                oddTutucu500++;
                
            }
        }

        private void timerHesap_Tick(object sender, EventArgs e)
        {
            saniye++;
            for (int i = 1; i <= 37; i++)
            {
                    if (saniye == i)
                    {
                        sayi[i].BackColor = Color.Blue;
                        if (rastgeleGelen == i)
                        {
                            timerHesap.Stop();
                            MessageBox.Show("Kazanan sayi= " + sayi[rastgeleGelen].Text, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            if (oddTutucu100 != 0)
                            {
                                if (rastgeleGelen % 2 == 1 && rastgeleGelen != 37)
                                {
                                    toplamKredi = toplamKredi + 200;
                                    LblKredim.Text = toplamKredi.ToString();
                                    oddTutucu100 = 0;
                                    karZarar = karZarar + 200;
                                    LblKarZarar.Text = karZarar.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Sayi tek değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    oddTutucu100 = 0;
                                }
                            }
                            else if (oddTutucu300 != 0)
                            {
                                if (rastgeleGelen % 2 == 1 && rastgeleGelen != 37)
                                {
                                    toplamKredi = toplamKredi + 600;
                                    LblKredim.Text = toplamKredi.ToString();
                                    oddTutucu300 = 0;
                                    karZarar = karZarar + 600;
                                    LblKarZarar.Text = karZarar.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Sayi tek değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    oddTutucu300 = 0;
                                }
                            }
                            else if(oddTutucu500!=0)
                            {
                                if (rastgeleGelen % 2 == 1 && rastgeleGelen != 37)
                                {
                                    toplamKredi = toplamKredi + 1000;
                                    LblKredim.Text = toplamKredi.ToString();
                                    oddTutucu500 = 0;
                                    karZarar = karZarar + 1000;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Sayi tek değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    oddTutucu500 = 0;
                                }
                            }
                            else if (evenTutucu100 != 0)
                            {
                                if (rastgeleGelen % 2 == 0)
                                {
                                    toplamKredi = toplamKredi + 200;
                                    LblKredim.Text = toplamKredi.ToString();
                                    evenTutucu100 = 0;
                                    karZarar = karZarar + 200;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Sayi çift değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    evenTutucu100 = 0;
                                }
                            }
                            else if (evenTutucu300 != 0)
                            {
                                if (rastgeleGelen % 2==0)
                                {
                                    toplamKredi = toplamKredi + 600;
                                    LblKredim.Text = toplamKredi.ToString();
                                    evenTutucu300 = 0;
                                    karZarar = karZarar + 600;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Sayi çift değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    evenTutucu100 = 0;
                                }
                            }
                            else if (evenTutucu500 != 0)
                            {
                                if (rastgeleGelen % 2 == 0)
                                {
                                    toplamKredi = toplamKredi + 1000;
                                    LblKredim.Text = toplamKredi.ToString();
                                    evenTutucu500 = 0;
                                    karZarar = karZarar + 1000;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Sayi çift değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    evenTutucu500 = 0;
                                }
                            }
                            else if (redTutucu100 != 0)
                            {
                                if (rastgeleGelen % 2 == 0)
                                {
                                    toplamKredi = toplamKredi + 200;
                                    LblKredim.Text = toplamKredi.ToString();
                                    redTutucu100 = 0;
                                    karZarar = karZarar + 200;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Kutu kırmızı değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    redTutucu100 = 0;
                            }
                            }
                            else if (redTutucu300 != 0)
                            {
                                if (rastgeleGelen % 2 == 0)
                                {
                                    toplamKredi = toplamKredi + 600;
                                    LblKredim.Text = toplamKredi.ToString();
                                    redTutucu300 = 0;
                                    karZarar = karZarar + 600;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Kutu kırmızı değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    redTutucu300 = 0;
                                }
                            }
                            else if (redTutucu500 != 0)
                            {
                                if (rastgeleGelen % 2 == 0)
                                {
                                    toplamKredi = toplamKredi + 1000;
                                    LblKredim.Text = toplamKredi.ToString();
                                    redTutucu500 = 0;
                                    karZarar = karZarar + 1000;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Kutu kırmızı değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    redTutucu500 = 0;
                                }
                            }
                            else if (blackTutucu100 != 0)
                            {
                                if (rastgeleGelen % 2 == 1 && rastgeleGelen!=37)
                                {
                                    toplamKredi = toplamKredi + 200;
                                    LblKredim.Text = toplamKredi.ToString();
                                    blackTutucu100 = 0;
                                    karZarar = karZarar + 200;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Kutu siyah değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    blackTutucu100 = 0;
                                }
                            }
                            else if (blackTutucu300 != 0)
                            {
                                if (rastgeleGelen % 2 == 1 && rastgeleGelen != 37)
                                {
                                    toplamKredi = toplamKredi + 600;
                                    LblKredim.Text = toplamKredi.ToString();
                                    blackTutucu300 = 0;
                                    karZarar = karZarar + 600;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Kutu siyah değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    blackTutucu300 = 0;
                                }
                            }
                            else if (redTutucu500 != 0)
                            {
                                if (rastgeleGelen % 2 == 1 && rastgeleGelen != 37)
                                {
                                    toplamKredi = toplamKredi + 1000;
                                    LblKredim.Text = toplamKredi.ToString();
                                    blackTutucu500 = 0;
                                    karZarar = karZarar + 1000;
                                    LblKarZarar.Text = karZarar.ToString();
                            }
                                else
                                {
                                    MessageBox.Show("Kutu siyah değil, kaybettiniz.", "Uyarı", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    blackTutucu500 = 0;
                                }
                            }
                            else if (seckTutucu100 != 0)
                            {
                                    if (rastgeleGelen.ToString() == mskTahmin.Text)
                                    {
                                        toplamKredi = toplamKredi + 500;
                                        LblKredim.Text = toplamKredi.ToString();
                                        seckTutucu100 = 0;
                                        mskTahmin.Clear();
                                        karZarar = karZarar + 500;
                                        LblKarZarar.Text = karZarar.ToString();
                            }
                                    else
                                    {
                                        MessageBox.Show("Maalesef tahimininiz doğru değil.", "Uyarı",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                        seckTutucu100 = 0;
                                        mskTahmin.Clear();
                                    }
                            }
                            else if (secTutucu300 != 0)
                            {
                                    if (rastgeleGelen.ToString() == mskTahmin.Text)
                                    {
                                        toplamKredi = toplamKredi + 1500;
                                        LblKredim.Text = toplamKredi.ToString();
                                        secTutucu300 = 0;
                                        mskTahmin.Clear();
                                        karZarar = karZarar + 1500;
                                        LblKarZarar.Text = karZarar.ToString();
                            }
                                    else
                                    {
                                        MessageBox.Show("Maalesef tahimininiz doğru değil.", "Uyarı",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                        secTutucu300 = 0;
                                        mskTahmin.Clear();
                                    }

                            }
                            else if (secTutucu500 != 0)
                            {
                                    if (rastgeleGelen % 2 == 1 && rastgeleGelen != 37)
                                    {
                                        toplamKredi = toplamKredi + 2500;
                                        LblKredim.Text = toplamKredi.ToString();
                                        secTutucu500 = 0;
                                        mskTahmin.Clear();
                                        karZarar = karZarar + 2500;
                                        LblKarZarar.Text = karZarar.ToString();
                            }
                                    else
                                    {
                                        MessageBox.Show("Maalesef tahimininiz doğru değil.", "Uyarı",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                        secTutucu500 = 0;
                                        mskTahmin.Clear();
                                    }

                            }


                            btnEven.Enabled = true;
                            btnRed.Enabled = true;
                            btnBlack.Enabled = true;
                            btnSec.Enabled = true;
                            btnOdd.Enabled = true;

                            btnYatır100.Enabled = true;
                            btnYatır300.Enabled = true;
                            btnYatır500.Enabled = true;

                            saniye = 0;
                            if (rastgeleGelen % 2 == 0)
                            {
                                sayi[rastgeleGelen].BackColor = Color.Red;
                            }
                            else if(rastgeleGelen==37)
                            {
                                sayi[rastgeleGelen].BackColor = Color.Yellow;
                            }
                            else
                            {
                                sayi[rastgeleGelen].BackColor = Color.Black;
                            }

                    }
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            sayi[i].BackColor = Color.Red;
                        }
                        else if(i==37)
                        {
                            sayi[i].BackColor = Color.Yellow;
                        }
                        else
                        {
                            sayi[i].BackColor = Color.Black;
                        }
                    }
            }

            if (saniye == 37)
            {
                timerHesap.Stop();
            }

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = false;
            btnRed.Enabled = false;
            btnBlack.Enabled = false;
            btnSec.Enabled = false;
            btnOdd.Enabled = false;
            rastgeleGelen = rastgele.Next(1, 37);
            if (btnYatır100.Enabled == false)
            {
                if (toplamKredi >= 100)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır100);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır100.Enabled = true;
                    timerHesap.Stop();
                }
                //Kazanilan oyun
                redTutucu100++;
            }
            else if (btnYatır300.Enabled == false)
            {
                if (toplamKredi >= 300)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır300);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır300.Enabled = true;
                    timerHesap.Stop();
                }

                redTutucu300++;

            }
            else if (btnYatır500.Enabled == false)
            {
                if (toplamKredi >= 500)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır500);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır500.Enabled = true;
                    timerHesap.Stop();
                }
                redTutucu500++;

            }
        }

        private void btnYatır100_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = true;
            btnRed.Enabled = true;
            btnBlack.Enabled = true;
            btnSec.Enabled = true;
            btnOdd.Enabled = true;
            btnYatır100.Enabled = false;

        }

        private void btnYatır300_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = true;
            btnRed.Enabled = true;
            btnBlack.Enabled = true;
            btnSec.Enabled = true;
            btnOdd.Enabled = true;
            btnYatır300.Enabled = false;
        }

        private void btnYatır500_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = true;
            btnRed.Enabled = true;
            btnBlack.Enabled = true;
            btnSec.Enabled = true;
            btnOdd.Enabled = true;
            btnYatır500.Enabled = false;
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            btnEven.Enabled = false;
            btnRed.Enabled = false;
            btnBlack.Enabled = false;
            btnSec.Enabled = false;
            btnOdd.Enabled = false;
            rastgeleGelen = rastgele.Next(1, 37);
            if (btnYatır100.Enabled == false)
            {
                if (toplamKredi >= 100)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır100);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }

                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır100.Enabled = true;
                    timerHesap.Stop();
                }
                //Kazanilan oyun
                evenTutucu100++;


            }
            else if (btnYatır300.Enabled == false)
            {
                if (toplamKredi >= 300)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır300);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır300.Enabled = true;
                    timerHesap.Stop();
                }
                evenTutucu300++;

            }
            else if (btnYatır500.Enabled == false)
            {
                if (toplamKredi >= 500)
                {
                    timerHesap.Start();
                    krediHesaplama(btnYatır500);
                    oyunSayisi++;
                    LblOyunSayisi.Text = oyunSayisi.ToString();
                    if (oyunSayisi >= 10)
                    {
                        btnEven.Enabled = false;
                        btnRed.Enabled = false;
                        btnBlack.Enabled = false;
                        btnSec.Enabled = false;
                        btnOdd.Enabled = false;
                        MessageBox.Show("Oyun bitti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timerHesap.Stop();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli bakiyeniz yok.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnYatır500.Enabled = true;
                    timerHesap.Stop();
                }
                evenTutucu500++;

            }
        }
        private void Bahis_Load(object sender, EventArgs e)
        {
            btnEven.Enabled = false;
            btnRed.Enabled = false;
            btnBlack.Enabled = false;
            btnSec.Enabled = false;
            btnOdd.Enabled = false;
            timerHesap.Interval = 200;
            for (int i = 0; i < 12; i++)
            {
                int sol = 55;             
                sayi[kn] = new Button();
                if (kn%2==0)
                {
                    sayi[kn].BackColor = Color.Red;
                }
                else
                {
                    sayi[kn].BackColor = Color.Black;
                }

                sayi[kn].ForeColor = Color.White;
                sayi[kn].Text = (i + 1).ToString();
                sayi[kn].Size = new Size(50, 50);
                sayi[kn].Location = new Point(bask + (i * sol), 80);
                this.Controls.Add(sayi[kn]);   
                
                kn++;

            }

            for (int i = 11; i>= 0; i--)
            {
                int sol = 55;
                sayi[kn] = new Button();
                if (kn % 2 == 0)
                {
                    sayi[kn].BackColor = Color.Red;
                }
                else
                {
                    sayi[kn].BackColor = Color.Black;
                }

                sayi[kn].ForeColor = Color.White;
                sayi[kn].Text = (kn).ToString();
                sayi[kn].Size = new Size(50, 50);
                sayi[kn].Location = new Point(bask + (i * sol), 140);
                this.Controls.Add(sayi[kn]);
                kn++;
            }

            for (int i = 0; i <12; i++)
            {
                int sol = 55;
                sayi[kn] = new Button();
                if (kn % 2 == 0)
                {
                    sayi[kn].BackColor = Color.Red;
                }
                else
                {
                    sayi[kn].BackColor = Color.Black;
                }

                sayi[kn].ForeColor = Color.White;
                sayi[kn].Text = (kn).ToString();
                sayi[kn].Size = new Size(50, 50);
                sayi[kn].Location = new Point(bask + (i * sol), 200);
                this.Controls.Add(sayi[kn]);
                kn++;
            }

            sayi[37] = new Button();
            sayi[37].BackColor = Color.Yellow;
            sayi[37].ForeColor = Color.Black;
            sayi[37].Text = (0).ToString();
            sayi[37].Size = new Size(50, 50);
            sayi[37].Location = new Point(45, 140);
            this.Controls.Add(sayi[37]);

            LblKredim.Text = toplamKredi.ToString();
            
        }
    }
}
