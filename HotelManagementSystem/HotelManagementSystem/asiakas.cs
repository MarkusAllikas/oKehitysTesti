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
    class asiakas
    {
        yhdista yhteys = new yhdista();

        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String toimipaikka, String kayttaja, String salasana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT into asiakkaat " + "(kayttajatunnus, Etunimi, Sukunimi, lahiosoite, postinumero, postitoimipaikka, salasana) " +
                "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa);";

            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = toimipaikka;

            if(kayttaja != "")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if(salasana != "")
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasana;
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = "xcxcRT6!@";
            }

      

            yhteys.avaaYhteys();

            //testaa onko true ilman että ohjelma kaatuu
            try
            {
                komento.ExecuteNonQuery();
                MessageBox.Show("Asiakas lisätty", "Asiakas lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yhteys.suljeYhteys();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Käyttäjätunnus käytössä", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // HUOM! lisäsin omaan asiakka<t tietokantaan asiakasID tablen ja siihen Auto increment,
        // jotta varaustenhallinnassa asiakkaita ja varauksia voi hallita ID:n avulla.

        public DataTable asiakaslista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT `asiakasID`, `kayttajatunnus` FROM `asiakkaat`", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(table);

            return table;
        }

        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, kayttajatunnus FROM asiakkaat", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE from asiakkaat WHERE kayttajatunnus = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

            yhteys.avaaYhteys();

            //tarpeeton try-catch mutta toimii
            try
            {
                komento.ExecuteNonQuery();
                MessageBox.Show("Asiakas poistettu", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yhteys.suljeYhteys();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Asiakasta ei löydy", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String pnro, String toimipaikka, String kayttaja)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `Etunimi` = @enm, `Sukunimi` =@snm, `lahiosoite` = @oso, `postinumero` = @pno, `postitoimipaikka` = @ptp WHERE kayttajatunnus = @ktu";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = toimipaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja;

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
    }
}
