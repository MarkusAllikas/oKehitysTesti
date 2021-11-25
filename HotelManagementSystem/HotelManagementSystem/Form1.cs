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
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        private void Paaikkuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void asiakkaitenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakkaat asiakkaat = new Asiakkaat();
            asiakkaat.Show();
        }

        private void varaustenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset varaukset = new Varaukset();
            varaukset.Show();
        }

        private void huoneidenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huoneet huoneet = new Huoneet();
            huoneet.Show();
        }
    }
}
