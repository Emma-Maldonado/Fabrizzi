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
    public partial class UsuariosListado : Form
    {
        public UsuariosListado()
        {
            InitializeComponent();
        }

        public int legajo = 0;

        private void UsuariosListado_Load(object sender, EventArgs e)
        {
            cBox_RolesUsuarioList.SelectedIndex = 0;
            cBox_AreaUsuarioList.SelectedIndex = 0;

            var ds = new DataSet();
            var dt = new DataTable();
            var usuMet = new UsuariosMetodos();

            dt = usuMet.Consultar();
            if (dt.Rows.Count != 0)
            {
                DgvUsuarios.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }

        private void btn_NuevoUsuario_Click(object sender, EventArgs e)
        {
            Usuarios_Alta usuAlta = new Usuarios_Alta();
            this.Hide();
            usuAlta.Show();

        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var usuMet = new UsuariosMetodos();
            String rol = cBox_RolesUsuarioList.SelectedItem.ToString();
            String Area = cBox_AreaUsuarioList.SelectedItem.ToString();

            if (cBox_RolesUsuarioList.SelectedIndex != 0)
            {
                dt = usuMet.ConsultarPorRol(rol);

                if (dt.Rows.Count != 0)
                {
                    DgvUsuarios.DataSource = dt; //ds.Tables[0];

                }
                else MessageBox.Show("No hay registros en la seleccion");

            }
            else if (cBox_AreaUsuarioList.SelectedIndex != 0)
            {
                dt = usuMet.ConsultarPorArea(Area);

                if (dt.Rows.Count != 0)
                {
                    DgvUsuarios.DataSource = dt; //ds.Tables[0];

                }
                else MessageBox.Show("No hay registros en la seleccion");

            }
            else if (cBox_AreaUsuarioList.SelectedIndex != 0 && cBox_RolesUsuarioList.SelectedIndex != 0)
            {
                dt = usuMet.ConsultarPorAreaRol(Area, rol);

                if (dt.Rows.Count != 0)
                {
                    DgvUsuarios.DataSource = dt; //ds.Tables[0];

                }
                else MessageBox.Show("No hay registros en la seleccion");
            }

        }


        private void btn_CerrarUsuList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dt = new DataTable();


            legajo = Convert.ToInt32(DgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());

        }
        private void btn_DarDeBajaUsuario_Click(object sender, EventArgs e)
        {

            DialogResult resp = MessageBox.Show("Está por dar de baja el usuario. Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ((resp == DialogResult.Yes))
            {

                var ds = new DataSet();
                var dt = new DataTable();
                var usuMet = new UsuariosMetodos();
                dt = usuMet.ConsultarLegajo(legajo);

                if (dt.Rows.Count != 0)
                {
                    DataRow row2 = dt.Rows[0];
                    //int legajo = Convert.ToInt32(row2[0]);
                    Boolean gravo = usuMet.darDeBajaUsuario(legajo);
                    dt = usuMet.Consultar();
                    if (dt.Rows.Count != 0)
                    {
                        DgvUsuarios.DataSource = dt; //ds.Tables[0];

                    }
                }
                this.Show();

            }



        }


        private void btn_ModUsuario_Click(object sender, EventArgs e)
        {
            UsuarioModificar usuModif = new UsuarioModificar();
            var ds = new DataSet();
            var dt = new DataTable();
            var MetUsu = new UsuariosMetodos();


            dt = MetUsu.ConsultarLegajo2(legajo);



            if (dt.Rows.Count != 0)
            {
                usuModif.legajo = legajo;
                usuModif.DgvModifUsu.DataSource = dt;
            }


            //this.Hide();



            usuModif.Show();
        }

        private void DgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            legajo = Convert.ToInt32(DgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());

        }
    }
}
