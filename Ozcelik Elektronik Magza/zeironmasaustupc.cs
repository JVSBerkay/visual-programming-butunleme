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
    public partial class zeironmasaustupc : Form
    {
        MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");
        AnaSayfa anaSayfa = new AnaSayfa();
        public zeironmasaustupc(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa = anaSayfa;
        }

        private void zeironmasaustupc_Load(object sender, EventArgs e)
        {
            veritabanibaglantisi.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM masaustubilgisayar WHERE UrunId='5' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                Text1.Text = (oku["İşletim Sistemi"]).ToString();
                Text2.Text = (oku["EkranYenilemeHızı"]).ToString();
                Text3.Text = (oku["Garanti Tipi"]).ToString();
                Text4.Text = (oku["Cihaz Ağırlığı"]).ToString();
                Text5.Text = (oku["Ekran Kartı"]).ToString();
                Text6.Text = (oku["Ekran Boyutu"]).ToString();
                Text7.Text = (oku["Kapasite"]).ToString();
                Text8.Text = (oku["Beden"]).ToString();
                Text9.Text = (oku["Çözünürlük"]).ToString();
                Text10.Text = (oku["PowerSupply"]).ToString();
                Text11.Text = (oku["Bağlantılar"]).ToString();
                Text12.Text = (oku["Klavye"]).ToString();
                Text13.Text = (oku["İşlemciÇekirdekSayi"]).ToString();
                Text14.Text = (oku["SSD Kapasitesi"]).ToString();
                Text15.Text = (oku["Çözünürlük"]).ToString();
                Text16.Text = (oku["Ram"]).ToString();
                Text17.Text = (oku["Kullanım Amacı"]).ToString();
                Text18.Text = (oku["Garanti Süresi"]).ToString();
                Text19.Text = (oku["Ekran Kartı Tipi"]).ToString();
                Text20.Text = (oku["İşlemci Modeli"]).ToString();
                Text21.Text = (oku["İşlemci Nesli"]).ToString();
                Text22.Text = (oku["Temel İşlemci Hızı (GHz)"]).ToString();
                Text23.Text = (oku["Panel Tipi"]).ToString();
                Text24.Text = (oku["EkranYenilemeHızı"]).ToString();
                Text25.Text = (oku["Garanti Süresi"]).ToString();
                Text26.Text = (oku["Ekran Kartı Bellek Tipi"]).ToString();
                Text27.Text = (oku["İşlemci Frekansı"]).ToString();

            }
            veritabanibaglantisi.Close();

        }

        private void zeironmasaustupc_FormClosed(object sender, FormClosedEventArgs e)
        {
            masaustupc masaustupc= new masaustupc();
            masaustupc.Show();
        }
    }
}
