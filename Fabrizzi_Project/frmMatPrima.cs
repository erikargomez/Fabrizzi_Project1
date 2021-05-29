using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrizzi_Project
{
    public partial class frmMatPrima : Form
    {
        public frmMatPrima()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmAltaMatPrima oAltaMatPrima = new frmAltaMatPrima();
            oAltaMatPrima.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmActualizarMatPrima oActualizarMatPrima = new frmActualizarMatPrima();
            oActualizarMatPrima.Show();
        }
    }
}
