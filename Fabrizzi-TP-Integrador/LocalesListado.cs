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
    public partial class LocalesListado : Form
    {
        public LocalesListado()
        {
            InitializeComponent();
        }

        private void btn_NuevoProv_Click(object sender, EventArgs e)
        {
            Locales loc = new Locales();
            loc.Show();
        }

        private void btn_BuscarProv_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var locMet = new LocalesMetodos();
            var nombreLocal =tBox_NomLocalBuscar.Text;

            if(nombreLocal != "")
            {
                dt = locMet.ConsultarPorNombre(nombreLocal);

                if (dt.Rows.Count != 0)
                {
                    dgv_ListProv.DataSource = dt;
                }
                else MessageBox.Show("No hay registro para ese CUIT y esa razón social.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void LocalesListado_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var locMet = new LocalesMetodos();
            dt = locMet.ConsultarLocales();


            if (dt.Rows.Count != 0)
            {
                dgv_ListProv.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_BajaProv_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ListProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ModifProv_Click(object sender, EventArgs e)
        {

        }
    }
}
