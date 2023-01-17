using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Ozcelik_Elektronik_Magza
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
           
            InitializeComponent();
            duzen();
        }
        
        baglanti veritabanibaglantisi = new baglanti();
        DataTable tablo = new DataTable();

        private void laptoplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DizüstübilgisayarMenü laptoplar = new DizüstübilgisayarMenü(this);
            laptoplar.Show();
            this.Hide();

        }
        #region menuDuzeni Vs
        private void duzen()
        {
           GIRIS.Visible = false;
            URUNLER.Visible = false;
            FACT.Visible = false;
        }
        private void hidesubmenu()
        {

            if (URUNLER.Visible == true)
                URUNLER.Visible = false;
            if (FACT.Visible == true)
                FACT.Visible = false;
            if (GIRIS.Visible == true)
                GIRIS.Visible = false;

        }
        private void showsubmenu(Panel menu)
        {

            if (menu.Visible == false)
            {
                hidesubmenu();
                menu.Visible = true;
            }
            else
            {

                menu.Visible = false;
            }
        }
        #endregion
 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }
     
        private void AnaSayfa_Load_1(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
            anasayfagoruntu goruntu = new anasayfagoruntu();
            goruntu.TopLevel = false;
            islempaneli.Controls.Add(goruntu);
            goruntu.Show();
            goruntu.Dock = DockStyle.Fill;
            goruntu.BringToFront();

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            showsubmenu(GIRIS);

        }

        #region urunler
        private void button11_Click(object sender, EventArgs e)
        {
            showsubmenu(URUNLER);

        }

       
        private void laptoplar_Click(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
           DizüstübilgisayarMenü dizustubilgisayar = new DizüstübilgisayarMenü(this);
            dizustubilgisayar.TopLevel = false;
            islempaneli.Controls.Add(dizustubilgisayar);
            dizustubilgisayar.Show();
            dizustubilgisayar.Dock=DockStyle.Fill;
            dizustubilgisayar.BringToFront();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
            masaüstübilgisayarMenü masaüstübilgisayar = new masaüstübilgisayarMenü(this);
            masaüstübilgisayar.TopLevel = false;
            islempaneli.Controls.Add(masaüstübilgisayar);
            masaüstübilgisayar.Show();
            masaüstübilgisayar.Dock = DockStyle.Fill;
            masaüstübilgisayar.BringToFront();
            

        }
        #endregion

        #region giris
        private void GirisButonu_Click(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
            Uye_Girisi uye = new Uye_Girisi(this);
            uye.TopLevel = false;
            islempaneli.Controls.Add(uye);
            uye.Show();
            uye.Dock = DockStyle.Fill;
            uye.BringToFront();
        }

        private void KayitButonu_Click(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
            Uye_olma uye = new Uye_olma(this);
            uye.TopLevel = false;
            islempaneli.Controls.Add(uye);
            uye.Show();
            uye.Dock = DockStyle.Fill;
            uye.BringToFront();
        }
        #endregion

        #region anasayfabutonu
        private void button3_Click(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
            anasayfagoruntu ana = new anasayfagoruntu();
            ana.TopLevel = false;
            islempaneli.Controls.Add(ana);
            ana.Show();
            ana.Dock = DockStyle.Fill;
            ana.BringToFront();
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
            admingirisi admin = new admingirisi(this);
            admin.TopLevel = false;
            islempaneli.Controls.Add(admin);
            admin.Show();
            admin.Dock = DockStyle.Fill;
            admin.BringToFront();
        }

        private void CikisButonu_Click(object sender, EventArgs e)
        {
            


            button2.Text = "Giris Yap";
            button4.Visible = true;
            GirisButonu.Visible= true;
            KayitButonu.Visible= true;
            CikisButonu.Visible = false;
            button14.Visible = true;
            button11.Visible = true;
            islempaneli.Controls.Clear();
            anasayfagoruntu goruntu = new anasayfagoruntu();
            goruntu.TopLevel = false;
            islempaneli.Controls.Add(goruntu);
            goruntu.Show();
            goruntu.Dock = DockStyle.Fill;
            goruntu.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            telefon telefon = new telefon();
            telefon.TopLevel = false;
            islempaneli.Controls.Add(telefon);
            telefon.Show();
            telefon.Dock = DockStyle.Fill;
            telefon.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void islempaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            islempaneli.Controls.Clear();
            havadurumu dolar = new havadurumu();
            dolar.TopLevel = false;
            islempaneli.Controls.Add(dolar);
            dolar.Show();
            dolar.Dock = DockStyle.Fill;
            dolar.BringToFront();
        }
    }
}
