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

            HUONE huone = new HUONE();
            private void Huoneet_Load(object sender, EventArgs e)
            {
            taulukkoDG.DataSource = huone.haeHuoneet();
            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

        private void lisaaBT_Click(object sender, EventArgs e)
        {
            huone.lisaaHuone(numeroTB.Text, comboBox1.Text, puhelinTB.Text, comboBox2.Text);
            taulukkoDG.DataSource = huone.haeHuoneet();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            numeroTB.Text = "";
            comboBox1.SelectedIndex = 0;
            puhelinTB.Text = "";
            comboBox2.SelectedIndex = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            if (huone.poistaHuone(int.Parse(idTB.Text)))
            {
                taulukkoDG.DataSource = huone.haeHuoneet();
            }
            else
            {
                MessageBox.Show("Asiakasta ei löydy", "Poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            huone.muokkaaHuonetta(int.Parse(idTB.Text), numeroTB.Text, comboBox1.Text, puhelinTB.Text, comboBox2.Text);
            taulukkoDG.DataSource = huone.haeHuoneet();
        }

        private void taulukkoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /**/
        }

        private void taulukkoDG_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = taulukkoDG.CurrentRow.Cells[0].Value.ToString();
            numeroTB.Text = taulukkoDG.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = taulukkoDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = taulukkoDG.CurrentRow.Cells[3].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

