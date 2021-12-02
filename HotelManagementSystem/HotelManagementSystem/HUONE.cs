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
    class HUONE
    {
        yhdista yhteys = new yhdista();

        public bool lisaaHuone(string numero, string tyyppi, string puhelin, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO huoneet (numero, tyyppi, puhelin, vapaa) VALUES (@nro,@tpi,@puh,@vpa);";

            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@nro", MySqlDbType.VarChar).Value = numero;
            komento.Parameters.Add("@tpi", MySqlDbType.VarChar).Value = tyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vpa", MySqlDbType.VarChar).Value = vapaa;

            yhteys.avaaYhteys();
            try
            {
                komento.ExecuteNonQuery();
                MessageBox.Show("Huone lisätty", "Huone lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yhteys.suljeYhteys();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Virhe huoneen lisäyksessä", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT id, numero, tyyppi, puhelin, vapaa FROM huoneet", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
        public bool muokkaaHuonetta(int id, String numero, String tyyppi, String puhelin, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `numero` = @nro, `tyyppi` = @tpi, `puhelin` = @puh, `vapaa` = @vpa WHERE ID = @id";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
            komento.Parameters.Add("@nro", MySqlDbType.VarChar).Value = numero;
            komento.Parameters.Add("@tpi", MySqlDbType.VarChar).Value = tyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vpa", MySqlDbType.VarChar).Value = vapaa;

            yhteys.avaaYhteys();
            try
            {
                komento.ExecuteNonQuery();
                MessageBox.Show("Huone muokattu", "Huoneen muokkaaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yhteys.suljeYhteys();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Huoneen muokkaaminen epäonnistui", "Huoneen muokkaaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool poistaHuone(int id)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE from huoneet WHERE id = @id";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            yhteys.avaaYhteys();
            try
            {
                komento.ExecuteNonQuery();
                MessageBox.Show("Huone poistettu", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yhteys.suljeYhteys();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Huonetta ei löydy", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
 }

