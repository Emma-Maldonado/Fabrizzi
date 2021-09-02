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
    public partial class ProveedoresModificar : Form
    {
        public ProveedoresModificar()
        {
            InitializeComponent();
        }

        public DataTable dtMod = new DataTable();
        public String CUIT = "";
        public String cambioDom = "N";
        public String idDir = "";


        private void linklbl_DireccionMod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Direcciones dir = new Direcciones();
            var provMet = new ProveedoresMetodos();
            var dirMet = new DireccionesMetodos();
            var dt = new DataTable();
            dt = provMet.ConsultarIdDirProv(CUIT);
            DataRow row = dt.Rows[0];
            dir.texto2 = row[0].ToString();
            dir.operacion = "M";
            idDir = dir.texto2;

            dt = dirMet.ConsultarDireccion(dir.texto2);

            if (dt.Rows.Count != 0)
            {
                row = dt.Rows[0];

                dir.tBox_Calle.Text = row[0].ToString();
                dir.tBox_Numero.Text = row[1].ToString();
                dir.tBox_Piso.Text = row[2].ToString();
                dir.tBox_Dpto.Text = row[3].ToString();
                dir.tBox_Local.Text = row[4].ToString();
                dir.tBox_Localidad.Text = row[5].ToString();
                dir.cBox_Provincia.DisplayMember = row[6].ToString();
                dir.tBox_CP.Text = row[7].ToString();
            }


            dir.Show();

        }

        private void btn_GuardarPorvMod_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Está modificando los datos del proveedor. Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var dt = new DataTable();
            //var provNew = new Proveedor();
            var provMet = new ProveedoresMetodos();

            var tel = tBox_Telefono.Text;
            var mail = tBox_Email.Text;

            if ((resp == DialogResult.Yes))
            {
                if (tel != "")
                {

                    if (mail != "")

                    {
                        if (cambioDom == "Y")
                        {
                            Boolean grabo = provMet.ModificarTelProv(CUIT, tel);
                            Boolean grabo2 = provMet.ModificarMailProv(CUIT, mail);
                            if (grabo == false)
                            {
                                MessageBox.Show("No se pudo modificar el teléfono, el mail y la dirección del proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("El teléfono, el mail y la dirección del proveedor fueron modificados con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                ProveedoresListado provList = new ProveedoresListado();
                                provList.Show();

                            }
                        }
                        else
                        {
                            Boolean grabo = provMet.ModificarTelProv(CUIT, tel);
                            Boolean grabo2 = provMet.ModificarMailProv(CUIT, mail);
                            if (grabo == false)
                            {
                                MessageBox.Show("No se pudo modificar el teléfono y el mail del proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("El teléfono y el mail del proveedor fueron modificados con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                ProveedoresListado provList = new ProveedoresListado();
                                provList.Show();

                            }
                        }
                    }
                    else
                    {
                        Boolean grabo = provMet.ModificarTelProv(CUIT, tel);
                        if (grabo == false)
                        {
                            MessageBox.Show("No se pudo modificar el teléfono del proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El teléfono del proveedor fue modificado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ProveedoresListado provList = new ProveedoresListado();
                            provList.Show();

                        }
                    }

                }else if (mail != "")
                {
                    if (cambioDom == "Y")
                    {
                        Boolean grabo = provMet.ModificarMailProv(CUIT, mail);
                        if (grabo == false)
                        {
                            MessageBox.Show("No se pudo modificar el e-mail y la dirección del proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El e-mail y la dirección del proveedor fueron modificados con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ProveedoresListado provList = new ProveedoresListado();
                            provList.Show();

                        }
                    }else
                    {
                        Boolean grabo = provMet.ModificarMailProv(CUIT, mail);
                        if (grabo == false)
                        {
                            MessageBox.Show("No se pudo modificar el e-mail del proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El e-mail del proveedor fue modificado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ProveedoresListado provList = new ProveedoresListado();
                            provList.Show();

                        }
                    }

                }else if (cambioDom == "Y")
                {
                    
                        MessageBox.Show("La dirección del proveedor fue modificada con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ProveedoresListado provList = new ProveedoresListado();
                        provList.Show();

                    
                }
            }

        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProveedoresModificar_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DireccionesMetodos dirMet = new DireccionesMetodos();
            var dt2 = new DataTable();
            dt2 = dirMet.ConsultarDireccion(idDir);
            //DataRow row2 = dt2.Rows[0];
            dgv_direccionMod.DataSource = dt2; //row2[0].ToString();
            cambioDom = "Y";
        }
    }
}
