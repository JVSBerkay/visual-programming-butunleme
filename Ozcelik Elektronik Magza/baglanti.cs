using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozcelik_Elektronik_Magza
{
    public class baglanti
    {
        public MySqlConnection conn = new MySqlConnection("server=localhost; uid=root; pwd=; database=elektronik");
    }
}
