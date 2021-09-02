namespace Fabrizzi_TP_Integrador
{
    partial class ProveedoresListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresListado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitProvList = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.dgv_ListProv = new System.Windows.Forms.DataGridView();
            this.lbl_CUITBuscar = new System.Windows.Forms.Label();
            this.lbl_RazonSocial = new System.Windows.Forms.Label();
            this.tBox_CUITBuscar = new System.Windows.Forms.TextBox();
            this.tBox_RazonSocialBuscar = new System.Windows.Forms.TextBox();
            this.btn_BuscarProv = new System.Windows.Forms.Button();
            this.btn_BajaProv = new System.Windows.Forms.Button();
            this.btn_ModifProv = new System.Windows.Forms.Button();
            this.btn_ImprimirProv = new System.Windows.Forms.Button();
            this.btn_NuevoProv = new System.Windows.Forms.Button();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitProvList);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Controls.Add(this.Fabrizzi_logoRoles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 86);
            this.panel1.TabIndex = 70;
            // 
            // lbl_TitProvList
            // 
            this.lbl_TitProvList.AutoSize = true;
            this.lbl_TitProvList.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitProvList.ForeColor = System.Drawing.Color.White;
            this.lbl_TitProvList.Location = new System.Drawing.Point(344, 26);
            this.lbl_TitProvList.Name = "lbl_TitProvList";
            this.lbl_TitProvList.Size = new System.Drawing.Size(186, 40);
            this.lbl_TitProvList.TabIndex = 66;
            this.lbl_TitProvList.Text = "Proveedores";
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
            // dgv_ListProv
            // 
            this.dgv_ListProv.AllowUserToAddRows = false;
            this.dgv_ListProv.AllowUserToDeleteRows = false;
            this.dgv_ListProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListProv.Location = new System.Drawing.Point(36, 248);
            this.dgv_ListProv.Name = "dgv_ListProv";
            this.dgv_ListProv.ReadOnly = true;
            this.dgv_ListProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListProv.Size = new System.Drawing.Size(777, 154);
            this.dgv_ListProv.TabIndex = 71;
            this.dgv_ListProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListProv_CellContentClick);
            // 
            // lbl_CUITBuscar
            // 
            this.lbl_CUITBuscar.AutoSize = true;
            this.lbl_CUITBuscar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CUITBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_CUITBuscar.Location = new System.Drawing.Point(58, 120);
            this.lbl_CUITBuscar.Name = "lbl_CUITBuscar";
            this.lbl_CUITBuscar.Size = new System.Drawing.Size(43, 17);
            this.lbl_CUITBuscar.TabIndex = 72;
            this.lbl_CUITBuscar.Text = "CUIT:";
            // 
            // lbl_RazonSocial
            // 
            this.lbl_RazonSocial.AutoSize = true;
            this.lbl_RazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RazonSocial.ForeColor = System.Drawing.Color.White;
            this.lbl_RazonSocial.Location = new System.Drawing.Point(58, 162);
            this.lbl_RazonSocial.Name = "lbl_RazonSocial";
            this.lbl_RazonSocial.Size = new System.Drawing.Size(98, 17);
            this.lbl_RazonSocial.TabIndex = 73;
            this.lbl_RazonSocial.Text = "Razón Social:";
            // 
            // tBox_CUITBuscar
            // 
            this.tBox_CUITBuscar.Location = new System.Drawing.Point(107, 120);
            this.tBox_CUITBuscar.Name = "tBox_CUITBuscar";
            this.tBox_CUITBuscar.Size = new System.Drawing.Size(234, 20);
            this.tBox_CUITBuscar.TabIndex = 74;
            this.tBox_CUITBuscar.TextChanged += new System.EventHandler(this.tBox_CUITBuscar_TextChanged);
            // 
            // tBox_RazonSocialBuscar
            // 
            this.tBox_RazonSocialBuscar.Location = new System.Drawing.Point(172, 159);
            this.tBox_RazonSocialBuscar.Name = "tBox_RazonSocialBuscar";
            this.tBox_RazonSocialBuscar.Size = new System.Drawing.Size(234, 20);
            this.tBox_RazonSocialBuscar.TabIndex = 75;
            // 
            // btn_BuscarProv
            // 
            this.btn_BuscarProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BuscarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarProv.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarProv.Location = new System.Drawing.Point(533, 120);
            this.btn_BuscarProv.Name = "btn_BuscarProv";
            this.btn_BuscarProv.Size = new System.Drawing.Size(140, 39);
            this.btn_BuscarProv.TabIndex = 76;
            this.btn_BuscarProv.Text = "Buscar";
            this.btn_BuscarProv.UseVisualStyleBackColor = false;
            this.btn_BuscarProv.Click += new System.EventHandler(this.btn_BuscarProv_Click);
            // 
            // btn_BajaProv
            // 
            this.btn_BajaProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BajaProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BajaProv.ForeColor = System.Drawing.Color.White;
            this.btn_BajaProv.Location = new System.Drawing.Point(510, 438);
            this.btn_BajaProv.Name = "btn_BajaProv";
            this.btn_BajaProv.Size = new System.Drawing.Size(140, 39);
            this.btn_BajaProv.TabIndex = 80;
            this.btn_BajaProv.Text = "Dar de baja Proveedor";
            this.btn_BajaProv.UseVisualStyleBackColor = false;
            this.btn_BajaProv.Click += new System.EventHandler(this.btn_BajaProv_Click_1);
            // 
            // btn_ModifProv
            // 
            this.btn_ModifProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ModifProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifProv.ForeColor = System.Drawing.Color.White;
            this.btn_ModifProv.Location = new System.Drawing.Point(351, 438);
            this.btn_ModifProv.Name = "btn_ModifProv";
            this.btn_ModifProv.Size = new System.Drawing.Size(140, 39);
            this.btn_ModifProv.TabIndex = 79;
            this.btn_ModifProv.Text = "Modificar Proveedor";
            this.btn_ModifProv.UseVisualStyleBackColor = false;
            this.btn_ModifProv.Click += new System.EventHandler(this.btn_ModifProv_Click);
            // 
            // btn_ImprimirProv
            // 
            this.btn_ImprimirProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ImprimirProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirProv.ForeColor = System.Drawing.Color.White;
            this.btn_ImprimirProv.Location = new System.Drawing.Point(676, 438);
            this.btn_ImprimirProv.Name = "btn_ImprimirProv";
            this.btn_ImprimirProv.Size = new System.Drawing.Size(140, 39);
            this.btn_ImprimirProv.TabIndex = 78;
            this.btn_ImprimirProv.Text = "Imprimir";
            this.btn_ImprimirProv.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoProv
            // 
            this.btn_NuevoProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_NuevoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoProv.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoProv.Location = new System.Drawing.Point(183, 438);
            this.btn_NuevoProv.Name = "btn_NuevoProv";
            this.btn_NuevoProv.Size = new System.Drawing.Size(140, 39);
            this.btn_NuevoProv.TabIndex = 77;
            this.btn_NuevoProv.Text = "Nuevo Proveedor";
            this.btn_NuevoProv.UseVisualStyleBackColor = false;
            this.btn_NuevoProv.Click += new System.EventHandler(this.btn_NuevoProv_Click);
            // 
            // Fabrizzi_logoRoles
            // 
            this.Fabrizzi_logoRoles.BackColor = System.Drawing.Color.Transparent;
            this.Fabrizzi_logoRoles.Image = ((System.Drawing.Image)(resources.GetObject("Fabrizzi_logoRoles.Image")));
            this.Fabrizzi_logoRoles.Location = new System.Drawing.Point(0, -1);
            this.Fabrizzi_logoRoles.Name = "Fabrizzi_logoRoles";
            this.Fabrizzi_logoRoles.Size = new System.Drawing.Size(241, 87);
            this.Fabrizzi_logoRoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fabrizzi_logoRoles.TabIndex = 64;
            this.Fabrizzi_logoRoles.TabStop = false;
            // 
            // ProveedoresListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.btn_BajaProv);
            this.Controls.Add(this.btn_ModifProv);
            this.Controls.Add(this.btn_ImprimirProv);
            this.Controls.Add(this.btn_NuevoProv);
            this.Controls.Add(this.btn_BuscarProv);
            this.Controls.Add(this.tBox_RazonSocialBuscar);
            this.Controls.Add(this.tBox_CUITBuscar);
            this.Controls.Add(this.lbl_RazonSocial);
            this.Controls.Add(this.lbl_CUITBuscar);
            this.Controls.Add(this.dgv_ListProv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProveedoresListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProveedoresListado";
            this.Load += new System.EventHandler(this.ProveedoresListado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitProvList;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        private System.Windows.Forms.DataGridView dgv_ListProv;
        public System.Windows.Forms.Label lbl_CUITBuscar;
        public System.Windows.Forms.Label lbl_RazonSocial;
        private System.Windows.Forms.TextBox tBox_CUITBuscar;
        private System.Windows.Forms.TextBox tBox_RazonSocialBuscar;
        private System.Windows.Forms.Button btn_BuscarProv;
        public System.Windows.Forms.Button btn_BajaProv;
        public System.Windows.Forms.Button btn_ModifProv;
        private System.Windows.Forms.Button btn_ImprimirProv;
        private System.Windows.Forms.Button btn_NuevoProv;
    }
}