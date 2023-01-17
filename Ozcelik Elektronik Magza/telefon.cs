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
    public partial class telefon : Form
    {
        public MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");

        public telefon()
        {
            InitializeComponent();
        }
        public void huaweitelefon() 
        {
            veritabanibaglantisi.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM telefon WHERE UrunId='1' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                richTextBox1.Text = (oku["Ozellikler"]).ToString();
                label2.Text = (oku["Fiyat"] + " TL");
                label1.Text = ("" + oku["MARKA"]);

            }
            veritabanibaglantisi.Close();

        }
        private void telefon_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty51/product/media/images/20210111/22/51175311/128682337/1/1_org_zoom.jpg";
            huaweitelefon();
        }
    }
}
