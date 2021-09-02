namespace Fabrizzi_TP_Integrador
{
    partial class Usuarios_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_Alta));
            this.label8 = new System.Windows.Forms.Label();
            this.tBox_DNIusu = new System.Windows.Forms.TextBox();
            this.cbox_RolUserAlta = new System.Windows.Forms.ComboBox();
            this.tBox_NombreUsu = new System.Windows.Forms.TextBox();
            this.dtp_FechaAltaUsu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_ApellidoUsu = new System.Windows.Forms.TextBox();
            this.btn_GuardarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_AreaParaUsu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitUsu = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(103, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "DNI";
            // 
            // tBox_DNIusu
            // 
            this.tBox_DNIusu.Location = new System.Drawing.Point(189, 170);
            this.tBox_DNIusu.Margin = new System.Windows.Forms.Padding(4);
            this.tBox_DNIusu.MaxLength = 9;
            this.tBox_DNIusu.Name = "tBox_DNIusu";
            this.tBox_DNIusu.Size = new System.Drawing.Size(125, 25);
            this.tBox_DNIusu.TabIndex = 28;
            // 
            // cbox_RolUserAlta
            // 
            this.cbox_RolUserAlta.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_RolUserAlta.FormattingEnabled = true;
            this.cbox_RolUserAlta.Items.AddRange(new object[] {
            "Seleccione",
            "Supervisor",
            "Encargado",
            "Empleado"});
            this.cbox_RolUserAlta.Location = new System.Drawing.Point(189, 300);
            this.cbox_RolUserAlta.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_RolUserAlta.Name = "cbox_RolUserAlta";
            this.cbox_RolUserAlta.Size = new System.Drawing.Size(493, 21);
            this.cbox_RolUserAlta.TabIndex = 27;
            this.cbox_RolUserAlta.SelectedIndexChanged += new System.EventHandler(this.cbox_RolUserAlta_SelectedIndexChanged);
            // 
            // tBox_NombreUsu
            // 
            this.tBox_NombreUsu.Location = new System.Drawing.Point(504, 113);
            this.tBox_NombreUsu.Margin = new System.Windows.Forms.Padding(4);
            this.tBox_NombreUsu.Name = "tBox_NombreUsu";
            this.tBox_NombreUsu.Size = new System.Drawing.Size(178, 25);
            this.tBox_NombreUsu.TabIndex = 26;
            // 
            // dtp_FechaAltaUsu
            // 
            this.dtp_FechaAltaUsu.Enabled = false;
            this.dtp_FechaAltaUsu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaAltaUsu.Location = new System.Drawing.Point(504, 172);
            this.dtp_FechaAltaUsu.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_FechaAltaUsu.Name = "dtp_FechaAltaUsu";
            this.dtp_FechaAltaUsu.Size = new System.Drawing.Size(178, 25);
            this.dtp_FechaAltaUsu.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(103, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(417, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha Alta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(417, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(103, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Apellido";
            // 
            // tBox_ApellidoUsu
            // 
            this.tBox_ApellidoUsu.Location = new System.Drawing.Point(189, 117);
            this.tBox_ApellidoUsu.Margin = new System.Windows.Forms.Padding(4);
            this.tBox_ApellidoUsu.Name = "tBox_ApellidoUsu";
            this.tBox_ApellidoUsu.Size = new System.Drawing.Size(178, 25);
            this.tBox_ApellidoUsu.TabIndex = 20;
            // 
            // btn_GuardarUsuario
            // 
            this.btn_GuardarUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GuardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GuardarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarUsuario.Location = new System.Drawing.Point(540, 417);
            this.btn_GuardarUsuario.Name = "btn_GuardarUsuario";
            this.btn_GuardarUsuario.Size = new System.Drawing.Size(140, 39);
            this.btn_GuardarUsuario.TabIndex = 31;
            this.btn_GuardarUsuario.Text = "Guardar";
            this.btn_GuardarUsuario.UseVisualStyleBackColor = false;
            this.btn_GuardarUsuario.Click += new System.EventHandler(this.btn_GuardarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(103, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Área";
            // 
            // cbox_AreaParaUsu
            // 
            this.cbox_AreaParaUsu.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_AreaParaUsu.FormattingEnabled = true;
            this.cbox_AreaParaUsu.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Depósito",
            "Fábrica",
            "Ventas"});
            this.cbox_AreaParaUsu.Location = new System.Drawing.Point(189, 235);
            this.cbox_AreaParaUsu.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_AreaParaUsu.Name = "cbox_AreaParaUsu";
            this.cbox_AreaParaUsu.Size = new System.Drawing.Size(173, 21);
            this.cbox_AreaParaUsu.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitUsu);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Controls.Add(this.Fabrizzi_logoRoles);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 86);
            this.panel1.TabIndex = 68;
            // 
            // lbl_TitUsu
            // 
            this.lbl_TitUsu.AutoSize = true;
            this.lbl_TitUsu.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitUsu.ForeColor = System.Drawing.Color.White;
            this.lbl_TitUsu.Location = new System.Drawing.Point(320, 26);
            this.lbl_TitUsu.Name = "lbl_TitUsu";
            this.lbl_TitUsu.Size = new System.Drawing.Size(237, 40);
            this.lbl_TitUsu.TabIndex = 66;
            this.lbl_TitUsu.Text = "Alta de usuarios";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(186, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Ingrese DNI sin puntos.";
            // 
            // Usuarios_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbox_AreaParaUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_GuardarUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBox_DNIusu);
            this.Controls.Add(this.cbox_RolUserAlta);
            this.Controls.Add(this.tBox_NombreUsu);
            this.Controls.Add(this.dtp_FechaAltaUsu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_ApellidoUsu);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuarios_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios_Alta";
            this.Load += new System.EventHandler(this.Usuarios_Alta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tBox_DNIusu;
        public System.Windows.Forms.ComboBox cbox_RolUserAlta;
        public System.Windows.Forms.TextBox tBox_NombreUsu;
        public System.Windows.Forms.DateTimePicker dtp_FechaAltaUsu;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBox_ApellidoUsu;
        public System.Windows.Forms.Button btn_GuardarUsuario;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbox_AreaParaUsu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitUsu;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        private System.Windows.Forms.Label label5;
    }
}