namespace Fabrizzi_TP_Integrador
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.chBox_Locales = new System.Windows.Forms.CheckBox();
            this.chBox_Productos = new System.Windows.Forms.CheckBox();
            this.cBox_NombreRol = new System.Windows.Forms.ComboBox();
            this.chBox_Proveedores = new System.Windows.Forms.CheckBox();
            this.chBox_MatPri = new System.Windows.Forms.CheckBox();
            this.chBox_Usuarios = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitRolAlta = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Enabled = false;
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(577, 153);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(115, 20);
            this.dtp_Fecha.TabIndex = 30;
            this.dtp_Fecha.ValueChanged += new System.EventHandler(this.dtp_Fecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(470, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha Alta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chBox_Locales
            // 
            this.chBox_Locales.AutoSize = true;
            this.chBox_Locales.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.chBox_Locales.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_Locales.Location = new System.Drawing.Point(212, 307);
            this.chBox_Locales.Name = "chBox_Locales";
            this.chBox_Locales.Size = new System.Drawing.Size(77, 21);
            this.chBox_Locales.TabIndex = 26;
            this.chBox_Locales.Text = "Locales";
            this.chBox_Locales.UseVisualStyleBackColor = true;
            this.chBox_Locales.CheckedChanged += new System.EventHandler(this.chBox_Locales_CheckedChanged);
            // 
            // chBox_Productos
            // 
            this.chBox_Productos.AutoSize = true;
            this.chBox_Productos.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.chBox_Productos.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_Productos.Location = new System.Drawing.Point(212, 226);
            this.chBox_Productos.Name = "chBox_Productos";
            this.chBox_Productos.Size = new System.Drawing.Size(95, 21);
            this.chBox_Productos.TabIndex = 25;
            this.chBox_Productos.Text = "Productos";
            this.chBox_Productos.UseVisualStyleBackColor = true;
            this.chBox_Productos.CheckedChanged += new System.EventHandler(this.chBox_Productos_CheckedChanged);
            // 
            // cBox_NombreRol
            // 
            this.cBox_NombreRol.FormattingEnabled = true;
            this.cBox_NombreRol.Items.AddRange(new object[] {
            "Seleccione",
            "Empleado",
            "Encargado",
            "Supervisor"});
            this.cBox_NombreRol.Location = new System.Drawing.Point(212, 149);
            this.cBox_NombreRol.Name = "cBox_NombreRol";
            this.cBox_NombreRol.Size = new System.Drawing.Size(183, 21);
            this.cBox_NombreRol.TabIndex = 24;
            this.cBox_NombreRol.SelectedIndexChanged += new System.EventHandler(this.cBox_NombreRol_SelectedIndexChanged);
            // 
            // chBox_Proveedores
            // 
            this.chBox_Proveedores.AutoSize = true;
            this.chBox_Proveedores.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.chBox_Proveedores.ForeColor = System.Drawing.Color.White;
            this.chBox_Proveedores.Location = new System.Drawing.Point(212, 253);
            this.chBox_Proveedores.Name = "chBox_Proveedores";
            this.chBox_Proveedores.Size = new System.Drawing.Size(112, 21);
            this.chBox_Proveedores.TabIndex = 23;
            this.chBox_Proveedores.Text = "Proveedores";
            this.chBox_Proveedores.UseVisualStyleBackColor = true;
            this.chBox_Proveedores.CheckedChanged += new System.EventHandler(this.chBox_Proveedores_CheckedChanged);
            // 
            // chBox_MatPri
            // 
            this.chBox_MatPri.AutoSize = true;
            this.chBox_MatPri.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.chBox_MatPri.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_MatPri.Location = new System.Drawing.Point(212, 280);
            this.chBox_MatPri.Name = "chBox_MatPri";
            this.chBox_MatPri.Size = new System.Drawing.Size(136, 21);
            this.chBox_MatPri.TabIndex = 22;
            this.chBox_MatPri.Text = "Materias Primas";
            this.chBox_MatPri.UseVisualStyleBackColor = true;
            this.chBox_MatPri.CheckedChanged += new System.EventHandler(this.chBox_MatPri_CheckedChanged);
            // 
            // chBox_Usuarios
            // 
            this.chBox_Usuarios.AutoSize = true;
            this.chBox_Usuarios.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.chBox_Usuarios.ForeColor = System.Drawing.Color.Cornsilk;
            this.chBox_Usuarios.Location = new System.Drawing.Point(212, 199);
            this.chBox_Usuarios.Name = "chBox_Usuarios";
            this.chBox_Usuarios.Size = new System.Drawing.Size(86, 21);
            this.chBox_Usuarios.TabIndex = 21;
            this.chBox_Usuarios.Text = "Usuarios";
            this.chBox_Usuarios.UseVisualStyleBackColor = true;
            this.chBox_Usuarios.CheckedChanged += new System.EventHandler(this.chBox_Usuarios_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(94, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Permiso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(94, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre Rol ";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(552, 410);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(140, 39);
            this.btn_Guardar.TabIndex = 31;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitRolAlta);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Controls.Add(this.Fabrizzi_logoRoles);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 86);
            this.panel1.TabIndex = 69;
            // 
            // lbl_TitRolAlta
            // 
            this.lbl_TitRolAlta.AutoSize = true;
            this.lbl_TitRolAlta.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitRolAlta.ForeColor = System.Drawing.Color.White;
            this.lbl_TitRolAlta.Location = new System.Drawing.Point(320, 26);
            this.lbl_TitRolAlta.Name = "lbl_TitRolAlta";
            this.lbl_TitRolAlta.Size = new System.Drawing.Size(190, 40);
            this.lbl_TitRolAlta.TabIndex = 66;
            this.lbl_TitRolAlta.Text = "Alta de roles";
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
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chBox_Locales);
            this.Controls.Add(this.chBox_Productos);
            this.Controls.Add(this.cBox_NombreRol);
            this.Controls.Add(this.chBox_Proveedores);
            this.Controls.Add(this.chBox_MatPri);
            this.Controls.Add(this.chBox_Usuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles- Alta";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtp_Fecha;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox chBox_Locales;
        public System.Windows.Forms.CheckBox chBox_Productos;
        public System.Windows.Forms.ComboBox cBox_NombreRol;
        public System.Windows.Forms.CheckBox chBox_Proveedores;
        public System.Windows.Forms.CheckBox chBox_MatPri;
        public System.Windows.Forms.CheckBox chBox_Usuarios;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitRolAlta;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
    }
}