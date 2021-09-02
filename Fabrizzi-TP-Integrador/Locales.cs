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
    public partial class Locales : Form
    {
        public Locales()
        {
            InitializeComponent();
        }

        private void linklbl_DireccionLoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Direcciones dirLoc = new Direcciones();
            dirLoc.letra = "L-";
            dirLoc.operacion = "A";
            var dirMet = new DireccionesMetodos();
            dirLoc.dt = dirMet.ConsultarIdDirLoc();
            dirLoc.Show();
        }

        private void Locales_Load(object sender, EventArgs e)
        {

        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_GuardarPorvMod_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Va a dar de alta a un nuevo local, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var locMet = new LocalesMetodos();
            var dirMet = new DireccionesMetodos();
            var LocNew = new Local();
            var dt = new DataTable();

            LocNew.Nombre = txtNombreLocal.Text;
            LocNew.Oulet = cbox_Outlet.Checked.ToString();
            LocNew.Telefono = tBox_Telefono.Text;
            LocNew.Email = tBox_Email.Text;
            LocNew.Fabrica = cBox_Fabrica.Checked.ToString();
            LocNew.FechaAlta = DateTime.Today;

            dt = dirMet.ConsultarLocal();
            DataRow row2 = dt.Rows[0];
            LocNew.Direccion = row2[0].ToString();

            dt = locMet.ConsultarPorNombre(LocNew.Nombre);

            if ((resp == DialogResult.Yes))
            {
                if (dt.Rows.Count == 0)
                {
                    if (LocNew.Nombre != "")
                    {
                        Boolean grabo = locMet.grabarLocal(LocNew);
                        if (grabo == false)
                        {
                            MessageBox.Show("No se puedo registrar el Local", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Boolean borro = dirMet.BorrarDireccion(LocNew.Direccion);
                            if (borro == true)
                            {
                                MessageBox.Show("Se borro la dirección ingresada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El local fue registrado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LocalesListado locList = new LocalesListado();
                            this.Hide();
                            locList.Show();
                        }
                    }
                    else MessageBox.Show("Es necesario que ingrese el nombre del local", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El local ya está registrado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DireccionesMetodos dirMet = new DireccionesMetodos();
            var dt2 = new DataTable();
            dt2 = dirMet.ConsultarDirLocal();
            //DataRow row2 = dt2.Rows[0];

            dgv_direccionMod.DataSource = dt2;
        }
    }
}
