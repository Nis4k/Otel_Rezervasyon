using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NypProjeSon.DAL
{
    class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = 
            new MySqlConnection("Server=172.21.54.253;Database=25_132330039;User=25_132330039;Password=!nif.ogr39AK");
            baglanti.Open();
            return baglanti;
        }
    }
}
