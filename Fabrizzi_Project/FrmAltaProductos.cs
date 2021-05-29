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
    public partial class FrmAltaProductos : Form
    {
        public FrmAltaProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaProductos_Load(object sender, EventArgs e)
        {
            cBox_TipoProd.SelectedIndex = 0;
            cBox_Talle.SelectedIndex = 0;
            cBox_Temporada.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
