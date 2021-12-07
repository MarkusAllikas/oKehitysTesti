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
    
    public partial class Huoneet : Form
        {
            public Huoneet()
            {
                InitializeComponent();
            }

            Huone huone = new Huone();
            private void Huoneet_Load(object sender, EventArgs e)
            {
            huoneetDG.DataSource = huone.haeHuoneet();
            tyyppiCB.DataSource = huone.huoneTyypit();
            tyyppiCB.DisplayMember = "Tyyppi";
            tyyppiCB.ValueMember = "ID";
        }

        private void lisaaBT_Click(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(numeroTB.Text.ToString());
            int huonetyyppi = Convert.ToInt32(tyyppiCB.SelectedValue.ToString());
            String puhelin = puhelinTB.Text;

            if (huone.lisaaHuone(huonenro, huonetyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("huone lisätty", "Huoneen lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen lisääminen epäonnistui", "Huoneen lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            huoneetDG.DataSource = huone.haeHuoneet();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            numeroTB.Text = "";
            tyyppiCB.SelectedIndex = 0;
            puhelinTB.Text = "";
            kyllaRB.Checked = false;
            eiRB.Checked = false;
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(numeroTB.Text);

                if (huone.poistaHuone(numero))
                {
                    MessageBox.Show("Huone poistettu", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    huoneetDG.DataSource = huone.haeHuoneet();
                }
                else
                {
                    MessageBox.Show("Huonetta ei löydy", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tyhjennaBT.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe " + ex.Message, "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            string vapaa = "";
            string puhelin = puhelinTB.Text;
            int tyyppi = Convert.ToInt32(tyyppiCB.SelectedValue.ToString());

            try
            {
                int numero = Convert.ToInt32(numeroTB.Text);

                if (kyllaRB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                }

                if (huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    huoneetDG.DataSource = huone.haeHuoneet();
                }
                else
                {
                    MessageBox.Show("Muokkaus epäonnistui", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe " + ex.Message, "Huoneen muokkaaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void taulukkoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /**/
        }

        private void taulukkoDG_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            numeroTB.Text = huoneetDG.CurrentRow.Cells[0].Value.ToString();
            tyyppiCB.Text = huoneetDG.CurrentRow.Cells[1].Value.ToString();
            puhelinTB.Text = huoneetDG.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

