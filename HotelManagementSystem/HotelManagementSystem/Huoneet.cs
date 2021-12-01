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
            tyyppiCB.DataSource = Huone.huoneTyypit();
            tyyppiCB.DisplayMember = "Tyyppi";
            tyyppiCB.ValueMember = "ID";

        }
    }
}
