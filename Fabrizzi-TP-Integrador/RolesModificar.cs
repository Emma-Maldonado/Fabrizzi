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
    public partial class RolesModificar : Form
    {
        public RolesModificar()
        {
            InitializeComponent();
        }

        public String nombreRol = "";
        public String descRol = "";
        

        public DataTable dtMod = new DataTable();

        private void btn_CerrarRolesList_Click(object sender, EventArgs e)
        {
            this.Close();
            RolesListado rolList = new RolesListado();
            rolList.Show();

        }

        private void RolesModificar_Load(object sender, EventArgs e)
        {

        }

        private void btn_GuardarModRol_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Está modificando los permisos del rol. Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                }
                                else Permisos = "Usuarios, Productos, Proveedores, Materias primas";
                            }
                            else Permisos = "Usuarios, Productos, Proveedores";

                        }
                        else if (chBox_Usuarios.Checked && chBox_Productos.Checked && chBox_MatPri.Checked)
                        {
                            Permisos = "Usuarios, Productos, Materias primas";
                        }
                        else if (chBox_Usuarios.Checked && chBox_Productos.Checked && chBox_Locales.Checked)
                        {
                            Permisos = "Usuarios, Productos, Locales";
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



                dt = rolMet.Consultar(nombreRol, descRol);
                DataRow row2 = dt.Rows[0];
                int rol = Convert.ToInt32 (row2[0]);

                descRol = Permisos;
                dt = rolMet.Consultar(nombreRol, descRol);

                if (dt.Rows.Count == 0)
                {
                    
                    Boolean grabo = rolMet.ModificarRol(descRol, rol);
                    if (grabo == false)
                    {
                        MessageBox.Show("No se pudo modificar el rol", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El rol fue modificado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        RolesListado rolList = new RolesListado();
                        rolList.Show();

                    }
                }
                else MessageBox.Show("El rol con estos permisos ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
