using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Fabrizzi_Project
{
    public partial class FrmMenuPrincipal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        


        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        


        private void label9_Click(object sender, EventArgs e)
        {
            FrmUsuarios oUsuario = new FrmUsuarios();
            oUsuario.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmRoles oRoles = new frmRoles();
            oRoles.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmProductos  oProductos = new FrmProductos();
            oProductos.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmMatPrima oMatPrima = new frmMatPrima();
            oMatPrima.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmProveedor oProveedor = new frmProveedor();
            oProveedor.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmLocal oLocal = new frmLocal();
            oLocal.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmPedidos oPedidos = new frmPedidos();
            oPedidos.Show();
        }
    }
}
