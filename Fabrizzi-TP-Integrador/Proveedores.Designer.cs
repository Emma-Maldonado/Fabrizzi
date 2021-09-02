namespace Fabrizzi_TP_Integrador
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.linklbl_Direccion = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitProv = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.lbl_CUIT = new System.Windows.Forms.Label();
            this.lbl_RazonSocial = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tBox_CUIT = new System.Windows.Forms.TextBox();
            this.tBox_RazonSocial = new System.Windows.Forms.TextBox();
            this.tBox_Telefono = new System.Windows.Forms.TextBox();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.btn_GuardarProv = new System.Windows.Forms.Button();
            this.dgv_direccionIngresada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direccionIngresada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl_Direccion
            // 
            this.linklbl_Direccion.AutoSize = true;
            this.linklbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_Direccion.LinkColor = System.Drawing.Color.White;
            this.linklbl_Direccion.Location = new System.Drawing.Point(89, 295);
            this.linklbl_Direccion.Name = "linklbl_Direccion";
            this.linklbl_Direccion.Size = new System.Drawing.Size(84, 16);
            this.linklbl_Direccion.TabIndex = 0;
            this.linklbl_Direccion.TabStop = true;
            this.linklbl_Direccion.Text = "* Direccion";
            this.linklbl_Direccion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Direccion_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitProv);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Controls.Add(this.Fabrizzi_logoRoles);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 86);
            this.panel1.TabIndex = 69;
            // 
            // lbl_TitProv
            // 
            this.lbl_TitProv.AutoSize = true;
            this.lbl_TitProv.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitProv.ForeColor = System.Drawing.Color.White;
            this.lbl_TitProv.Location = new System.Drawing.Point(320, 26);
            this.lbl_TitProv.Name = "lbl_TitProv";
            this.lbl_TitProv.Size = new System.Drawing.Size(294, 40);
            this.lbl_TitProv.TabIndex = 66;
            this.lbl_TitProv.Text = "Alta de proveedores";
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
            // lbl_CUIT
            // 
            this.lbl_CUIT.AutoSize = true;
            this.lbl_CUIT.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CUIT.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_CUIT.Location = new System.Drawing.Point(89, 135);
            this.lbl_CUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CUIT.Name = "lbl_CUIT";
            this.lbl_CUIT.Size = new System.Drawing.Size(54, 17);
            this.lbl_CUIT.TabIndex = 70;
            this.lbl_CUIT.Text = "* CUIT:";
            // 
            // lbl_RazonSocial
            // 
            this.lbl_RazonSocial.AutoSize = true;
            this.lbl_RazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RazonSocial.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_RazonSocial.Location = new System.Drawing.Point(365, 132);
            this.lbl_RazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RazonSocial.Name = "lbl_RazonSocial";
            this.lbl_RazonSocial.Size = new System.Drawing.Size(109, 17);
            this.lbl_RazonSocial.TabIndex = 71;
            this.lbl_RazonSocial.Text = "* Razón Social:";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Tel.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Tel.Location = new System.Drawing.Point(89, 232);
            this.lbl_Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(71, 17);
            this.lbl_Tel.TabIndex = 72;
            this.lbl_Tel.Text = "Teléfono:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Email.Location = new System.Drawing.Point(398, 232);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(54, 17);
            this.lbl_Email.TabIndex = 73;
            this.lbl_Email.Text = "E-mail:";
            // 
            // tBox_CUIT
            // 
            this.tBox_CUIT.Location = new System.Drawing.Point(157, 132);
            this.tBox_CUIT.Name = "tBox_CUIT";
            this.tBox_CUIT.Size = new System.Drawing.Size(195, 20);
            this.tBox_CUIT.TabIndex = 74;
            // 
            // tBox_RazonSocial
            // 
            this.tBox_RazonSocial.Location = new System.Drawing.Point(481, 129);
            this.tBox_RazonSocial.Name = "tBox_RazonSocial";
            this.tBox_RazonSocial.Size = new System.Drawing.Size(334, 20);
            this.tBox_RazonSocial.TabIndex = 75;
            // 
            // tBox_Telefono
            // 
            this.tBox_Telefono.Location = new System.Drawing.Point(178, 229);
            this.tBox_Telefono.Name = "tBox_Telefono";
            this.tBox_Telefono.Size = new System.Drawing.Size(195, 20);
            this.tBox_Telefono.TabIndex = 76;
            // 
            // tBox_Email
            // 
            this.tBox_Email.Location = new System.Drawing.Point(459, 229);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(356, 20);
            this.tBox_Email.TabIndex = 77;
            // 
            // btn_GuardarProv
            // 
            this.btn_GuardarProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GuardarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GuardarProv.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarProv.Location = new System.Drawing.Point(675, 448);
            this.btn_GuardarProv.Name = "btn_GuardarProv";
            this.btn_GuardarProv.Size = new System.Drawing.Size(140, 39);
            this.btn_GuardarProv.TabIndex = 78;
            this.btn_GuardarProv.Text = "Guardar";
            this.btn_GuardarProv.UseVisualStyleBackColor = false;
            this.btn_GuardarProv.Click += new System.EventHandler(this.btn_GuardarUsuario_Click);
            // 
            // dgv_direccionIngresada
            // 
            this.dgv_direccionIngresada.AllowUserToAddRows = false;
            this.dgv_direccionIngresada.AllowUserToDeleteRows = false;
            this.dgv_direccionIngresada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_direccionIngresada.Location = new System.Drawing.Point(92, 324);
            this.dgv_direccionIngresada.Name = "dgv_direccionIngresada";
            this.dgv_direccionIngresada.ReadOnly = true;
            this.dgv_direccionIngresada.Size = new System.Drawing.Size(723, 79);
            this.dgv_direccionIngresada.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(89, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Para visualizar la dirección ingresada, hacer click";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(326, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 81;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "aquí.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(169, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "<-- Click en el nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(154, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "* Ingrese dato sin guiones (-)";
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
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_direccionIngresada);
            this.Controls.Add(this.btn_GuardarProv);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.tBox_Telefono);
            this.Controls.Add(this.tBox_RazonSocial);
            this.Controls.Add(this.tBox_CUIT);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_RazonSocial);
            this.Controls.Add(this.lbl_CUIT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linklbl_Direccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direccionIngresada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbl_Direccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitProv;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        public System.Windows.Forms.Label lbl_CUIT;
        public System.Windows.Forms.Label lbl_RazonSocial;
        public System.Windows.Forms.Label lbl_Tel;
        public System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tBox_CUIT;
        private System.Windows.Forms.TextBox tBox_RazonSocial;
        private System.Windows.Forms.TextBox tBox_Telefono;
        private System.Windows.Forms.TextBox tBox_Email;
        public System.Windows.Forms.Button btn_GuardarProv;
        public System.Windows.Forms.DataGridView dgv_direccionIngresada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}