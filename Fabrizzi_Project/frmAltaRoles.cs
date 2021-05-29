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
    public partial class frmAltaRoles : Form
    {
        public frmAltaRoles()
        {
            InitializeComponent();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaRoles_Load(object sender, EventArgs e)
        {
            cBox_NombreRol.SelectedIndex = 0;
            cBox_AreaRol.SelectedIndex = 0;
        }

        private void btn_GuardarRol_Click(object sender, EventArgs e)
        {
            if (cBox_NombreRol.SelectedIndex != 0)
            {
                if (cBox_AreaRol.SelectedIndex != 0)
                {
                    DialogResult resp = MessageBox.Show("Esta generando un nuevo rol, desea continuar?", "Guardar", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                    var rolNew = new Rol();
                    if ((resp == DialogResult.Yes))
                    {

                        var Permisos = "";
                        if (chBox_Usuarios.Checked)
                        {
                            if (chBox_Usuarios.Checked && chBox_Productos.Checked)
                            {
                                if (chBox_Usuarios.Checked && chBox_Productos.Checked && chBox_Proveedores.Checked)
                                {
                                    if (chBox_Usuarios.Checked && chBox_Productos.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked)
                                    {
                                        if (chBox_Usuarios.Checked && chBox_Productos.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                                        {
                                            Permisos = "Usuarios, Productos, Proveedores, Materias primas, Locales";
                                        }
                                        else Permisos = "Usuarios, Productos, Proveedores, Materias primas";
                                    }
                                    else Permisos = "Usuarios, Productos, Proveedores";

                                }
                                else Permisos = "Usuarios, Productos";

                            }
                            else if (chBox_Usuarios.Checked && chBox_Proveedores.Checked)
                            {
                                if (chBox_Usuarios.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked)
                                {
                                    if (chBox_Usuarios.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                                    {
                                        Permisos = "Usuarios, Proveedores, Materias primas, Locales";
                                    }
                                    else Permisos = "Usuarios, Proveedores, Materias primas";

                                }
                                else Permisos = "Usuarios, Proveedores";
                            }
                            else if (chBox_Usuarios.Checked && chBox_MatPri.Checked)
                            {
                                if (chBox_Usuarios.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                                {
                                    Permisos = "Usuarios, Materias primas, Locales";
                                }
                                else Permisos = "Usuarios, Materias primas";

                            }
                            else if (chBox_Usuarios.Checked && chBox_Locales.Checked)
                            {
                                Permisos = "Usuarios, Locales";
                            }
                            else Permisos = "Usuarios";
                        }
                        else if (chBox_Productos.Checked)
                        {
                            if (chBox_Productos.Checked && chBox_Proveedores.Checked)
                            {
                                if (chBox_Productos.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked)
                                {
                                    if (chBox_Productos.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                                    {
                                        Permisos = "Productos, Proveedores, Materias primas, Locales";

                                    }
                                    else Permisos = "Productos, Proveedores, Materias primas";

                                }
                                else Permisos = "Productos, Proveedores";
                            }
                            else if (chBox_Productos.Checked && chBox_MatPri.Checked)
                            {
                                if (chBox_Productos.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                                {
                                    Permisos = "Productos, Materias primas, Locales";
                                }
                                else Permisos = "Productos, Materias primas";
                            }
                            else if (chBox_Productos.Checked && chBox_Locales.Checked)
                            {
                                Permisos = "Productos, Locales";
                            }
                            else Permisos = "Productos";
                        }
                        else if (chBox_Proveedores.Checked)
                        {
                            if (chBox_Proveedores.Checked && chBox_MatPri.Checked)
                            {
                                if (chBox_Proveedores.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                                {
                                    Permisos = "Proveedores, Materias primas, Locales";
                                }
                                else Permisos = "Proveedores, Materias primas";

                            }
                            else if (chBox_Proveedores.Checked && chBox_Locales.Checked)
                            {
                                Permisos = "Proveedores, Locales";
                            }
                            else Permisos = "Proveedores";
                        }
                        else if (chBox_MatPri.Checked)
                        {
                            if (chBox_MatPri.Checked && chBox_Locales.Checked)
                            {
                                Permisos = "Materias primas, Locales";

                            }
                            else Permisos = "Materias primas";
                        }
                        else if (chBox_Locales.Checked)
                        {
                            Permisos = "Locales";
                        }

                        rolNew.NombreRol = cBox_NombreRol.SelectedItem.ToString();
                        rolNew.DescripcionRol = Permisos;
                        rolNew.Area = cBox_AreaRol.SelectedItem.ToString();
                        var fechaAlta = Convert.ToDateTime(dtp_Fecha.Value.ToString("MM/dd/yyyy")); //dateTimePicker1.Value.ToString("dd/MM/yyyy") dtp_Fecha.Value.ToShortTimeString());
                        rolNew.FechaAlta = fechaAlta.Date;

                        var rolMet = new RolesMetodo();
                        Boolean grabo = rolMet.grabarUsuario(rolNew);
                        if (grabo == false)
                        {
                            MessageBox.Show("No se puedo registrar el rol", "Aviso");
                        }
                        else
                        {
                            MessageBox.Show("El rol fue registrado con éxito", "Guardar");

                        }

                    }
                    this.Hide();
                } else MessageBox.Show("Debe seleccionar un área", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else MessageBox.Show("Debe seleccionar un rol", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } 
    }
}
