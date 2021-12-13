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
        yhdista yhteys = new yhdista();
        Huone huone = new Huone();
        asiakas Asiakkaat = new asiakas();
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
                DateTime uloskirjauduttu = Convert.ToDateTime(ulosDT.Value);

                if (varaukset.lisaaVaraus(huonenro, asiakas, sisaankirjauduttu, uloskirjauduttu))
                {
                    MessageBox.Show("Lisätty", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lisäys ei onnistunut", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                varauksetDG.DataSource = varaukset.kaikkiVaraukset();
            
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            // tuodaan varaukset ikkunan ladattua
            varauksetDG.DataSource = varaukset.kaikkiVaraukset();
            tyyppiCB.DataSource = huone.huoneTyypit();
            tyyppiCB.DisplayMember = "Tyyppi";
            tyyppiCB.ValueMember = "ID";

            //tuodaan asiakkaas comboboxiin pudotusvalikkoon
            asiakasCB.DataSource = Asiakkaat.asiakaslista();
            asiakasCB.DisplayMember = "kayttajatunnus";
            asiakasCB.ValueMember = "asiakasID";
        }

        private void tyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int huonetyyppi = tyyppiCB.SelectedIndex + 1;

            hnroCB.DataSource = huone.tyypillisetHuoneet(huonetyyppi);
            hnroCB.ValueMember = "huoneNro";
            hnroCB.DisplayMember = "huoneNro";
        }

        private void asiakasCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void poistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                int varausID = Convert.ToInt32(vidTB.Text.ToString());
                if(varaukset.poistaVaraus(varausID))
                {
                    varauksetDG.DataSource = varaukset.kaikkiVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Virhe varauksen poistossa", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tyhjennaBT.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe " + ex.Message);
            }
        }

        private void varauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vidTB.Text = varauksetDG.CurrentRow.Cells[0].Value.ToString();
            hnroCB.SelectedValue = varauksetDG.CurrentRow.Cells[1].Value;
            asiakasCB.SelectedValue = varauksetDG.CurrentRow.Cells[2].Value.ToString();
            sisaanDT.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[3].Value);
            ulosDT.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[4].Value);
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            vidTB.Text = "";
            hnroCB.SelectedValue = 0;
            asiakasCB.SelectedValue = 0;
            sisaanDT.Value = DateTime.Now;
            ulosDT.Value = DateTime.Now;
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {

            //Muokkaa varausta
            int varausID = Convert.ToInt32(vidTB.Text);
            int asiakasID = Convert.ToInt32(asiakasCB.Text);
            int huoneNro = Convert.ToInt32(hnroCB.Text);
            //DateTime alkaenPVM = Convert.ToDateTime(sisaanDT.DateTime);
            //DateTime loppuenPVM = Convert.ToDateTime(ulosDT.DateTime);
            // kesken

        }
    }
}
