using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    class varaus
    {
        yhdista yhteys = new yhdista();

        // haetaan varaukset
        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huone_tyypit", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM varaukset", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public bool lisaaVaraus(int hnro, int anro, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `varaukset` (HuoneenNro, AsiakkaanID, alkaenPVM, LoppuenPVM) VALUES (@hno, @ano, @sis, @ulo)";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@ano", MySqlDbType.Int32).Value = anro;
            komento.Parameters.Add("@sis", MySqlDbType.DateTime).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.DateTime).Value = ulos;

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
            catch (Exception e)
            {
                MessageBox.Show("Virhe: " + e);
                return true;
            }
        }

        public bool poistaVaraus(int varausid)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM varaukset WHERE VarausID = @vid";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@vid", MySqlDbType.Int32).Value = varausid;

            yhteys.avaaYhteys();
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

        public DataTable kaikkiVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT `VarausID`, `HuoneenNro`, `AsiakkaanID`, `AlkaenPVM`, `LoppuenPVM` FROM `varaukset`", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(table);

            return table;

        }
    }
}
