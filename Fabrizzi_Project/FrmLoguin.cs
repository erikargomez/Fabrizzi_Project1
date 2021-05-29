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
    public partial class FrmLoguin : Form
    {
        public FrmLoguin()
        {
            InitializeComponent();
        }
        
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var usu = new LoginMetodo();
            var usuario = tBox_Usuario.Text;
            var pas = tBox_Contrasenia.Text;
            dt = usu.ConsultarLogin(usuario, pas);

            if (dt.Rows.Count == 1)
            {
                var frmPrin = new FrmMenuPrincipal();
                dt = usu.consultaNombre(usuario);
                if (dt.Rows.Count >0)
                {
                    DataRow row = dt.Rows[0];
                    frmPrin.lbl_Usuario.Text = Convert.ToString(row[0]);
                 
                }
                
                frmPrin.lbl_Legajo.Text = usuario;
                frmPrin.lbl_Fecha.Text = DateTime.Now.ToShortDateString();
                this.Hide();
                frmPrin.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
            //FrmMenuPrincipal oMenuPrincipal = new FrmMenuPrincipal();
            //oMenuPrincipal.Show();
         

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContraseña oRecuperarContraseña = new frmRecuperarContraseña();
            oRecuperarContraseña.Show();
        }
    }
}
