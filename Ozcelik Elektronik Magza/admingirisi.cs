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
    public partial class admingirisi : Form
    {
        AnaSayfa anaSayfa=new AnaSayfa();
        public admingirisi(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa = anaSayfa;
        }
     
        baglanti veritabanibaglantisi = new baglanti();
        //public MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");

        public string kullaniciadi;
        private void button1_Click(object sender, EventArgs e)
        {
            DizüstübilgisayarMenü dizüstübilgisayar = new DizüstübilgisayarMenü(anaSayfa);
            masaüstübilgisayarMenü masaüstübilgisayar = new masaüstübilgisayarMenü(anaSayfa);

            veritabanibaglantisi.conn.Open();


            string sifre;
             kullaniciadi = textBox1.Text;
            sifre = textBox2.Text;

            MySqlCommand komut = new MySqlCommand("SELECT * FROM uyeler WHERE Kullanici='" + kullaniciadi + "' and sifre='" + sifre + "'and admin_mi ='1'", veritabanibaglantisi.conn);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                MessageBox.Show("Giris Basarili !");
              
                anaSayfa.islempaneli.Controls.Clear();
                adminpaneli adminpaneli = new adminpaneli(anaSayfa);
                adminpaneli.TopLevel = false;
                anaSayfa.islempaneli.Controls.Add(adminpaneli);
                adminpaneli.Show();
                adminpaneli.Dock = DockStyle.Fill;
                adminpaneli.BringToFront();

                anaSayfa.button2.Text = kullaniciadi;
                anaSayfa.GirisButonu.Visible = false;
                anaSayfa.KayitButonu.Visible = false;
                anaSayfa.button4.Visible= false;
                anaSayfa.CikisButonu.Visible = true;
                anaSayfa.button11.Visible = false;
                anaSayfa.button14.Visible = false;

                this.Hide();
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Hatali Giris Yaptiniz");
            }

            veritabanibaglantisi.conn.Close();
        }
    }
}
