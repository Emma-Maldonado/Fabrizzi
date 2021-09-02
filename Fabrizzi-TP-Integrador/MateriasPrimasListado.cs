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
    public partial class MateriasPrimasListado : Form
    {
        public MateriasPrimasListado()
        {
            InitializeComponent();
        }
        public String cuitProv = "";
        private void MateriasPrimasListado_Load(object sender, EventArgs e)
        {

            var ds = new DataSet();
            var dt = new DataTable();
            var MatPriMet = new MateriasPrimasMetodos();
            dt = MatPriMet.ConsultarMateria();


            if (dt.Rows.Count != 0)
            {
                dgv_ListMateriaPrima.DataSource = dt; //ds.Tables[0];

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

        private void dgv_ListProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ModifProv_Click(object sender, EventArgs e)
        {
            MateriasPrimas mPri = new MateriasPrimas();
            mPri.Show();

        }

        private void cBox_RolBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuitProv = cBox_ProveedorBuscar.SelectedItem.ToString();
        }

        private void btn_BuscarProv_Click(object sender, EventArgs e)
        {
            //var dt = new DataTable();
            //var provMet = new ProveedoresMetodos();
            //provMet =

            //String RazonSocial = cBox_ProveedorBuscar.Text;

        }
    }
}
