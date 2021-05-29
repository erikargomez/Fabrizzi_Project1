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
    public partial class frmModificarProd : Form
    {
        public frmModificarProd()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmActualizarCantidadProd ofrmActualizarCantidadProd = new frmActualizarCantidadProd();
            ofrmActualizarCantidadProd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmActualizarEstadoProd ofrmActualizarEstadoProd = new frmActualizarEstadoProd();
            ofrmActualizarEstadoProd.Show();
        }
    }
}
