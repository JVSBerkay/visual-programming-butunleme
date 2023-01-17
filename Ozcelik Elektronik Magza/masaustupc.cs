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
    public partial class masaustupc : Form
    {
        MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");

        AnaSayfa anaSayfa = new AnaSayfa();
        public masaustupc()
        {
            InitializeComponent();
         
        }
        public void zeironpc() {
            veritabanibaglantisi.Open();


            MySqlCommand komut = new MySqlCommand("SELECT * FROM masaustubilgisayar WHERE UrunId='5' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = (oku["Ozellikler"]).ToString();
                label2.Text = (oku["Fiyat"] + " TL");
                label1.Text = ("" + oku["MARKA"]);
            }
            veritabanibaglantisi.Close();

        }
        public void gamepagepc() {
            veritabanibaglantisi.Open();


            MySqlCommand komut = new MySqlCommand("SELECT * FROM masaustubilgisayar WHERE UrunId='6' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox2.Text = (oku["Ozellikler"]).ToString();
                label3.Text = (oku["Fiyat"] + " TL");
                label4.Text = ("" + oku["MARKA"]);
            }
            veritabanibaglantisi.Close();
        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void masaustupc_Load(object sender, EventArgs e)
        {
            zeironpc();
            gamepagepc();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            zeironmasaustupc zeironmasaustupc = new zeironmasaustupc(anaSayfa);
            zeironmasaustupc.Show();
            this.Hide();
            
        }

        private void masaustupc_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaSayfa.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gamepagemasaustupc gamepagemasaustupc = new gamepagemasaustupc(anaSayfa);
            gamepagemasaustupc.Show();
            this.Hide();
        }
    }
}
