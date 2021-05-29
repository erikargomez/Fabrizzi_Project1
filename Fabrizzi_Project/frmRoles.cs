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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmAltaRoles oAltaRoles = new frmAltaRoles();
            oAltaRoles.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ModRolUsuario oModrolusuario = new ModRolUsuario();
            oModrolusuario.Show();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            cBox_ArealRolBuscar.SelectedIndex = 0;
            cBox_EstadoRolBuscar.SelectedIndex = 0;
        }

        private void btn_BuscarRol_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var rol = new RolesMetodo();
            String Area = cBox_ArealRolBuscar.SelectedItem.ToString();
            dt = rol.ConsultarPorArea(Area);
            if (dt.Rows.Count != 0)
            {
                Dgv_Roles.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay registros en la seleccion");
            }
        }
    }
    }




    

