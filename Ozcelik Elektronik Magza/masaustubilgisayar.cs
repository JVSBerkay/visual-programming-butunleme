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
    public partial class masaustubilgisayar : Form
    {
        AnaSayfa anaSayfa=new AnaSayfa();
        MySqlConnection veritabanibaglantisi = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");

        public masaustubilgisayar(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa = anaSayfa;
        }

        private void masaustubilgisayar_Load(object sender, EventArgs e)
        {

        }
    }
}
