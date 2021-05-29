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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmNuevoPedido oNuevoPedido = new frmNuevoPedido();
            oNuevoPedido.Show();
        }
    }
}
