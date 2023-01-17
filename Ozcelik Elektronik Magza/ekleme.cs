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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ozcelik_Elektronik_Magza
{
    public partial class ekleme : Form
    {
        AnaSayfa anaSayfa = new AnaSayfa();
        public ekleme(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa = anaSayfa;
        }

        private void ekleme_Load(object sender, EventArgs e)
        {

        }
        public MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                veritabanibaglantisi.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into laptoplar (MARKA,Fiyat,UrunOzellikleri) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text +"')", veritabanibaglantisi);
                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                if (sonuc != null)
                    MessageBox.Show("Veriniz Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Veriniz Sisteme Eklenirken Bir Hata Olşutu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                veritabanibaglantisi.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
            textBox2.Clear();
           
            richTextBox1.Clear();

            this.Close();

            anaSayfa.islempaneli.Controls.Clear();
            adminpaneli goruntu = new adminpaneli(anaSayfa);
            goruntu.TopLevel = false;
            anaSayfa.islempaneli.Controls.Add(goruntu);
            goruntu.Show();
            goruntu.Dock = DockStyle.Fill;
            goruntu.BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            anaSayfa.islempaneli.Controls.Clear();
            adminpaneli goruntu = new adminpaneli(anaSayfa);
            goruntu.TopLevel = false;
            anaSayfa.islempaneli.Controls.Add(goruntu);
            goruntu.Show();
            goruntu.Dock = DockStyle.Fill;
            goruntu.BringToFront();
        }
    }
}
