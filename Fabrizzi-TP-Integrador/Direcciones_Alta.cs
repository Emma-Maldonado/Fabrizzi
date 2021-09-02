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
    public partial class Direcciones_Alta : Form
    {
        public Direcciones_Alta()
        {
            InitializeComponent();
        }
        public String letra = "";
        public String texto = "";
        public DataTable dt = new DataTable();

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_GuardarDir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Esta generando una nueva dirección, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var dirMet = new DireccionesMetodos();
            var dirNew = new Direccion();
            int numDir = 0;
            int numDirNew = 0;

            if (dt.Rows.Count != 0)
            {
                DataRow row2 = dt.Rows[0];
                numDir = Convert.ToInt32(row2[0]);
                numDirNew = numDir + 1;

                if (numDirNew < 10)
                {
                    texto = String.Format(letra + "00" + numDirNew);
                    dirNew.dir_IdDir = texto;
                }
                else if (numDirNew >= 10 && numDirNew < 100)
                {
                    texto = String.Format(letra + "0" + numDirNew);
                    dirNew.dir_IdDir = texto; //P-013
                }

            } else
            {
                numDirNew = 1;
                texto = String.Format(letra + "00" + numDirNew);
                dirNew.dir_IdDir = texto;

            }

            dirNew.dir_Provincia = cBox_Provincia.SelectedItem.ToString();
            dirNew.dir_Localidad = tBox_Localidad.Text;
            dirNew.dir_Calle = tBox_Calle.Text;

            if (tBox_Numero.Text == "")
            {
                dirNew.dir_Numero = 0;
            } else
            {
                dirNew.dir_Numero = Convert.ToInt32(tBox_Numero.Text);
            }

            if (tBox_Piso.Text == "")
            {
                dirNew.dir_Piso = 0;
            } else
            {
                dirNew.dir_Piso = Convert.ToInt32(tBox_Piso.Text);
            }

            dirNew.dir_Departamento = tBox_Dpto.Text;
            dirNew.dir_Local = tBox_Local.Text;



            if (dirNew.dir_Provincia != "Seleccione")
            {
                if (dirNew.dir_Localidad != "")
                {
                    if (tBox_CP.Text != "")                       
                    {
                        dirNew.dir_CP = Convert.ToInt32(tBox_CP.Text);
                        if (dirNew.dir_Calle != "")
                        {

                            Boolean grabo = dirMet.grabarDireccion(dirNew);
                            if (grabo == false)
                            {
                                MessageBox.Show("No se puedo registrar la dirección", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("La dirección fue registrada con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                this.Hide();

                            }

                        }
                        else MessageBox.Show("Es necesario que ingrese una calle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else MessageBox.Show("Es necesario que ingrese un código postal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Es necesario que ingrese una localidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Es necesario que seleccione una provincia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);


        
        }

        private void Direcciones_Alta_Load(object sender, EventArgs e)
        {
            cBox_Provincia.SelectedIndex = 0;
        }
    }
}
