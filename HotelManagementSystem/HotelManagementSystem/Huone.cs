using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    // Tällä luokalla hallitaan huoneita
      
    class Huone
    {
        yhdista yhteys = new yhdista();

        //funktio jolla saa listan huonetyypeistä
        public DataTable huoneTyypit()
        {
            MySqlCommand komento = new MySqlCommand("SELECT `ID`, `Tyyppi`, `Hinta` FROM `huone_tyypit`", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(table);

            return table;
        }

    }
}
