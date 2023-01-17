using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ozcelik_Elektronik_Magza
{
    public partial class Uye_Girisi : Form
    {
       
        AnaSayfa anaSayfa= new AnaSayfa();
        public Uye_Girisi(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa = anaSayfa;
        }
        baglanti veritabanibaglantisi= new baglanti();
        private void Uye_Girisi_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        //202151502016
      
        public string kullaniciadi;

        #region giris
        private void button1_Click(object sender, EventArgs e)
        {
            DizüstübilgisayarMenü dizüstübilgisayar = new DizüstübilgisayarMenü(anaSayfa);
            masaüstübilgisayarMenü masaüstübilgisayar = new masaüstübilgisayarMenü(anaSayfa);

            veritabanibaglantisi.conn.Open();

            
            string sifre;
            kullaniciadi = textBox1.Text;
            sifre=textBox2.Text;

            MySqlCommand komut = new MySqlCommand("SELECT * FROM uyeler WHERE Kullanici='" + kullaniciadi + "' and sifre='" + sifre + "'", veritabanibaglantisi.conn);
            MySqlDataReader okuyucu=komut.ExecuteReader();
            if (okuyucu.Read())
            {
                MessageBox.Show("Giris Basarili !");

                anaSayfa.button2.Text = kullaniciadi;
                anaSayfa.GirisButonu.Visible = false;
                anaSayfa.KayitButonu.Visible = false;
                anaSayfa.button4.Visible= false;
                anaSayfa.CikisButonu.Visible = true;

                this.Hide();
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Hatali Giris Yaptiniz");
            }

            veritabanibaglantisi.conn.Close();

            
          

        }
        #endregion

        #region uyeolma
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           anaSayfa.islempaneli.Controls.Clear();
            Uye_olma uye = new Uye_olma(anaSayfa);
            uye.TopLevel = false;
           anaSayfa.islempaneli.Controls.Add(uye);
            uye.Show();
            uye.Dock = DockStyle.Fill;
            uye.BringToFront();
        }

        private void Uye_Girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
