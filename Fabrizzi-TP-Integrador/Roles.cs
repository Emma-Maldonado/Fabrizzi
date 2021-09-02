using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fabrizzi_TP_Integrador
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            cBox_NombreRol.SelectedIndex = 0;
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Esta generando un nuevo rol, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var dt = new DataTable();
            var rolNew = new Rol();
            var rolMet = new RolesMetodos();
                        
   
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
                                } else Permisos = "Usuarios, Productos, Proveedores, Materias primas";
                            } else Permisos = "Usuarios, Productos, Proveedores";

                        } else if (chBox_Usuarios.Checked && chBox_Productos.Checked && chBox_MatPri.Checked)
                        {
                            Permisos = "Usuarios, Productos, Materias primas";
                        }else if (chBox_Usuarios.Checked && chBox_Productos.Checked && chBox_Locales.Checked)
                        {
                            Permisos = "Usuarios, Productos, Locales";
                        }else Permisos = "Usuarios, Productos";

                    } else if (chBox_Usuarios.Checked && chBox_Proveedores.Checked)
                    {
                        if (chBox_Usuarios.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked)
                        {
                            if (chBox_Usuarios.Checked && chBox_Proveedores.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                            {
                                Permisos = "Usuarios, Proveedores, Materias primas, Locales";
                            } else Permisos = "Usuarios, Proveedores, Materias primas";

                        } else Permisos = "Usuarios, Proveedores";
                    } else if (chBox_Usuarios.Checked && chBox_MatPri.Checked)
                    {
                        if (chBox_Usuarios.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                        {
                            Permisos = "Usuarios, Materias primas, Locales";
                        } else Permisos = "Usuarios, Materias primas";

                    } else if (chBox_Usuarios.Checked && chBox_Locales.Checked)
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

                            } else  Permisos = "Productos, Proveedores, Materias primas";

                        } else Permisos = "Productos, Proveedores";
                    }else if (chBox_Productos.Checked && chBox_MatPri.Checked)
                    {
                        if (chBox_Productos.Checked && chBox_MatPri.Checked && chBox_Locales.Checked)
                        {
                            Permisos = "Productos, Materias primas, Locales";
                        }
                        else Permisos = "Productos, Materias primas";
                    }else if (chBox_Productos.Checked && chBox_Locales.Checked)
                    {
                        Permisos = "Productos, Locales";
                    }else Permisos = "Productos";
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

                    } else if (chBox_Proveedores.Checked && chBox_Locales.Checked)
                    {
                        Permisos = "Proveedores, Locales";
                    }
                    else  Permisos = "Proveedores";
                }
                else if (chBox_MatPri.Checked)
                {
                    if (chBox_MatPri.Checked && chBox_Locales.Checked)
                    {
                        Permisos = "Materias primas, Locales";

                    } else Permisos = "Materias primas";
                }
                else if (chBox_Locales.Checked)
                {
                    Permisos = "Locales";
                }
                

                rolNew.NombreRol = cBox_NombreRol.SelectedItem.ToString();
                rolNew.DescripcionRol = Permisos;
                
                var fechaAlta = Convert.ToDateTime( dtp_Fecha.Value.ToString("dd/MM/yyyy")); //dateTimePicker1.Value.ToString("dd/MM/yyyy") dtp_Fecha.Value.ToShortTimeString());
                rolNew.FechaAlta = fechaAlta.Date;

                dt = rolMet.Consultar(rolNew.NombreRol, rolNew.DescripcionRol);

                if (dt.Rows.Count == 0)
                {
                    Boolean grabo = rolMet.grabarUsuario(rolNew);
                    if (grabo == false)
                    {
                        MessageBox.Show("No se puedo registrar el rol", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El rol fue registrado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        RolesListado rolList = new RolesListado();
                        rolList.Show();

                    }
                }
                else MessageBox.Show("El rol ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }            
        }

        

        private void dtp_Fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cBox_AreaRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chBox_Locales_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_Productos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBox_NombreRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chBox_Proveedores_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_MatPri_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_Usuarios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
