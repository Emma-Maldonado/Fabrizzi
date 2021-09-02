namespace Fabrizzi_TP_Integrador
{
    partial class ProveedoresModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresModificar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitProv = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.tBox_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_EmailMod = new System.Windows.Forms.Label();
            this.lbl_TelMod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_direccionMod = new System.Windows.Forms.DataGridView();
            this.btn_GuardarPorvMod = new System.Windows.Forms.Button();
            this.linklbl_DireccionMod = new System.Windows.Forms.LinkLabel();
            this.dgv_ProvListMod = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direccionMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProvListMod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitProv);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Controls.Add(this.Fabrizzi_logoRoles);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 86);
            this.panel1.TabIndex = 70;
            // 
            // lbl_TitProv
            // 
            this.lbl_TitProv.AutoSize = true;
            this.lbl_TitProv.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitProv.ForeColor = System.Drawing.Color.White;
            this.lbl_TitProv.Location = new System.Drawing.Point(320, 26);
            this.lbl_TitProv.Name = "lbl_TitProv";
            this.lbl_TitProv.Size = new System.Drawing.Size(297, 40);
            this.lbl_TitProv.TabIndex = 66;
            this.lbl_TitProv.Text = "Modificar proveedor";
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
            // tBox_Email
            // 
            this.tBox_Email.Location = new System.Drawing.Point(444, 223);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(356, 20);
            this.tBox_Email.TabIndex = 81;
            // 
            // tBox_Telefono
            // 
            this.tBox_Telefono.Location = new System.Drawing.Point(163, 223);
            this.tBox_Telefono.Name = "tBox_Telefono";
            this.tBox_Telefono.Size = new System.Drawing.Size(195, 20);
            this.tBox_Telefono.TabIndex = 80;
            // 
            // lbl_EmailMod
            // 
            this.lbl_EmailMod.AutoSize = true;
            this.lbl_EmailMod.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_EmailMod.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_EmailMod.Location = new System.Drawing.Point(383, 226);
            this.lbl_EmailMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EmailMod.Name = "lbl_EmailMod";
            this.lbl_EmailMod.Size = new System.Drawing.Size(54, 17);
            this.lbl_EmailMod.TabIndex = 79;
            this.lbl_EmailMod.Text = "E-mail:";
            // 
            // lbl_TelMod
            // 
            this.lbl_TelMod.AutoSize = true;
            this.lbl_TelMod.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_TelMod.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_TelMod.Location = new System.Drawing.Point(74, 226);
            this.lbl_TelMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TelMod.Name = "lbl_TelMod";
            this.lbl_TelMod.Size = new System.Drawing.Size(71, 17);
            this.lbl_TelMod.TabIndex = 78;
            this.lbl_TelMod.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(154, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "<-- Click en el nombre";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(311, 386);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 87;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "aquí.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(74, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Para visualizar la dirección ingresada, hacer click";
            // 
            // dgv_direccionMod
            // 
            this.dgv_direccionMod.AllowUserToAddRows = false;
            this.dgv_direccionMod.AllowUserToDeleteRows = false;
            this.dgv_direccionMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_direccionMod.Location = new System.Drawing.Point(77, 304);
            this.dgv_direccionMod.Name = "dgv_direccionMod";
            this.dgv_direccionMod.ReadOnly = true;
            this.dgv_direccionMod.Size = new System.Drawing.Size(723, 79);
            this.dgv_direccionMod.TabIndex = 85;
            // 
            // btn_GuardarPorvMod
            // 
            this.btn_GuardarPorvMod.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GuardarPorvMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GuardarPorvMod.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarPorvMod.Location = new System.Drawing.Point(660, 428);
            this.btn_GuardarPorvMod.Name = "btn_GuardarPorvMod";
            this.btn_GuardarPorvMod.Size = new System.Drawing.Size(140, 39);
            this.btn_GuardarPorvMod.TabIndex = 84;
            this.btn_GuardarPorvMod.Text = "Guardar";
            this.btn_GuardarPorvMod.UseVisualStyleBackColor = false;
            this.btn_GuardarPorvMod.Click += new System.EventHandler(this.btn_GuardarPorvMod_Click);
            // 
            // linklbl_DireccionMod
            // 
            this.linklbl_DireccionMod.AutoSize = true;
            this.linklbl_DireccionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_DireccionMod.LinkColor = System.Drawing.Color.White;
            this.linklbl_DireccionMod.Location = new System.Drawing.Point(74, 275);
            this.linklbl_DireccionMod.Name = "linklbl_DireccionMod";
            this.linklbl_DireccionMod.Size = new System.Drawing.Size(74, 16);
            this.linklbl_DireccionMod.TabIndex = 83;
            this.linklbl_DireccionMod.TabStop = true;
            this.linklbl_DireccionMod.Text = "Direccion";
            this.linklbl_DireccionMod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_DireccionMod_LinkClicked);
            // 
            // dgv_ProvListMod
            // 
            this.dgv_ProvListMod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProvListMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProvListMod.Location = new System.Drawing.Point(75, 115);
            this.dgv_ProvListMod.Name = "dgv_ProvListMod";
            this.dgv_ProvListMod.Size = new System.Drawing.Size(724, 66);
            this.dgv_ProvListMod.TabIndex = 89;
            // 
            // ProveedoresModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.dgv_ProvListMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_direccionMod);
            this.Controls.Add(this.btn_GuardarPorvMod);
            this.Controls.Add(this.linklbl_DireccionMod);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.tBox_Telefono);
            this.Controls.Add(this.lbl_EmailMod);
            this.Controls.Add(this.lbl_TelMod);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProveedoresModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProveedoresModificar";
            this.Load += new System.EventHandler(this.ProveedoresModificar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direccionMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProvListMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitProv;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        private System.Windows.Forms.TextBox tBox_Email;
        private System.Windows.Forms.TextBox tBox_Telefono;
        public System.Windows.Forms.Label lbl_EmailMod;
        public System.Windows.Forms.Label lbl_TelMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_direccionMod;
        public System.Windows.Forms.Button btn_GuardarPorvMod;
        private System.Windows.Forms.LinkLabel linklbl_DireccionMod;
        public System.Windows.Forms.DataGridView dgv_ProvListMod;
    }
}