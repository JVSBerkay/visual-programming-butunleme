using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ozcelik_Elektronik_Magza
{
    public partial class adminpaneli : Form
    {
        MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");
        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        MySqlDataAdapter dataAdapter;
        DataTable tablo=new DataTable();
        AnaSayfa anaSayfa = new AnaSayfa();
        public adminpaneli(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa=anaSayfa;
        }

         DataTable laptoplarGETIR()
        {
            dataAdapter = new MySqlDataAdapter("SELECT * from laptoplar", veritabanibaglantisi);

            dataAdapter.Fill(tablo);

            dataGridView1.DataSource = tablo;
            return tablo;
        }
        DataTable MasaustuGETIR()
        {
           dataAdapter = new MySqlDataAdapter("SELECT * from masaustubilgisayar", veritabanibaglantisi);

           

            dataAdapter.Fill(tablo);

           dataGridView1.DataSource = tablo;
            return tablo;
        }

       
        private void adminpaneli_Load(object sender, EventArgs e)
        {
        
            laptoplarGETIR();
            MasaustuGETIR();
        }


        private void button1_Click(object sender, EventArgs e)
        {




            /*
            commandBuilder= new MySqlCommandBuilder();
            dataAdapter.Update(k);
            MessageBox.Show("islem basarili");
            */
/*
                      veritabanibaglantisi.Open();

            string Marka = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            string UrunId = dataGridView1.CurrentRow.Cells["UrunId"].Value.ToString();
            string UrunOzellikleri = dataGridView1.CurrentRow.Cells["UrunOzellikleri"].Value.ToString();
            string IsletimSistemi = dataGridView1.CurrentRow.Cells["Isletimsistemi"].Value.ToString();
            string EkranyenilemeHizi = dataGridView1.CurrentRow.Cells["Ekranyenilemehizi"].Value.ToString();
            string GarantiTipi = dataGridView1.CurrentRow.Cells["GarantiTipi"].Value.ToString();
            string CihazAgirligi = dataGridView1.CurrentRow.Cells["CihazAğırlığı"].Value.ToString();
            string EkranKarti = dataGridView1.CurrentRow.Cells["EkranKartı"].Value.ToString();
            string EkranKartiHafizasi = dataGridView1.CurrentRow.Cells["EkranKartıHafızası"].Value.ToString();
            string EkranBoyutu = dataGridView1.CurrentRow.Cells["EkranBoyutu"].Value.ToString();
            string Kapasite = dataGridView1.CurrentRow.Cells["Kapasite"].Value.ToString();
            string DokunmatikEkran = dataGridView1.CurrentRow.Cells["Dokunmatik Ekran"].Value.ToString();
            string Cozunurlukstandarti = dataGridView1.CurrentRow.Cells["ÇözünürlükStandartı"].Value.ToString();
            string Renk = dataGridView1.CurrentRow.Cells["Renk"].Value.ToString();
            string Baglantilar = dataGridView1.CurrentRow.Cells["Bağlantılar"].Value.ToString();
            string Klavye = dataGridView1.CurrentRow.Cells["Klavye"].Value.ToString();
            string islemcicekirdek = dataGridView1.CurrentRow.Cells["İşlemcÇekirdekSayısı"].Value.ToString();
            string SSDKapasitesi = dataGridView1.CurrentRow.Cells["SSDKapasitesi"].Value.ToString();
            string Cozunurluk = dataGridView1.CurrentRow.Cells["Çözünürlük"].Value.ToString();
            string Ram = dataGridView1.CurrentRow.Cells["Ram"].Value.ToString();
            string Kullanimamaci = dataGridView1.CurrentRow.Cells["KullanımAmacı"].Value.ToString();
            string Sarjlikullanimsuresi = dataGridView1.CurrentRow.Cells["ŞarjlıKullanımSüresi"].Value.ToString();
            string EkranKartiTipi = dataGridView1.CurrentRow.Cells["EkranKartıTipi"].Value.ToString();
            string islemciModeli = dataGridView1.CurrentRow.Cells["İşlemciModeli"].Value.ToString();
            string IslemciNEsli = dataGridView1.CurrentRow.Cells["İşlemciNesli"].Value.ToString();
            string hdsik = dataGridView1.CurrentRow.Cells["hdisk"].Value.ToString();
            string paneltipi = dataGridView1.CurrentRow.Cells["PanelTipi"].Value.ToString();
            string Ramtipi = dataGridView1.CurrentRow.Cells["RamTipi"].Value.ToString();
            string OptiksurucuTipi = dataGridView1.CurrentRow.Cells["OptikSürücüTipi"].Value.ToString();
            string ekrankartibellektipi = dataGridView1.CurrentRow.Cells["EkranKartıBellekTipi"].Value.ToString();
            string MaksimumislemciHizi = dataGridView1.CurrentRow.Cells["MaksimumİşlemciHızı(GHz)"].Value.ToString();
            string fiyat = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();


            MySqlCommand komut = new MySqlCommand("UPDATE laptoplar SET Marka='"+Marka+ "'" +
                ", UrunId='"+UrunId+"'" +
                ",UrunOzellikleri='"+UrunOzellikleri+"'" +
                ",Isletimsistemi='" + IsletimSistemi+ "'" +
                ",Ekranyenilemehizi='"+EkranyenilemeHizi+"'" +
                ",GarantiTipi='"+GarantiTipi+ "'" +
                ",CihazAğırlığı='"+CihazAgirligi+"'" +
                ",EkranKartı='"+EkranKarti+ "'" +
                ",EkranKartıHafızası='"+EkranKartiHafizasi+"'" +
                ",EkranBoyutu='"+EkranBoyutu+"'" +
                ",Kapasite='"+Kapasite+"'" +
                ",Dokunmatik Ekran='"+DokunmatikEkran+"'" +
                ",ÇözünürlükStandartı='"+Cozunurlukstandarti+"'" +
                ",Renk='"+Renk+"',Bağlantılar='"+Baglantilar+ "'" +
                ",Klavye='"+Baglantilar+"',Klavye='"+Klavye+"'" +
                ",İşlemcÇekirdekSayısı='"+islemcicekirdek+ "'" +
                ",SSDKapasitesi='"+SSDKapasitesi+ "'" +
                ",Çözünürlük='"+Cozunurluk+"'" +
                ",Ram='"+Ram+ "'" +
                ",KullanımAmacı='"+Kullanimamaci+"'" +
                ",ŞarjlıKullanımSüresi='"+Sarjlikullanimsuresi+ "'" +
                ",EkranKartıTipi='"+EkranKartiTipi+ "'" +
                ",işlemciModeli='"+islemciModeli+ "'" +
                ",İşlemciNesli='"+IslemciNEsli+"'" +
                ",hdisk='"+hdsik+"'" +
                ",PanelTipi='"+paneltipi+"'" +
                ",RamTipi='"+Ramtipi+ "'" +
                ",OptikSürücüTipi='"+OptiksurucuTipi+ "'" +
                ",EkranKartıBellekTipi='"+ekrankartibellektipi+ "'" +
                ",MaksimumİşlemciHızı(GHz)='"+MaksimumislemciHizi+"'" +
                ",Fiyat='"+fiyat+"'");

            komut.ExecuteNonQuery();
           
            veritabanibaglantisi.Close();
            
            MessageBox.Show("IslemBasarili");
            
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
             anaSayfa.islempaneli.Controls.Clear();
            ekleme ekleme1 = new ekleme(anaSayfa);
            ekleme1.TopLevel = false;
            anaSayfa.islempaneli.Controls.Add(ekleme1);
            ekleme1.Show();
            ekleme1.Dock = DockStyle.Fill;
            ekleme1.BringToFront();
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult uyar;

            uyar = MessageBox.Show(this, textBox1.Text + " Urunu Silmek istediginize Emin Misiniz?", "SİLME UYARISI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (uyar == DialogResult.Yes)

            {
                int n = Convert.ToInt16(textBox1.Text);
                veritabanibaglantisi.Open();
                string sil = "DELETE FROM laptoplar " + "Where UrunId = '" + n + "'";
                MySqlCommand komut = new MySqlCommand(sil, veritabanibaglantisi);
                komut.ExecuteNonQuery();
                veritabanibaglantisi.Close();

                MessageBox.Show("Kayıt  silindi");

                try
                {
                    MySqlDataAdapter adaptor = new MySqlDataAdapter("Select * from laptoplar", veritabanibaglantisi);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adaptor.Fill(ds, "laptoplar");
                    dataGridView1.DataSource = ds.Tables["laptoplar"];
                    adaptor.Dispose();
                }
                catch
                {
                    return;
                }
            }
        }
    }
    }


 

