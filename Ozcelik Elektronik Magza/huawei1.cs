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
    public partial class huawei1 : Form
    {
        MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");
        AnaSayfa anaSayfa = new AnaSayfa();
        public huawei1(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa = anaSayfa;
        }

        private void huawei1_Load(object sender, EventArgs e)
        {
            veritabanibaglantisi.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM laptoplar WHERE UrunId='4' ", veritabanibaglantisi);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                label28.Text = (oku["MARKA"]).ToString();
                //richTextBox1.Text = (oku["UrunOzellikleri"]).ToString();
                Text1.Text = (oku["Isletimsistemi"]).ToString();
                Text2.Text = (oku["Ekranyenilemehizi"]).ToString();
                Text3.Text = (oku["GarantiTipi"]).ToString();
                Text4.Text = (oku["CihazAğırlığı"]).ToString();
                Text5.Text = (oku["EkranKartı"]).ToString();
                Text6.Text = (oku["EkranBoyutu"]).ToString();
                Text7.Text = (oku["Kapasite"]).ToString();
                Text8.Text = (oku["Dokunmatik Ekran"]).ToString();
                Text9.Text = (oku["ÇözünürlükStandartı"]).ToString();
                Text10.Text = (oku["Renk"]).ToString();
                Text11.Text = (oku["Bağlantılar"]).ToString();
                Text12.Text = (oku["Klavye"]).ToString();
                Text13.Text = (oku["İşlemcÇekirdekSayısı"]).ToString();
                Text14.Text = (oku["SSDKapasitesi"]).ToString();
                Text15.Text = (oku["Çözünürlük"]).ToString();
                Text16.Text = (oku["Ram"]).ToString();
                Text17.Text = (oku["KullanımAmacı"]).ToString();
                Text18.Text = (oku["ŞarjlıKullanımSüresi"]).ToString();
                Text19.Text = (oku["EkranKartıTipi"]).ToString();
                Text20.Text = (oku["İşlemciModeli"]).ToString();
                Text21.Text = (oku["İşlemciNesli"]).ToString();
                Text22.Text = (oku["hdisk"]).ToString();
                Text23.Text = (oku["PanelTipi"]).ToString();
                Text24.Text = (oku["RamTipi"]).ToString();
                Text25.Text = (oku["OptikSürücüTipi"]).ToString();
                Text26.Text = (oku["EkranKartıBellekTipi"]).ToString();
                Text27.Text = (oku["MaksimumİşlemciHızı(GHz)"]).ToString();

            }
            veritabanibaglantisi.Close();

        }
    }
}
