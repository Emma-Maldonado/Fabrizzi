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
    public partial class Usuarios_Alta : Form
    {
        public Usuarios_Alta()
        {
            InitializeComponent();
        }

        public String rolDesc = "";

        private void btn_ConsultarRolPorAreaUsu_Click(object sender, EventArgs e)
        {
         
        }

        private void cbox_RolUserAlta_SelectedIndexChanged(object sender, EventArgs e)
        {
            rolDesc = cbox_RolUserAlta.SelectedValue.ToString();
        }


        private void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Esta generando un nuevo usuario, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var dt = new DataTable();
            var usuNew = new Usuario();
            var usuMet = new UsuariosMetodos();
            var rolMet = new RolesMetodos();

            
            usuNew.Nombre = tBox_NombreUsu.Text;
            usuNew.Apellido = tBox_ApellidoUsu.Text;
            usuNew.DNI = tBox_DNIusu.Text;
            usuNew.IdRol = Convert.ToInt32 (rolDesc);
            var fechaAlta = Convert.ToDateTime(dtp_FechaAltaUsu.Value.ToString("dd/MM/yyyy"));
            usuNew.FechaDeAlta = fechaAlta.Date;
            usuNew.Area = cbox_AreaParaUsu.SelectedItem.ToString();

            if (usuNew.Apellido != "")
            {
                if (usuNew.Nombre != "")
                {
                    if (usuNew.DNI != "")
                    {
                        if (usuNew.Area != "Seleccione")
                        {
                            dt = usuMet.ConsultarDni(usuNew.DNI);

                            if (dt.Rows.Count == 0)
                            {
                                Boolean grabo = usuMet.grabarUsuario(usuNew);
                                if (grabo == false)
                                {
                                    MessageBox.Show("No se puedo registrar el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("El usuario fue registrado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    UsuariosListado usuList = new UsuariosListado();
                                    usuList.Show();

                                }
                            }
                            else MessageBox.Show("Ya existe un usuario con ese DNI", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("El campo Area es obligatorio, seleccione una.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("El campo DNI es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El campo Nombre es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("El campo Apellido es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Usuarios_Alta_Load(object sender, EventArgs e)
        {
            cbox_AreaParaUsu.SelectedIndex = 0;
            
            var dt = new DataTable();
            var rolMet = new RolesMetodos();
            

            dt = rolMet.ConsultarRoles2();
            if (dt.Rows.Count != 0)
            {
                cbox_RolUserAlta.DataSource = dt; 
                cbox_RolUserAlta.DisplayMember = "rolDesc";
                cbox_RolUserAlta.ValueMember = "id";

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
    }

