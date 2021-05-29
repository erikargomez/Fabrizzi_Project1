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
    public partial class frmAltaMatPrima : Form
    {
        public frmAltaMatPrima()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmConsultaMatPrima oConsultaMatPrima = new frmConsultaMatPrima();
            oConsultaMatPrima.Show();

        }

        private void frmAltaMatPrima_Load(object sender, EventArgs e)
        {
            cBox_TipoMatPri.SelectedIndex = 0;
        }
    }
}
