using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ozcelik_Elektronik_Magza
{
    public partial class sepetim : Form
    {
        
        public DizüstübilgisayarMenü laptoplar = new DizüstübilgisayarMenü();
        MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");
        public sepetim(DizüstübilgisayarMenü parametrelaptoplar)
        {
            InitializeComponent();
            laptoplar = parametrelaptoplar;
        }

        private void sepetim_Load(object sender, EventArgs e)
        {
            RichTextBox richTextBox = new RichTextBox();
            veritabanibaglantisi.Open();

            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='1' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox.Text = (oku["UrunOzellikleri"]).ToString();
            }
            veritabanibaglantisi.Close();
            richTextBox.Left = 53;
            richTextBox.Size = new Size(400, 50);
            this.Controls.Add(richTextBox);
        }
    }
}
