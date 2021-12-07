using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class Varaukset : Form
    {

        varaus varaukset = new varaus();
        public Varaukset()
        {
            InitializeComponent();
        }

        private void lisaaBT_Click(object sender, EventArgs e)
        {
            // lisataan uusi asiakas tietokantaan jos virheitä syöttökentissä ei ilmene
            int asiakas = Convert.ToInt32(asiakasCB.SelectedValue.ToString());
            int huonenro = Convert.ToInt32(hnroCB.SelectedValue.ToString());
            DateTime sisaankirjauduttu = Convert.ToDateTime(sisaanDT.Value);
            DateTime uloskirjauduttu = Convert.ToDateTime(sisaanDT.Value);

            if (varaukset.lisaaVaraus(huonenro, asiakas, sisaankirjauduttu, uloskirjauduttu))
            {
                MessageBox.Show("Lisätty", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lisäys ei onnistunut", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            varauksetDG.DataSource = varaukset.haeVaraukset();
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            // tuodaan varaukset ikkunan ladattua
            varauksetDG.DataSource = varaukset.haeVaraukset();
        }

        private void asiakasCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Näyttää kaikki varaukset
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
