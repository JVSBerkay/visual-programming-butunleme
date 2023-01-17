using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ozcelik_Elektronik_Magza
{
    public partial class laptoplar : Form
    {
        

        AnaSayfa anaEkran = new AnaSayfa();
        public laptoplar(AnaSayfa parametredengelen)
        {
            InitializeComponent();
            anaEkran = parametredengelen;
        }

        public laptoplar()
        {
        }

        MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");

        int sepet = 1;
        
      
        public void monster()
        {
            

            veritabanibaglantisi.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='1' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                label2.Text = (oku["Fiyat"] + " TL");
                label1.Text = ("" + oku["MARKA"]);
            }
            veritabanibaglantisi.Close();
        }
        public void macbook()
        {
            veritabanibaglantisi.Open();


            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='2' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox2.Text = (oku["UrunOzellikleri"]).ToString();
                label3.Text = (oku["Fiyat"] + " TL");
                label4.Text = ("" + oku["MARKA"]);
            }
            veritabanibaglantisi.Close();

        }
        public void lenova()
        {
            veritabanibaglantisi.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='3' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox3.Text = (oku["UrunOzellikleri"]).ToString();
                label5.Text = (oku["Fiyat"] + " TL");
                label6.Text = ("" + oku["MARKA"]);
            }

            veritabanibaglantisi.Close();
        }
        public void huawei()
        {
            veritabanibaglantisi.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='4' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox4.Text = (oku["UrunOzellikleri"]).ToString();
                label7.Text = (oku["Fiyat"] + " TL");
                label8.Text = ("" + oku["MARKA"]);
            }
            veritabanibaglantisi.Close();

        }

        private void macbookekleme() {
            
            
           
        }
        private void laptoplar_Load(object sender, EventArgs e)
        {
            
            monster();
            macbook();
            lenova();
            huawei();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
      
        private void groupBox6_Enter(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sepetim sepetim = new sepetim(this);
           


        }

        private void laptoplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MonsterLaptop monsterLaptop = new MonsterLaptop(anaEkran);
            monsterLaptop.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            macbook macbook = new macbook(anaEkran);
            macbook.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lenova lenova = new lenova(anaEkran);
            lenova.Show();
            this.Hide();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sepetimToolStripMenuItem.Text = "Sepetim" + "(" + sepet.ToString() + ")";
            sepet--;
            
        }

        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sepetim sepetim = new sepetim(this);
            sepetim.Show();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            huawei1 huawei1 = new huawei1(anaEkran);
            huawei1.Show();
            this.Hide();
        }
    }
}
