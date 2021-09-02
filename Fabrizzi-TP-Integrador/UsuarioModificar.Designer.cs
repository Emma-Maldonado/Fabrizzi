
namespace Fabrizzi_TP_Integrador
{
    partial class UsuarioModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioModificar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitUsu = new System.Windows.Forms.Label();
            this.btn_CerrarUsuList = new System.Windows.Forms.Button();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_RolBuscar = new System.Windows.Forms.Label();
            this.cBox_RolBuscar = new System.Windows.Forms.ComboBox();
            this.DgvModifUsu = new System.Windows.Forms.DataGridView();
            this.cbox_AreaParaUsu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GuardarModRol = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModifUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitUsu);
            this.panel1.Controls.Add(this.btn_CerrarUsuList);
            this.panel1.Controls.Add(this.Fabrizzi_logoRoles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 86);
            this.panel1.TabIndex = 68;
            // 
            // lbl_TitUsu
            // 
            this.lbl_TitUsu.AutoSize = true;
            this.lbl_TitUsu.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitUsu.ForeColor = System.Drawing.Color.White;
            this.lbl_TitUsu.Location = new System.Drawing.Point(384, 23);
            this.lbl_TitUsu.Name = "lbl_TitUsu";
            this.lbl_TitUsu.Size = new System.Drawing.Size(134, 40);
            this.lbl_TitUsu.TabIndex = 66;
            this.lbl_TitUsu.Text = "Usuarios";
            // 
            // btn_CerrarUsuList
            // 
            this.btn_CerrarUsuList.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CerrarUsuList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_CerrarUsuList.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarUsuList.Location = new System.Drawing.Point(771, 23);
            this.btn_CerrarUsuList.Name = "btn_CerrarUsuList";
            this.btn_CerrarUsuList.Size = new System.Drawing.Size(39, 23);
            this.btn_CerrarUsuList.TabIndex = 65;
            this.btn_CerrarUsuList.Text = "X";
            this.btn_CerrarUsuList.UseVisualStyleBackColor = false;
            this.btn_CerrarUsuList.Click += new System.EventHandler(this.btn_CerrarUsuList_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(191, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Cargar nuevo";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(259, 368);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(26, 13);
            this.linkLabel1.TabIndex = 84;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Rol ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_RolBuscar
            // 
            this.lbl_RolBuscar.AutoSize = true;
            this.lbl_RolBuscar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RolBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_RolBuscar.Location = new System.Drawing.Point(109, 333);
            this.lbl_RolBuscar.Name = "lbl_RolBuscar";
            this.lbl_RolBuscar.Size = new System.Drawing.Size(30, 17);
            this.lbl_RolBuscar.TabIndex = 83;
            this.lbl_RolBuscar.Text = "Rol";
            // 
            // cBox_RolBuscar
            // 
            this.cBox_RolBuscar.FormattingEnabled = true;
            this.cBox_RolBuscar.Items.AddRange(new object[] {
            "Seleccione",
            "Empleado",
            "Encargado",
            "Supervisor"});
            this.cBox_RolBuscar.Location = new System.Drawing.Point(173, 329);
            this.cBox_RolBuscar.Name = "cBox_RolBuscar";
            this.cBox_RolBuscar.Size = new System.Drawing.Size(494, 21);
            this.cBox_RolBuscar.TabIndex = 82;
            this.cBox_RolBuscar.SelectedIndexChanged += new System.EventHandler(this.cBox_RolBuscar_SelectedIndexChanged);
            // 
            // DgvModifUsu
            // 
            this.DgvModifUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvModifUsu.Location = new System.Drawing.Point(44, 110);
            this.DgvModifUsu.Name = "DgvModifUsu";
            this.DgvModifUsu.Size = new System.Drawing.Size(750, 80);
            this.DgvModifUsu.TabIndex = 81;
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
            this.cbox_AreaParaUsu.Location = new System.Drawing.Point(173, 272);
            this.cbox_AreaParaUsu.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_AreaParaUsu.Name = "cbox_AreaParaUsu";
            this.cbox_AreaParaUsu.Size = new System.Drawing.Size(173, 21);
            this.cbox_AreaParaUsu.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(100, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Área";
            // 
            // btn_GuardarModRol
            // 
            this.btn_GuardarModRol.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GuardarModRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GuardarModRol.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarModRol.Location = new System.Drawing.Point(672, 399);
            this.btn_GuardarModRol.Name = "btn_GuardarModRol";
            this.btn_GuardarModRol.Size = new System.Drawing.Size(140, 39);
            this.btn_GuardarModRol.TabIndex = 78;
            this.btn_GuardarModRol.Text = "Guardar";
            this.btn_GuardarModRol.UseVisualStyleBackColor = false;
            this.btn_GuardarModRol.Click += new System.EventHandler(this.btn_GuardarModRol_Click);
            // 
            // UsuarioModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(844, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_RolBuscar);
            this.Controls.Add(this.cBox_RolBuscar);
            this.Controls.Add(this.DgvModifUsu);
            this.Controls.Add(this.cbox_AreaParaUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_GuardarModRol);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioModificar";
            this.Load += new System.EventHandler(this.UsuarioModificar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModifUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitUsu;
        private System.Windows.Forms.Button btn_CerrarUsuList;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label lbl_RolBuscar;
        public System.Windows.Forms.ComboBox cBox_RolBuscar;
        public System.Windows.Forms.DataGridView DgvModifUsu;
        public System.Windows.Forms.ComboBox cbox_AreaParaUsu;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GuardarModRol;
    }
}