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
    public partial class UsuarioModificar : Form
    {
        public UsuarioModificar()
        {
            InitializeComponent();
        }


        public DataTable dtMod = new DataTable();

        public int legajo = 0;
        public String IdRol = "";


        private void UsuarioModificar_Load(object sender, EventArgs e)
        {
            cbox_AreaParaUsu.SelectedIndex = 0;

            var dt = new DataTable();
            var rolMet = new RolesMetodos();


            dt = rolMet.ConsultarRoles2();
            if (dt.Rows.Count != 0)
            {
                cBox_RolBuscar.DataSource = dt;
                cBox_RolBuscar.DisplayMember = "rolDesc";
                cBox_RolBuscar.ValueMember = "id";

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }

        private void btn_CerrarUsuList_Click(object sender, EventArgs e)
        {
            UsuariosListado usu = new UsuariosListado();
            usu.Show();
            this.Close();
        }

        private void btn_GuardarModRol_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Está modificando el usuario. Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            var dtMod = new DataTable();
            var usuNew = new Usuario();
            var usuMet = new UsuariosMetodos();


            String area = cbox_AreaParaUsu.SelectedItem.ToString();

            String SelRol = cBox_RolBuscar.Enabled.ToString();


            if ((resp == DialogResult.Yes))
            {

                if (area != "Seleccione")
                {
                    if (area != "Seleccione" && SelRol == "True")
                    {
                        int rol = Convert.ToInt32(IdRol);
                        Boolean grabo = usuMet.ModificarAreaRol(rol, legajo, area);
                        if (grabo == false)
                        {
                            MessageBox.Show("No se pudo modificar usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El usuario fue modificado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            UsuariosListado usuList = new UsuariosListado();
                            usuList.Show();

                        }
                    }
                    else
                    {

                        Boolean grabo2 = usuMet.ModificarArea(area, legajo);
                        if (grabo2 == false)
                        {
                            MessageBox.Show("No se pudo modificar usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El usuario fue modificado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            UsuariosListado usuList = new UsuariosListado();
                            usuList.Show();

                        }
                    }

                }
                else if (SelRol == "True")
                {
                    int rol = Convert.ToInt32(IdRol);
                    Boolean grabo = usuMet.ModificarRol(rol, legajo);
                    if (grabo == false)
                    {
                        MessageBox.Show("No se pudo modificar usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El usuario fue modificado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        UsuariosListado usuList = new UsuariosListado();
                        usuList.Show();

                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una opción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void cBox_RolBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdRol = cBox_RolBuscar.SelectedValue.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Roles AltaRol = new Roles();


            AltaRol.Show();

        }
    }
}

