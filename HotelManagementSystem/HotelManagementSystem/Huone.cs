using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public DataTable tyypillisetHuoneet(int htyyppi)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "SELECT * from huoneet WHERE huonetyyppi = @hty";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;

            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(table);

            return table;
        }

        // lisaa uusi huone -funktio
        public bool lisaaHuone(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO huoneet (huoneNro, huonetyyppi, puhelin, vapaa) VALUES (@hno, @hty, @puh, @vap) ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

            yhteys.avaaYhteys();

            try
            {
                if(komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Virhe" + e.Message);
                return false;
            }
        }

        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }


        public bool muokkaaHuonetta(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `huonetyyppi` = @hty, `puhelin` = @puh, `vapaa` = @vap WHERE huoneNro = @hno";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool poistaHuone(int huonenumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE from huoneet WHERE huoneNro = @hno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.VarChar).Value = huonenumero;

            yhteys.avaaYhteys();

            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
