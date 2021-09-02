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
    public partial class MateriasPrimas : Form
    {
        public MateriasPrimas()
        {
            InitializeComponent();
        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Proveedores provAlta = new Proveedores();
            provAlta.Show();
        }

        private void btn_GuardarMatPri_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Va a dar de alta a un nuevo proveedor, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var matPriNew = new MateriaPrima();
            var matPriMet = new MateriasPrimasMetodos();
            var dt = new DataTable();

            matPriNew.mpri_tipo = cBox_Tipo.SelectedItem.ToString();
            matPriNew.mpri_CodArt = tBox_CodArt.Text;
            matPriNew.mpri_Descripcion = tBox_Desc.Text;
            matPriNew.mpri_CUITprov = cBox_Proveedores.SelectedItem.ToString();

            if ((resp == DialogResult.Yes))
            {

            }

        }

        private void MateriasPrimas_Load(object sender, EventArgs e)
        {

        }
    }
}
