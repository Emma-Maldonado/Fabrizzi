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
    public partial class ProveedoresListado : Form
    {
        public ProveedoresListado()
        {
            InitializeComponent();
        }

        String CUITprov = "";
       
        private void ProveedoresListado_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var provMet = new ProveedoresMetodos();
            dt = provMet.ConsultarProv();
           

            if (dt.Rows.Count != 0  )
            {
                dgv_ListProv.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }

        private void btn_NuevoProv_Click(object sender, EventArgs e)
        {
            Proveedores provList = new Proveedores();
            this.Hide();
            provList.Show();

        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_BuscarProv_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var provMet = new ProveedoresMetodos();
            String CUIT = tBox_CUITBuscar.Text;
            String RazonSocial = tBox_RazonSocialBuscar.Text;

            if (CUIT != "")
            {
                if (CUIT != "" && RazonSocial != "")
                {
                    dt = provMet.ConsultarProv2(CUIT, RazonSocial);

                    if (dt.Rows.Count != 0)
                    {
                        dgv_ListProv.DataSource = dt;
                    }
                    else MessageBox.Show("No hay registro para ese CUIT y esa razón social.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    dt = provMet.ConsultarProv2(CUIT);

                    if (dt.Rows.Count != 0)
                    {
                        dgv_ListProv.DataSource = dt;
                    }
                    else MessageBox.Show("No hay registro para ese CUIT.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (RazonSocial != "")
            {
                dt = provMet.ConsultarProv3(RazonSocial);

                if (dt.Rows.Count != 0)
                {
                    dgv_ListProv.DataSource = dt;
                }
                else MessageBox.Show("No hay registro para esa razón social.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Debe ingresar un dato para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        private void dgv_ListProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dt = new DataTable();

            CUITprov = dgv_ListProv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_ModifProv_Click(object sender, EventArgs e)
        {
            ProveedoresModificar provMod = new ProveedoresModificar();
            var ds = new DataSet();
            var dt = new DataTable();
            var provMet = new ProveedoresMetodos();
            dt = provMet.ConsultarProv2(CUITprov);
            if (dt.Rows.Count != 0)
            {
                provMod.dgv_ProvListMod.DataSource = dt; //ds.Tables[0];
                provMod.CUIT = CUITprov;
                provMod.dtMod = dt;
            }


            this.Hide();
            provMod.Show();

        }

        private void tBox_CUITBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_BajaProv_Click_1(object sender, EventArgs e)// falta filtrar que no de debaja si esta dado de baja ya
        {
           
            
            DialogResult resp = MessageBox.Show("Está por dar de baja un proveedor. Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ((resp == DialogResult.Yes))
            {

                var ds = new DataSet();
                var dt = new DataTable();
                var rolMet = new ProveedoresMetodos();
                dt = rolMet.ConsultarProv2(CUITprov);
                if (dt.Rows.Count != 0)
                {
                    DataRow row2 = dt.Rows[0];
                    //int rol = Convert.ToInt32(row2[0]);
                    Boolean gravo = rolMet.darDeBajaProveedor(CUITprov);
                    dt = rolMet.ConsultarProv2(CUITprov);
                    if (dt.Rows.Count != 0)
                    {
                        dgv_ListProv.DataSource = dt; //ds.Tables[0];

                    }
                }
                this.Show();

            }
        }
    }
}

