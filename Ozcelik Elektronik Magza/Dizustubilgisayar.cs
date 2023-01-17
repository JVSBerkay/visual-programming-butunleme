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
    public partial class Dizustubilgisayar : Form
    {
        AnaSayfa anaSayfa=new AnaSayfa();
        public Dizustubilgisayar(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            this.anaSayfa= anaSayfa;
        }

        private void Dizustubilgisayar_Load(object sender, EventArgs e)
        {
            //202151502016
        }
    }
}
