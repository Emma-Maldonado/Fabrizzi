namespace Fabrizzi_TP_Integrador
{
    partial class Direcciones_Alta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Direcciones_Alta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitDirAlta = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.lbl_Provincia = new System.Windows.Forms.Label();
            this.lbl_Localidad = new System.Windows.Forms.Label();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Piso = new System.Windows.Forms.Label();
            this.lbl_Departamento = new System.Windows.Forms.Label();
            this.lbl_CP = new System.Windows.Forms.Label();
            this.cBox_Provincia = new System.Windows.Forms.ComboBox();
            this.tBox_Localidad = new System.Windows.Forms.TextBox();
            this.tBox_CP = new System.Windows.Forms.TextBox();
            this.tBox_Dpto = new System.Windows.Forms.TextBox();
            this.tBox_Calle = new System.Windows.Forms.TextBox();
            this.tBox_Numero = new System.Windows.Forms.TextBox();
            this.tBox_Piso = new System.Windows.Forms.TextBox();
            this.btn_GuardarDir = new System.Windows.Forms.Button();
            this.lbl_Local = new System.Windows.Forms.Label();
            this.tBox_Local = new System.Windows.Forms.TextBox();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitDirAlta);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Controls.Add(this.Fabrizzi_logoRoles);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 86);
            this.panel1.TabIndex = 70;
            // 
            // lbl_TitDirAlta
            // 
            this.lbl_TitDirAlta.AutoSize = true;
            this.lbl_TitDirAlta.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitDirAlta.ForeColor = System.Drawing.Color.White;
            this.lbl_TitDirAlta.Location = new System.Drawing.Point(362, 26);
            this.lbl_TitDirAlta.Name = "lbl_TitDirAlta";
            this.lbl_TitDirAlta.Size = new System.Drawing.Size(144, 40);
            this.lbl_TitDirAlta.TabIndex = 66;
            this.lbl_TitDirAlta.Text = "Dirección";
            // 
            // btn_CerrarUsuAlta
            // 
            this.btn_CerrarUsuAlta.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CerrarUsuAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_CerrarUsuAlta.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarUsuAlta.Location = new System.Drawing.Point(774, 26);
            this.btn_CerrarUsuAlta.Name = "btn_CerrarUsuAlta";
            this.btn_CerrarUsuAlta.Size = new System.Drawing.Size(39, 23);
            this.btn_CerrarUsuAlta.TabIndex = 65;
            this.btn_CerrarUsuAlta.Text = "X";
            this.btn_CerrarUsuAlta.UseVisualStyleBackColor = false;
            this.btn_CerrarUsuAlta.Click += new System.EventHandler(this.btn_CerrarUsuAlta_Click);
            // 
            // lbl_Provincia
            // 
            this.lbl_Provincia.AutoSize = true;
            this.lbl_Provincia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Provincia.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Provincia.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Provincia.Location = new System.Drawing.Point(62, 164);
            this.lbl_Provincia.Name = "lbl_Provincia";
            this.lbl_Provincia.Size = new System.Drawing.Size(69, 17);
            this.lbl_Provincia.TabIndex = 71;
            this.lbl_Provincia.Text = "Provincia";
            // 
            // lbl_Localidad
            // 
            this.lbl_Localidad.AutoSize = true;
            this.lbl_Localidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Localidad.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Localidad.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Localidad.Location = new System.Drawing.Point(355, 164);
            this.lbl_Localidad.Name = "lbl_Localidad";
            this.lbl_Localidad.Size = new System.Drawing.Size(77, 17);
            this.lbl_Localidad.TabIndex = 72;
            this.lbl_Localidad.Text = "Localidad:";
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Calle.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Calle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Calle.Location = new System.Drawing.Point(62, 229);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(45, 17);
            this.lbl_Calle.TabIndex = 73;
            this.lbl_Calle.Text = "Calle:";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Numero.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Numero.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Numero.Location = new System.Drawing.Point(405, 226);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(66, 17);
            this.lbl_Numero.TabIndex = 74;
            this.lbl_Numero.Text = "Número:";
            // 
            // lbl_Piso
            // 
            this.lbl_Piso.AutoSize = true;
            this.lbl_Piso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Piso.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Piso.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Piso.Location = new System.Drawing.Point(62, 292);
            this.lbl_Piso.Name = "lbl_Piso";
            this.lbl_Piso.Size = new System.Drawing.Size(40, 17);
            this.lbl_Piso.TabIndex = 75;
            this.lbl_Piso.Text = "Piso:";
            // 
            // lbl_Departamento
            // 
            this.lbl_Departamento.AutoSize = true;
            this.lbl_Departamento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Departamento.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Departamento.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Departamento.Location = new System.Drawing.Point(217, 292);
            this.lbl_Departamento.Name = "lbl_Departamento";
            this.lbl_Departamento.Size = new System.Drawing.Size(108, 17);
            this.lbl_Departamento.TabIndex = 76;
            this.lbl_Departamento.Text = "Departamento:";
            // 
            // lbl_CP
            // 
            this.lbl_CP.AutoSize = true;
            this.lbl_CP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CP.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CP.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_CP.Location = new System.Drawing.Point(627, 164);
            this.lbl_CP.Name = "lbl_CP";
            this.lbl_CP.Size = new System.Drawing.Size(107, 17);
            this.lbl_CP.TabIndex = 77;
            this.lbl_CP.Text = "Código Postal:";
            // 
            // cBox_Provincia
            // 
            this.cBox_Provincia.FormattingEnabled = true;
            this.cBox_Provincia.Items.AddRange(new object[] {
            "Seleccione",
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"});
            this.cBox_Provincia.Location = new System.Drawing.Point(152, 160);
            this.cBox_Provincia.Name = "cBox_Provincia";
            this.cBox_Provincia.Size = new System.Drawing.Size(159, 21);
            this.cBox_Provincia.TabIndex = 78;
            // 
            // tBox_Localidad
            // 
            this.tBox_Localidad.Location = new System.Drawing.Point(452, 161);
            this.tBox_Localidad.Name = "tBox_Localidad";
            this.tBox_Localidad.Size = new System.Drawing.Size(146, 20);
            this.tBox_Localidad.TabIndex = 79;
            // 
            // tBox_CP
            // 
            this.tBox_CP.Location = new System.Drawing.Point(755, 160);
            this.tBox_CP.Name = "tBox_CP";
            this.tBox_CP.Size = new System.Drawing.Size(61, 20);
            this.tBox_CP.TabIndex = 80;
            // 
            // tBox_Dpto
            // 
            this.tBox_Dpto.Location = new System.Drawing.Point(348, 292);
            this.tBox_Dpto.Name = "tBox_Dpto";
            this.tBox_Dpto.Size = new System.Drawing.Size(61, 20);
            this.tBox_Dpto.TabIndex = 81;
            // 
            // tBox_Calle
            // 
            this.tBox_Calle.Location = new System.Drawing.Point(152, 223);
            this.tBox_Calle.Name = "tBox_Calle";
            this.tBox_Calle.Size = new System.Drawing.Size(231, 20);
            this.tBox_Calle.TabIndex = 82;
            // 
            // tBox_Numero
            // 
            this.tBox_Numero.Location = new System.Drawing.Point(491, 223);
            this.tBox_Numero.Name = "tBox_Numero";
            this.tBox_Numero.Size = new System.Drawing.Size(65, 20);
            this.tBox_Numero.TabIndex = 83;
            // 
            // tBox_Piso
            // 
            this.tBox_Piso.Location = new System.Drawing.Point(152, 292);
            this.tBox_Piso.Name = "tBox_Piso";
            this.tBox_Piso.Size = new System.Drawing.Size(40, 20);
            this.tBox_Piso.TabIndex = 84;
            // 
            // btn_GuardarDir
            // 
            this.btn_GuardarDir.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GuardarDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GuardarDir.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarDir.Location = new System.Drawing.Point(676, 395);
            this.btn_GuardarDir.Name = "btn_GuardarDir";
            this.btn_GuardarDir.Size = new System.Drawing.Size(140, 39);
            this.btn_GuardarDir.TabIndex = 85;
            this.btn_GuardarDir.Text = "Guardar";
            this.btn_GuardarDir.UseVisualStyleBackColor = false;
            this.btn_GuardarDir.Click += new System.EventHandler(this.btn_GuardarDir_Click);
            // 
            // lbl_Local
            // 
            this.lbl_Local.AutoSize = true;
            this.lbl_Local.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Local.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Local.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Local.Location = new System.Drawing.Point(424, 292);
            this.lbl_Local.Name = "lbl_Local";
            this.lbl_Local.Size = new System.Drawing.Size(69, 17);
            this.lbl_Local.TabIndex = 86;
            this.lbl_Local.Text = "Local N°:";
            // 
            // tBox_Local
            // 
            this.tBox_Local.Location = new System.Drawing.Point(509, 292);
            this.tBox_Local.Name = "tBox_Local";
            this.tBox_Local.Size = new System.Drawing.Size(47, 20);
            this.tBox_Local.TabIndex = 87;
            // 
            // Fabrizzi_logoRoles
            // 
            this.Fabrizzi_logoRoles.BackColor = System.Drawing.Color.Transparent;
            this.Fabrizzi_logoRoles.Image = ((System.Drawing.Image)(resources.GetObject("Fabrizzi_logoRoles.Image")));
            this.Fabrizzi_logoRoles.Location = new System.Drawing.Point(0, 0);
            this.Fabrizzi_logoRoles.Name = "Fabrizzi_logoRoles";
            this.Fabrizzi_logoRoles.Size = new System.Drawing.Size(241, 87);
            this.Fabrizzi_logoRoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fabrizzi_logoRoles.TabIndex = 64;
            this.Fabrizzi_logoRoles.TabStop = false;
            // 
            // Direcciones_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.tBox_Local);
            this.Controls.Add(this.lbl_Local);
            this.Controls.Add(this.btn_GuardarDir);
            this.Controls.Add(this.tBox_Piso);
            this.Controls.Add(this.tBox_Numero);
            this.Controls.Add(this.tBox_Calle);
            this.Controls.Add(this.tBox_Dpto);
            this.Controls.Add(this.tBox_CP);
            this.Controls.Add(this.tBox_Localidad);
            this.Controls.Add(this.cBox_Provincia);
            this.Controls.Add(this.lbl_CP);
            this.Controls.Add(this.lbl_Departamento);
            this.Controls.Add(this.lbl_Piso);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_Calle);
            this.Controls.Add(this.lbl_Localidad);
            this.Controls.Add(this.lbl_Provincia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Direcciones_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direcciones_Alta";
            this.Load += new System.EventHandler(this.Direcciones_Alta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitDirAlta;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        public System.Windows.Forms.Label lbl_Provincia;
        public System.Windows.Forms.Label lbl_Localidad;
        public System.Windows.Forms.Label lbl_Calle;
        public System.Windows.Forms.Label lbl_Numero;
        public System.Windows.Forms.Label lbl_Piso;
        public System.Windows.Forms.Label lbl_Departamento;
        public System.Windows.Forms.Label lbl_CP;
        private System.Windows.Forms.ComboBox cBox_Provincia;
        private System.Windows.Forms.TextBox tBox_Localidad;
        private System.Windows.Forms.TextBox tBox_CP;
        private System.Windows.Forms.TextBox tBox_Dpto;
        private System.Windows.Forms.TextBox tBox_Calle;
        private System.Windows.Forms.TextBox tBox_Numero;
        private System.Windows.Forms.TextBox tBox_Piso;
        private System.Windows.Forms.Button btn_GuardarDir;
        public System.Windows.Forms.Label lbl_Local;
        private System.Windows.Forms.TextBox tBox_Local;
    }
}