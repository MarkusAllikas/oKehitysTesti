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
    public partial class Asiakkaat : Form
    {
        asiakas Asiakas = new asiakas();
        public Asiakkaat()
        {
            InitializeComponent();
        }

        private void lisaaBT_Click(object sender, EventArgs e)
        {
            Asiakas.lisaaAsiakas(nimiTB.Text, sNimiTB.Text, osoiteTB.Text, postinroTB.Text, toimipaikkaTB.Text, ktunnusTB.Text, salasanaTB.Text);
            taulukkoDG.DataSource = Asiakas.haeAsiakkaat();

        }

        //päivittää asiakastaulun ladatessa ikkunan
        private void Asiakkaat_Load(object sender, EventArgs e)
        {
            taulukkoDG.DataSource = Asiakas.haeAsiakkaat();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            //on true jos kaikki kentät on täytetty
            if(Asiakas.poistaAsiakas(ktunnusTB.Text))
            {
                taulukkoDG.DataSource = Asiakas.haeAsiakkaat();
            }
            else
            {
                MessageBox.Show("Asiakasta ei löydy", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void taulukkoDG_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            nimiTB.Text = taulukkoDG.CurrentRow.Cells[0].Value.ToString();
            sNimiTB.Text = taulukkoDG.CurrentRow.Cells[1].Value.ToString();
            osoiteTB.Text = taulukkoDG.CurrentRow.Cells[2].Value.ToString();
            postinroTB.Text = taulukkoDG.CurrentRow.Cells[3].Value.ToString();
            toimipaikkaTB.Text = taulukkoDG.CurrentRow.Cells[4].Value.ToString();
            ktunnusTB.Text = taulukkoDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            nimiTB.Text = "";
            sNimiTB.Text = "";
            osoiteTB.Text = "";
            postinroTB.Text = "";
            toimipaikkaTB.Text = "";
            ktunnusTB.Text = "";
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            Boolean muokkaaAsiakas = Asiakas.muokkaaAsiakasta(nimiTB.Text, sNimiTB.Text, osoiteTB.Text, postinroTB.Text, toimipaikkaTB.Text, ktunnusTB.Text);
            if(muokkaaAsiakas)
            {
                MessageBox.Show("Asiakastiedot päivitetty", "Muokkaa asiakasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taulukkoDG.DataSource = Asiakas.haeAsiakkaat();
            }
            else
            {
                MessageBox.Show("Asiakkaan päivitys epäonnistui", "Muokkaa asiakasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
