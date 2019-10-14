namespace Gorsel_Bahis_Uygulamasi
{
    partial class Bahis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bahis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxKrediler = new System.Windows.Forms.ListBox();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.LblKredim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerHesap = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYatır500 = new System.Windows.Forms.Button();
            this.btnYatır300 = new System.Windows.Forms.Button();
            this.btnYatır100 = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.mskTahmin = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblOyunSayisi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblKarZarar = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxKrediler);
            this.panel1.Controls.Add(this.btn1000);
            this.panel1.Controls.Add(this.btn500);
            this.panel1.Controls.Add(this.btn200);
            this.panel1.Controls.Add(this.btn100);
            this.panel1.Controls.Add(this.LblKredim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(824, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 382);
            this.panel1.TabIndex = 1;
            // 
            // listBoxKrediler
            // 
            this.listBoxKrediler.FormattingEnabled = true;
            this.listBoxKrediler.ItemHeight = 31;
            this.listBoxKrediler.Location = new System.Drawing.Point(22, 161);
            this.listBoxKrediler.Name = "listBoxKrediler";
            this.listBoxKrediler.Size = new System.Drawing.Size(271, 159);
            this.listBoxKrediler.TabIndex = 21;
            // 
            // btn1000
            // 
            this.btn1000.BackColor = System.Drawing.Color.Red;
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1000.ForeColor = System.Drawing.Color.White;
            this.btn1000.Location = new System.Drawing.Point(321, 252);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(119, 45);
            this.btn1000.TabIndex = 20;
            this.btn1000.Text = "1000 TL";
            this.btn1000.UseVisualStyleBackColor = false;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.Color.Red;
            this.btn500.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn500.ForeColor = System.Drawing.Color.White;
            this.btn500.Location = new System.Drawing.Point(321, 201);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(119, 45);
            this.btn500.TabIndex = 20;
            this.btn500.Text = "500 TL";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn200
            // 
            this.btn200.BackColor = System.Drawing.Color.Red;
            this.btn200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn200.ForeColor = System.Drawing.Color.White;
            this.btn200.Location = new System.Drawing.Point(321, 150);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(119, 45);
            this.btn200.TabIndex = 20;
            this.btn200.Text = "200 TL";
            this.btn200.UseVisualStyleBackColor = false;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.Red;
            this.btn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn100.ForeColor = System.Drawing.Color.White;
            this.btn100.Location = new System.Drawing.Point(321, 99);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(119, 45);
            this.btn100.TabIndex = 20;
            this.btn100.Text = "100 TL";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // LblKredim
            // 
            this.LblKredim.AutoSize = true;
            this.LblKredim.BackColor = System.Drawing.Color.White;
            this.LblKredim.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKredim.Location = new System.Drawing.Point(148, 49);
            this.LblKredim.Name = "LblKredim";
            this.LblKredim.Size = new System.Drawing.Size(30, 29);
            this.LblKredim.TabIndex = 19;
            this.LblKredim.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kredim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Alınan Krediler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kredi Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oyuncu Bilgileri";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerHesap
            // 
            this.timerHesap.Tick += new System.EventHandler(this.timerHesap_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.LblKarZarar);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnYatır500);
            this.panel2.Controls.Add(this.btnYatır300);
            this.panel2.Controls.Add(this.btnYatır100);
            this.panel2.Controls.Add(this.btnSec);
            this.panel2.Controls.Add(this.mskTahmin);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnEven);
            this.panel2.Controls.Add(this.btnBlack);
            this.panel2.Controls.Add(this.btnOdd);
            this.panel2.Controls.Add(this.btnRed);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(22, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 390);
            this.panel2.TabIndex = 2;
            // 
            // btnYatır500
            // 
            this.btnYatır500.BackColor = System.Drawing.Color.DarkBlue;
            this.btnYatır500.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatır500.ForeColor = System.Drawing.Color.White;
            this.btnYatır500.Location = new System.Drawing.Point(246, 294);
            this.btnYatır500.Name = "btnYatır500";
            this.btnYatır500.Size = new System.Drawing.Size(105, 68);
            this.btnYatır500.TabIndex = 25;
            this.btnYatır500.Text = "500";
            this.btnYatır500.UseVisualStyleBackColor = false;
            this.btnYatır500.Click += new System.EventHandler(this.btnYatır500_Click);
            // 
            // btnYatır300
            // 
            this.btnYatır300.BackColor = System.Drawing.Color.DarkBlue;
            this.btnYatır300.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatır300.ForeColor = System.Drawing.Color.White;
            this.btnYatır300.Location = new System.Drawing.Point(135, 294);
            this.btnYatır300.Name = "btnYatır300";
            this.btnYatır300.Size = new System.Drawing.Size(105, 68);
            this.btnYatır300.TabIndex = 25;
            this.btnYatır300.Text = "300";
            this.btnYatır300.UseVisualStyleBackColor = false;
            this.btnYatır300.Click += new System.EventHandler(this.btnYatır300_Click);
            // 
            // btnYatır100
            // 
            this.btnYatır100.BackColor = System.Drawing.Color.DarkBlue;
            this.btnYatır100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatır100.ForeColor = System.Drawing.Color.White;
            this.btnYatır100.Location = new System.Drawing.Point(24, 294);
            this.btnYatır100.Name = "btnYatır100";
            this.btnYatır100.Size = new System.Drawing.Size(105, 68);
            this.btnYatır100.TabIndex = 25;
            this.btnYatır100.Text = "100";
            this.btnYatır100.UseVisualStyleBackColor = false;
            this.btnYatır100.Click += new System.EventHandler(this.btnYatır100_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSec.ForeColor = System.Drawing.Color.White;
            this.btnSec.Location = new System.Drawing.Point(590, 144);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(79, 39);
            this.btnSec.TabIndex = 23;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // mskTahmin
            // 
            this.mskTahmin.Location = new System.Drawing.Point(545, 145);
            this.mskTahmin.Mask = "00";
            this.mskTahmin.Name = "mskTahmin";
            this.mskTahmin.Size = new System.Drawing.Size(39, 38);
            this.mskTahmin.TabIndex = 22;
            this.mskTahmin.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(533, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = " Hangi sayi gelir ?";
            // 
            // btnEven
            // 
            this.btnEven.BackColor = System.Drawing.Color.Green;
            this.btnEven.ForeColor = System.Drawing.Color.White;
            this.btnEven.Location = new System.Drawing.Point(124, 109);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(92, 83);
            this.btnEven.TabIndex = 20;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = false;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(395, 109);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(91, 83);
            this.btnBlack.TabIndex = 20;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.BackColor = System.Drawing.Color.Green;
            this.btnOdd.ForeColor = System.Drawing.Color.White;
            this.btnOdd.Location = new System.Drawing.Point(23, 109);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(95, 83);
            this.btnOdd.TabIndex = 20;
            this.btnOdd.Text = "Odd";
            this.btnOdd.UseVisualStyleBackColor = false;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(294, 109);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(95, 83);
            this.btnRed.TabIndex = 20;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oyun Bilgileri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 34);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(560, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 34);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sayıya Göre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 34);
            this.label7.TabIndex = 19;
            this.label7.Text = "Red ve Black";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(378, 34);
            this.label11.TabIndex = 19;
            this.label11.Text = "Yatırmak istediğiniz Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "Odd ve Even";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(583, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "Oyun Sayısı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(824, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblOyunSayisi
            // 
            this.LblOyunSayisi.AutoSize = true;
            this.LblOyunSayisi.ForeColor = System.Drawing.Color.White;
            this.LblOyunSayisi.Location = new System.Drawing.Point(751, 282);
            this.LblOyunSayisi.Name = "LblOyunSayisi";
            this.LblOyunSayisi.Size = new System.Drawing.Size(31, 32);
            this.LblOyunSayisi.TabIndex = 20;
            this.LblOyunSayisi.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(405, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 32);
            this.label13.TabIndex = 26;
            this.label13.Text = "Kar - Zarar Durumu:";
            // 
            // LblKarZarar
            // 
            this.LblKarZarar.AutoSize = true;
            this.LblKarZarar.ForeColor = System.Drawing.Color.White;
            this.LblKarZarar.Location = new System.Drawing.Point(663, 330);
            this.LblKarZarar.Name = "LblKarZarar";
            this.LblKarZarar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblKarZarar.Size = new System.Drawing.Size(31, 32);
            this.LblKarZarar.TabIndex = 27;
            this.LblKarZarar.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(692, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 32);
            this.label14.TabIndex = 28;
            this.label14.Text = "TL";
            // 
            // Bahis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1342, 741);
            this.Controls.Add(this.LblOyunSayisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Bahis";
            this.Text = "Casino Roulette Oyunu";
            this.Load += new System.EventHandler(this.Bahis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblKredim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Timer timerHesap;
        private System.Windows.Forms.ListBox listBoxKrediler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTahmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnYatır100;
        private System.Windows.Forms.Button btnYatır500;
        private System.Windows.Forms.Button btnYatır300;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblOyunSayisi;
        private System.Windows.Forms.Label LblKarZarar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}