using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ozcelik_Elektronik_Magza
{
    public partial class Uye_olma : Form
    {

        AnaSayfa ana = new AnaSayfa();
        public Uye_olma(AnaSayfa ana)
        {
            InitializeComponent();
            this.ana = ana;
        }
        baglanti veritabanibaglantisi = new baglanti();
        private void Uye_olma_Load(object sender, EventArgs e)
        { //202151502016
            comboBox1.Items.Add("@gmail.com");
            comboBox1.Items.Add("@hotmail.com");
            comboBox1.Items.Add("@outlook.com");
            textBox1.MaxLength = 18;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Lutfen Bilgilerinizi Doldurunuz !!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lutfen Sifre Giriniz !!");

            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lutfen Kullanici Adi Giriniz !!");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Lutfen E postanizi Giriniz !!");

            }
            else if (textBox2.Text!=textBox3.Text)
            {
                MessageBox.Show("Sifreleriniz Uyusmuyor !!");

            }
            else
            {
                veritabanibaglantisi.conn.Open();

                string kullaniciadi;
                string sifre;
                string eposta;
                string eposta1;
                kullaniciadi = textBox1.Text;
                sifre = textBox2.Text;
                eposta = textBox4.Text;
                eposta1 = comboBox1.Text;
                MySqlCommand komut = new MySqlCommand("SELECT * FROM uyeler WHERE Kullanici='" + kullaniciadi + "'", veritabanibaglantisi.conn);
                MySqlDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read())
                {
                    MessageBox.Show("Bu kullanici Adi Kullaniliyor!! Lutfen Baska Bir Kullanici Adi Seciniz");
                }
                else
                {
                    okuyucu.Close();
                    MySqlCommand ekle = new MySqlCommand("insert into uyeler(Kullanici,sifre,Eposta) values('" + kullaniciadi + "','" + sifre + "','" + eposta + eposta1 + "')", veritabanibaglantisi.conn);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("KAYIT OLDUNUZ!!");
                }

                veritabanibaglantisi.conn.Close();
                Uye_Girisi uye_Girisi = new Uye_Girisi(ana);
                uye_Girisi.Show();
                this.Close();
            }
       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void Uye_olma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Uye_Girisi uye_Girisi = new Uye_Girisi(ana);
            uye_Girisi.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ana.islempaneli.Controls.Clear();
            Uye_Girisi uye = new Uye_Girisi(ana);
            uye.TopLevel = false;
            ana.islempaneli.Controls.Add(uye);
            uye.Show();
            uye.Dock = DockStyle.Fill;
            uye.BringToFront();

        }
    }
}
