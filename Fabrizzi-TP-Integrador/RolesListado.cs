using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fabrizzi_TP_Integrador
{
    public partial class RolesListado : Form
    {
        public RolesListado()
        {
            InitializeComponent();
        }

        public String NombreRol = "";
        public String Area = "";
        public String Permisos = "";

        private void btn_NuevoRol_Click(object sender, EventArgs e)
        {
            Roles rol = new Roles();
            rol.Show();
        }

        private void btn_BuscarRol_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var rol = new RolesMetodos();
            String Rol = cBox_RolBuscar.SelectedItem.ToString();
            String Estado = cBox_EstadoRolBuscar.SelectedItem.ToString();

            if (cBox_RolBuscar.SelectedIndex != 0)
            {
                dt = rol.ConsultarPorRol(Rol);

                if (dt.Rows.Count != 0)
                {
                    Dgv_Roles.DataSource = dt; //ds.Tables[0];

                }
                else MessageBox.Show("No hay registros en la seleccion");

            }
            else if (cBox_EstadoRolBuscar.SelectedIndex != 0)
            {
                dt = rol.ConsultarPorEstado(Estado);

                if (dt.Rows.Count != 0)
                {
                    Dgv_Roles.DataSource = dt; //ds.Tables[0];

                }
                else MessageBox.Show("No hay registros en la seleccion");

            }
            else if (cBox_RolBuscar.SelectedIndex != 0 && cBox_EstadoRolBuscar.SelectedIndex != 0)
            {
                dt = rol.ConsultarPorRolEstado(Rol, Estado);

                if (dt.Rows.Count != 0)
                {
                    Dgv_Roles.DataSource = dt; //ds.Tables[0];

                }
                else MessageBox.Show("No hay registros en la seleccion");


            }
        }

        private void RolesListado_Load(object sender, EventArgs e)
        {
            cBox_RolBuscar.SelectedIndex = 0;
            cBox_EstadoRolBuscar.SelectedIndex = 0;

            var ds = new DataSet();
            var dt = new DataTable();
            var rolMet = new RolesMetodos();
            dt = rolMet.Consultar();
            if (dt.Rows.Count != 0)
            {
                Dgv_Roles.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }




        private void btn_BajaRol_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Está por dar de baja el rol. Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ((resp == DialogResult.Yes))
            {

                var ds = new DataSet();
                var dt = new DataTable();
                var rolMet = new RolesMetodos();
                dt = rolMet.Consultar(NombreRol, Permisos);
                if (dt.Rows.Count != 0)
                {
                    DataRow row2 = dt.Rows[0];
                    int rol = Convert.ToInt32(row2[0]);
                    Boolean gravo = rolMet.darDeBajaRol(rol);
                    dt = rolMet.Consultar();
                    if (dt.Rows.Count != 0)
                    {
                        Dgv_Roles.DataSource = dt; //ds.Tables[0];

                    }
                }
                this.Show();

            }


        }

        private void btn_CerrarRolesList_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Dgv_Roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            var dt = new DataTable();

            NombreRol = Dgv_Roles.Rows[e.RowIndex].Cells[0].Value.ToString();
            Permisos = Dgv_Roles.Rows[e.RowIndex].Cells[1].Value.ToString();
            Area = Dgv_Roles.Rows[e.RowIndex].Cells[2].Value.ToString();

            
        }

        private void btn_ModifRol_Click(object sender, EventArgs e)
        {

            RolesModificar rolMod = new RolesModificar();
            var ds = new DataSet();
            var dt = new DataTable();
            var rolMet = new RolesMetodos();
            dt = rolMet.Consultar2(NombreRol, Permisos);
            if (dt.Rows.Count != 0)
            {
                rolMod.dgv_ModRol.DataSource = dt; //ds.Tables[0];
                rolMod.nombreRol = NombreRol;
                rolMod.descRol = Permisos;
                rolMod.dtMod = dt;
            }


            this.Hide();
            rolMod.Show();

        }


    }
}
