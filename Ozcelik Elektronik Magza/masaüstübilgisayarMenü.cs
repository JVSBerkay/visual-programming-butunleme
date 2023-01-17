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
using static System.Net.Mime.MediaTypeNames;

namespace Ozcelik_Elektronik_Magza
{
    public partial class masaüstübilgisayarMenü : Form
    {
      
        

        AnaSayfa anaSayfa = new AnaSayfa();
        public masaüstübilgisayarMenü(AnaSayfa anaSayfa)
        {
            InitializeComponent();
             this.anaSayfa= anaSayfa;
            
        }
        baglanti veritabanbaglantisi = new baglanti();
        #region bilgisayarlar
        public void zeironpc() {
            veritabanbaglantisi.conn.Open();


            MySqlCommand komut = new MySqlCommand("SELECT * FROM masaustubilgisayar WHERE UrunId='5' ", veritabanbaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = (oku["Ozellikler"]).ToString();
                label2.Text = (oku["Fiyat"] + " TL");
                label1.Text = ("" + oku["MARKA"]);
            }
            veritabanbaglantisi.conn.Close();

        }
        public void gamepagepc() {
            veritabanbaglantisi.conn.Open();


            MySqlCommand komut = new MySqlCommand("SELECT * FROM masaustubilgisayar WHERE UrunId='6' ", veritabanbaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox2.Text = (oku["Ozellikler"]).ToString();
                label3.Text = (oku["Fiyat"] + " TL");
                label4.Text = ("" + oku["MARKA"]);
            }
            veritabanbaglantisi.conn.Close();
        }
        #endregion
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void masaustupc_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty516/product/media/images/20220825/12/165396319/462103942/1/1_org_zoom.jpg";
            pictureBox2.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty554/product/media/images/20221005/10/186370207/462100340/1/1_org_zoom.jpg";
            zeironpc();
            gamepagepc();
        }
        #region bilgisayar ozellikleri
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            masaustubilgisayar pc = new masaustubilgisayar(anaSayfa);

            pc.pictureBox1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty554/product/media/images/20221005/10/186370207/462100340/1/1_org_zoom.jpg";
            pc.pictureBox2.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty552/product/media/images/20221005/10/186370207/462100340/2/2_org_zoom.jpg";
            pc.pictureBox3.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty552/product/media/images/20221005/10/186370207/462100340/5/5_org_zoom.jpg";
            pc.pictureBox4.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty553/product/media/images/20221005/10/186370207/462100340/7/7_org_zoom.jpg";


            veritabanbaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM masaustubilgisayar WHERE UrunId='5' ", veritabanbaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pc.label28.Text = (oku["MARKA"]).ToString() ;
                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                pc.Text1.Text = (oku["İşletim Sistemi"]).ToString();
                pc.Text2.Text = (oku["EkranYenilemeHızı"]).ToString();
                pc.Text3.Text = (oku["Garanti Tipi"]).ToString();
                pc.Text4.Text = (oku["Cihaz Ağırlığı"]).ToString();
                pc.Text5.Text = (oku["Ekran Kartı"]).ToString();
                pc.Text6.Text = (oku["Ekran Boyutu"]).ToString();
                pc.Text7.Text = (oku["Kapasite"]).ToString();
                pc.Text8.Text = (oku["Beden"]).ToString();
                pc.Text9.Text = (oku["Çözünürlük"]).ToString();
                pc.Text10.Text = (oku["PowerSupply"]).ToString();
                pc.Text11.Text = (oku["Bağlantılar"]).ToString();
                pc.Text12.Text = (oku["Klavye"]).ToString();
                pc.Text13.Text = (oku["İşlemciÇekirdekSayi"]).ToString();
                pc.Text14.Text = (oku["SSD Kapasitesi"]).ToString();
                pc.Text15.Text = (oku["Çözünürlük"]).ToString();
                pc.Text16.Text = (oku["Ram"]).ToString();
                pc.Text17.Text = (oku["Kullanım Amacı"]).ToString();
                pc.Text18.Text = (oku["Garanti Süresi"]).ToString();
                pc.Text19.Text = (oku["Ekran Kartı Tipi"]).ToString();
                pc.Text20.Text = (oku["İşlemci Modeli"]).ToString();
                pc.Text21.Text = (oku["İşlemci Nesli"]).ToString();
                pc.Text22.Text = (oku["Temel İşlemci Hızı (GHz)"]).ToString();
                pc.Text23.Text = (oku["Panel Tipi"]).ToString();
                pc.Text24.Text = (oku["EkranYenilemeHızı"]).ToString();
                pc.Text25.Text = (oku["Garanti Süresi"]).ToString();
                pc.Text26.Text = (oku["Ekran Kartı Bellek Tipi"]).ToString();
                pc.Text27.Text = (oku["İşlemci Frekansı"]).ToString();

            }
            veritabanbaglantisi.conn.Close();
            pc.Show();

        }

        private void masaustupc_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaSayfa.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            masaustubilgisayar pc = new masaustubilgisayar(anaSayfa);

            pc.pictureBox1.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty516/product/media/images/20220825/12/165396319/462103942/1/1_org_zoom.jpg";
            pc.pictureBox2.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty502/product/media/images/20220810/19/157607776/462103942/3/3_org_zoom.jpg";
            pc.pictureBox3.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty502/product/media/images/20220810/19/157607776/462103942/4/4_org_zoom.jpg";
            pc.pictureBox4.ImageLocation = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty503/product/media/images/20220810/19/157607776/462103942/5/5_org_zoom.jpg";


            veritabanbaglantisi.conn.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM masaustubilgisayar WHERE UrunId='6' ", veritabanbaglantisi.conn);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pc.label28.Text = (oku["MARKA"]).ToString();

                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                pc.Text1.Text = (oku["İşletim Sistemi"]).ToString();
                pc.Text2.Text = (oku["EkranYenilemeHızı"]).ToString();
                pc.Text3.Text = (oku["Garanti Tipi"]).ToString();
                pc.Text4.Text = (oku["Cihaz Ağırlığı"]).ToString();
                pc.Text5.Text = (oku["Ekran Kartı"]).ToString();
                pc.Text6.Text = (oku["Ekran Boyutu"]).ToString();
                pc.Text7.Text = (oku["Kapasite"]).ToString();
                pc.Text8.Text = (oku["Beden"]).ToString();
                pc.Text9.Text = (oku["Çözünürlük"]).ToString();
                pc.Text10.Text = (oku["PowerSupply"]).ToString();
                pc.Text11.Text = (oku["Bağlantılar"]).ToString();
                pc.Text12.Text = (oku["Klavye"]).ToString();
                pc.Text13.Text = (oku["İşlemciÇekirdekSayi"]).ToString();
                pc.Text14.Text = (oku["SSD Kapasitesi"]).ToString();
                pc.Text15.Text = (oku["Çözünürlük"]).ToString();
                pc.Text16.Text = (oku["Ram"]).ToString();
                pc.Text17.Text = (oku["Kullanım Amacı"]).ToString();
                pc.Text18.Text = (oku["Garanti Süresi"]).ToString();
                pc.Text19.Text = (oku["Ekran Kartı Tipi"]).ToString();
                pc.Text20.Text = (oku["İşlemci Modeli"]).ToString();
                pc.Text21.Text = (oku["İşlemci Nesli"]).ToString();
                pc.Text22.Text = (oku["Temel İşlemci Hızı (GHz)"]).ToString();
                pc.Text23.Text = (oku["Panel Tipi"]).ToString();
                pc.Text24.Text = (oku["EkranYenilemeHızı"]).ToString();
                pc.Text25.Text = (oku["Garanti Süresi"]).ToString();
                pc.Text26.Text = (oku["Ekran Kartı Bellek Tipi"]).ToString();
                pc.Text27.Text = (oku["İşlemci Frekansı"]).ToString();

            }
            veritabanbaglantisi.conn.Close();
            pc.Show();
        }
        #endregion
        private void masaüstüBilgisayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anaSayfa.Show();
            this.Close();
                
       }

        private void dizustuBilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DizüstübilgisayarMenü dizüstübilgisayar = new DizüstübilgisayarMenü(anaSayfa);
            dizüstübilgisayar.Show();
            this.Close();
        }
    }
}
