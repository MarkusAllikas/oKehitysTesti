using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Huoneet : Form
    {
        public Huoneet()
        {
            InitializeComponent();
        }

        private void numeroTB_TextChanged(object sender, EventArgs e)
        {

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
    }
}
