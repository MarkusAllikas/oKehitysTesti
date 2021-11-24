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
    public partial class Kirjautuminen : Form
    {
        public Kirjautuminen()
        {
            InitializeComponent();
        }

        private void Kirjautuminen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            yhdista tietokantaan = new yhdista();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();

            String kysely = "SELECT kayttajatunnus, salasana FROM asiakkaat WHERE kayttajatunnus = @kt AND salasana = @ss";
            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteys();

            komento.Parameters.Add("@kt", MySqlDbType.VarChar).Value = KayttajaTunnusTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            //tarkistetaan löytyykö käyttäjätunnus ja salasana tietokannasta
            if(taulu.Rows.Count > 0)
            {
                //piilotetaan kirjautumisikkuna
                this.Hide();
                //tuodaan pääikkuna esille
                Paaikkuna plomake = new Paaikkuna();
                plomake.Show();
            }
            else
            {
                if(KayttajaTunnusTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tarkista käyttäjätunnus", "Virhe kirjautuessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(SalasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tarkista salasana", "Virhe kirjautuessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Virhe kirjautuessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
