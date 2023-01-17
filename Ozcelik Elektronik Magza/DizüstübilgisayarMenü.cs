using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Ozcelik_Elektronik_Magza
{
    public partial class DizüstübilgisayarMenü : Form
    {
        AnaSayfa anaEkran = new AnaSayfa();
        

        public DizüstübilgisayarMenü(AnaSayfa parametredengelen)
        {
            InitializeComponent();
            anaEkran = parametredengelen;
        }


       baglanti veritabanibaglantisi= new baglanti();

        #region Laptoplar MARKA ve kisa ozellikler
        public void monster() {
            veritabanibaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='1' ", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
             richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
             label2.Text = (oku["Fiyat"] + " TL");
              label1.Text = ("" + oku["MARKA"]);

            }
            veritabanibaglantisi.conn.Close();
        }
        public void macbook()
        {
            veritabanibaglantisi.conn.Open();


            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='2' ", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox2.Text = (oku["UrunOzellikleri"]).ToString();
                label3.Text = (oku["Fiyat"] + " TL");
                label4.Text = ("" + oku["MARKA"]);
            }
            veritabanibaglantisi.conn.Close();

        }
        public void lenova()
        {
            veritabanibaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='3' ", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox3.Text = (oku["UrunOzellikleri"]).ToString();
                label5.Text = (oku["Fiyat"] + " TL");
                label6.Text = ("" + oku["MARKA"]);
            }

            veritabanibaglantisi.conn.Close();
        }
        public void huawei()
        {
            veritabanibaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='4' ", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox4.Text = (oku["UrunOzellikleri"]).ToString();
                label7.Text = (oku["Fiyat"] + " TL");
                label8.Text = ("" + oku["MARKA"]);
            }
            veritabanibaglantisi.conn.Close();

        }
        #endregion


        #region Ana Ekran load
        private void laptoplar_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty510/product/media/images/20220819/12/162760631/547832697/1/1_org_zoom.jpg";
            pictureBox2.ImageLocation = "https://cdn.dsmcdn.com/ty454/product/media/images/20220614/15/125590297/117920493/1/1_org_zoom.jpg";
            pictureBox3.ImageLocation = "https://cdn.dsmcdn.com/ty377/product/media/images/20220329/13/78155622/125641416/2/2_org_zoom.jpg";
            pictureBox4.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty318/product/media/images/20220202/14/41808255/378512354/1/1_org_zoom.jpg";
            pictureBox5.ImageLocation = "https://s9.gifyu.com/images/ozceLIK-A.S-_1_.gif";


            monster();
            macbook();
            lenova();
            huawei();
            
        }
        #endregion


        #region Laptop detayli ozellikler
        private void label6_Click(object sender, EventArgs e)
        {

        }
      
        private void groupBox6_Enter(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
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
            Dizustubilgisayar dizustubilgisayar = new Dizustubilgisayar(anaEkran);

            dizustubilgisayar.fotograf1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty510/product/media/images/20220819/12/162760631/547832697/1/1_org_zoom.jpg";
            dizustubilgisayar.fotograf2.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty527/product/media/images/20220908/8/170597116/547832697/2/2_org_zoom.png";
            dizustubilgisayar.fotograf3.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty510/product/media/images/20220819/12/162760631/547832697/2/2_org_zoom.jpg";
            dizustubilgisayar.fotograf4.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty512/product/media/images/20220819/12/162760631/547832697/6/6_org_zoom.jpg";


            veritabanibaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='1'", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dizustubilgisayar.label1.Text = (oku["MARKA"]).ToString();
                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                dizustubilgisayar.Text1.Text = (oku["Isletimsistemi"]).ToString();
                dizustubilgisayar.Text2.Text = (oku["Ekranyenilemehizi"]).ToString();
                dizustubilgisayar.Text3.Text = (oku["GarantiTipi"]).ToString();
                dizustubilgisayar.Text4.Text = (oku["CihazAğırlığı"]).ToString();
                dizustubilgisayar.Text5.Text = (oku["EkranKartı"]).ToString();
                dizustubilgisayar.Text6.Text = (oku["EkranBoyutu"]).ToString();
                dizustubilgisayar.Text7.Text = (oku["Kapasite"]).ToString();
                dizustubilgisayar.Text8.Text = (oku["Dokunmatik Ekran"]).ToString();
                dizustubilgisayar.Text9.Text = (oku["ÇözünürlükStandartı"]).ToString();
                dizustubilgisayar.Text10.Text = (oku["Renk"]).ToString();
                dizustubilgisayar.Text11.Text = (oku["Bağlantılar"]).ToString();
                dizustubilgisayar.Text12.Text = (oku["Klavye"]).ToString();
                dizustubilgisayar.Text13.Text = (oku["İşlemcÇekirdekSayısı"]).ToString();
                dizustubilgisayar.Text14.Text = (oku["SSDKapasitesi"]).ToString();
                dizustubilgisayar.Text15.Text = (oku["Çözünürlük"]).ToString();
                dizustubilgisayar.Text16.Text = (oku["Ram"]).ToString();
                dizustubilgisayar.Text17.Text = (oku["KullanımAmacı"]).ToString();
                dizustubilgisayar.Text18.Text = (oku["ŞarjlıKullanımSüresi"]).ToString();
                dizustubilgisayar.Text19.Text = (oku["EkranKartıTipi"]).ToString();
                dizustubilgisayar.Text20.Text = (oku["İşlemciModeli"]).ToString();
                dizustubilgisayar.Text21.Text = (oku["İşlemciNesli"]).ToString();
                dizustubilgisayar.Text22.Text = (oku["hdisk"]).ToString();
                dizustubilgisayar.Text23.Text = (oku["PanelTipi"]).ToString();
                dizustubilgisayar.Text24.Text = (oku["RamTipi"]).ToString();
                dizustubilgisayar.Text25.Text = (oku["OptikSürücüTipi"]).ToString();
                dizustubilgisayar.Text26.Text = (oku["EkranKartıBellekTipi"]).ToString();
                dizustubilgisayar.Text27.Text = (oku["MaksimumİşlemciHızı(GHz)"]).ToString();

            }
            veritabanibaglantisi.conn.Close();
            dizustubilgisayar.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dizustubilgisayar dizustubilgisayar = new Dizustubilgisayar(anaEkran);
            dizustubilgisayar.fotograf1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty454/product/media/images/20220614/15/125590297/117920493/1/1_org_zoom.jpg";
            dizustubilgisayar.fotograf2.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty454/product/media/images/20220614/15/125590297/117920493/4/4_org_zoom.jpg";
            dizustubilgisayar.fotograf3.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty454/product/media/images/20220614/15/125590297/117920493/2/2_org_zoom.jpg";
            dizustubilgisayar.fotograf4.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty453/product/media/images/20220614/15/125590297/117920493/6/6_org_zoom.jpg";


            veritabanibaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='2'", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dizustubilgisayar.label1.Text = (oku["MARKA"]).ToString();
                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                dizustubilgisayar.Text1.Text = (oku["Isletimsistemi"]).ToString();
                dizustubilgisayar.Text2.Text = (oku["Ekranyenilemehizi"]).ToString();
                dizustubilgisayar.Text3.Text = (oku["GarantiTipi"]).ToString();
                dizustubilgisayar.Text4.Text = (oku["CihazAğırlığı"]).ToString();
                dizustubilgisayar.Text5.Text = (oku["EkranKartı"]).ToString();
                dizustubilgisayar.Text6.Text = (oku["EkranBoyutu"]).ToString();
                dizustubilgisayar.Text7.Text = (oku["Kapasite"]).ToString();
                dizustubilgisayar.Text8.Text = (oku["Dokunmatik Ekran"]).ToString();
                dizustubilgisayar.Text9.Text = (oku["ÇözünürlükStandartı"]).ToString();
                dizustubilgisayar.Text10.Text = (oku["Renk"]).ToString();
                dizustubilgisayar.Text11.Text = (oku["Bağlantılar"]).ToString();
                dizustubilgisayar.Text12.Text = (oku["Klavye"]).ToString();
                dizustubilgisayar.Text13.Text = (oku["İşlemcÇekirdekSayısı"]).ToString();
                dizustubilgisayar.Text14.Text = (oku["SSDKapasitesi"]).ToString();
                dizustubilgisayar.Text15.Text = (oku["Çözünürlük"]).ToString();
                dizustubilgisayar.Text16.Text = (oku["Ram"]).ToString();
                dizustubilgisayar.Text17.Text = (oku["KullanımAmacı"]).ToString();
                dizustubilgisayar.Text18.Text = (oku["ŞarjlıKullanımSüresi"]).ToString();
                dizustubilgisayar.Text19.Text = (oku["EkranKartıTipi"]).ToString();
                dizustubilgisayar.Text20.Text = (oku["İşlemciModeli"]).ToString();
                dizustubilgisayar.Text21.Text = (oku["İşlemciNesli"]).ToString();
                dizustubilgisayar.Text22.Text = (oku["hdisk"]).ToString();
                dizustubilgisayar.Text23.Text = (oku["PanelTipi"]).ToString();
                dizustubilgisayar.Text24.Text = (oku["RamTipi"]).ToString();
                dizustubilgisayar.Text25.Text = (oku["OptikSürücüTipi"]).ToString();
                dizustubilgisayar.Text26.Text = (oku["EkranKartıBellekTipi"]).ToString();
                dizustubilgisayar.Text27.Text = (oku["MaksimumİşlemciHızı(GHz)"]).ToString();

            }
            veritabanibaglantisi.conn.Close();
            dizustubilgisayar.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dizustubilgisayar dizustubilgisayar = new Dizustubilgisayar(anaEkran);
            Uye_Girisi uye_Girisi = new Uye_Girisi(anaEkran);


            veritabanibaglantisi.conn.Open();
            dizustubilgisayar.fotograf1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty377/product/media/images/20220329/13/78155622/125641416/2/2_org_zoom.jpg";
            dizustubilgisayar.fotograf2.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty375/product/media/images/20220329/13/78155650/125641416/2/2_org_zoom.jpg";
            dizustubilgisayar.fotograf3.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty376/product/media/images/20220329/13/78155719/125641416/2/2_org_zoom.jpg";
            dizustubilgisayar.fotograf4.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty377/product/media/images/20220329/13/78155770/125641416/2/2_org_zoom.jpg";
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='3'", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dizustubilgisayar.label1.Text = (oku["MARKA"]).ToString();
                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                dizustubilgisayar.Text1.Text = (oku["Isletimsistemi"]).ToString();
                dizustubilgisayar.Text2.Text = (oku["Ekranyenilemehizi"]).ToString();
                dizustubilgisayar.Text3.Text = (oku["GarantiTipi"]).ToString();
                dizustubilgisayar.Text4.Text = (oku["CihazAğırlığı"]).ToString();
                dizustubilgisayar.Text5.Text = (oku["EkranKartı"]).ToString();
                dizustubilgisayar.Text6.Text = (oku["EkranBoyutu"]).ToString();
                dizustubilgisayar.Text7.Text = (oku["Kapasite"]).ToString();
                dizustubilgisayar.Text8.Text = (oku["Dokunmatik Ekran"]).ToString();
                dizustubilgisayar.Text9.Text = (oku["ÇözünürlükStandartı"]).ToString();
                dizustubilgisayar.Text10.Text = (oku["Renk"]).ToString();
                dizustubilgisayar.Text11.Text = (oku["Bağlantılar"]).ToString();
                dizustubilgisayar.Text12.Text = (oku["Klavye"]).ToString();
                dizustubilgisayar.Text13.Text = (oku["İşlemcÇekirdekSayısı"]).ToString();
                dizustubilgisayar.Text14.Text = (oku["SSDKapasitesi"]).ToString();
                dizustubilgisayar.Text15.Text = (oku["Çözünürlük"]).ToString();
                dizustubilgisayar.Text16.Text = (oku["Ram"]).ToString();
                dizustubilgisayar.Text17.Text = (oku["KullanımAmacı"]).ToString();
                dizustubilgisayar.Text18.Text = (oku["ŞarjlıKullanımSüresi"]).ToString();
                dizustubilgisayar.Text19.Text = (oku["EkranKartıTipi"]).ToString();
                dizustubilgisayar.Text20.Text = (oku["İşlemciModeli"]).ToString();
                dizustubilgisayar.Text21.Text = (oku["İşlemciNesli"]).ToString();
                dizustubilgisayar.Text22.Text = (oku["hdisk"]).ToString();
                dizustubilgisayar.Text23.Text = (oku["PanelTipi"]).ToString();
                dizustubilgisayar.Text24.Text = (oku["RamTipi"]).ToString();
                dizustubilgisayar.Text25.Text = (oku["OptikSürücüTipi"]).ToString();
                dizustubilgisayar.Text26.Text = (oku["EkranKartıBellekTipi"]).ToString();
                dizustubilgisayar.Text27.Text = (oku["MaksimumİşlemciHızı(GHz)"]).ToString();

            }
            veritabanibaglantisi.conn.Close();
            dizustubilgisayar.Show();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dizustubilgisayar dizustubilgisayar = new Dizustubilgisayar(anaEkran);

            dizustubilgisayar.fotograf1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty318/product/media/images/20220202/14/41808255/378512354/1/1_org_zoom.jpg";
            dizustubilgisayar.fotograf2.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty320/product/media/images/20220202/14/41808255/378512354/2/2_org_zoom.jpg";
            dizustubilgisayar.fotograf3.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty319/product/media/images/20220202/14/41808255/378512354/3/3_org_zoom.jpg";
            dizustubilgisayar.fotograf4.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty319/product/media/images/20220202/14/41808255/378512354/5/5_org_zoom.jpg";



            veritabanibaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='4'", veritabanibaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                dizustubilgisayar.label1.Text = (oku["MARKA"]).ToString();
                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                dizustubilgisayar.Text1.Text = (oku["Isletimsistemi"]).ToString();
                dizustubilgisayar.Text2.Text = (oku["Ekranyenilemehizi"]).ToString();
                dizustubilgisayar.Text3.Text = (oku["GarantiTipi"]).ToString();
                dizustubilgisayar.Text4.Text = (oku["CihazAğırlığı"]).ToString();
                dizustubilgisayar.Text5.Text = (oku["EkranKartı"]).ToString();
                dizustubilgisayar.Text6.Text = (oku["EkranBoyutu"]).ToString();
                dizustubilgisayar.Text7.Text = (oku["Kapasite"]).ToString();
                dizustubilgisayar.Text8.Text = (oku["Dokunmatik Ekran"]).ToString();
                dizustubilgisayar.Text9.Text = (oku["ÇözünürlükStandartı"]).ToString();
                dizustubilgisayar.Text10.Text = (oku["Renk"]).ToString();
                dizustubilgisayar.Text11.Text = (oku["Bağlantılar"]).ToString();
                dizustubilgisayar.Text12.Text = (oku["Klavye"]).ToString();
                dizustubilgisayar.Text13.Text = (oku["İşlemcÇekirdekSayısı"]).ToString();
                dizustubilgisayar.Text14.Text = (oku["SSDKapasitesi"]).ToString();
                dizustubilgisayar.Text15.Text = (oku["Çözünürlük"]).ToString();
                dizustubilgisayar.Text16.Text = (oku["Ram"]).ToString();
                dizustubilgisayar.Text17.Text = (oku["KullanımAmacı"]).ToString();
                dizustubilgisayar.Text18.Text = (oku["ŞarjlıKullanımSüresi"]).ToString();
                dizustubilgisayar.Text19.Text = (oku["EkranKartıTipi"]).ToString();
                dizustubilgisayar.Text20.Text = (oku["İşlemciModeli"]).ToString();
                dizustubilgisayar.Text21.Text = (oku["İşlemciNesli"]).ToString();
                dizustubilgisayar.Text22.Text = (oku["hdisk"]).ToString();
                dizustubilgisayar.Text23.Text = (oku["PanelTipi"]).ToString();
                dizustubilgisayar.Text24.Text = (oku["RamTipi"]).ToString();
                dizustubilgisayar.Text25.Text = (oku["OptikSürücüTipi"]).ToString();
                dizustubilgisayar.Text26.Text = (oku["EkranKartıBellekTipi"]).ToString();
                dizustubilgisayar.Text27.Text = (oku["MaksimumİşlemciHızı(GHz)"]).ToString();

            }
            veritabanibaglantisi.conn.Close();
            dizustubilgisayar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
