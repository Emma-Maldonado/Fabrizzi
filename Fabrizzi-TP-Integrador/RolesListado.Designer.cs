namespace Fabrizzi_TP_Integrador
{
    partial class RolesListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesListado));
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_RolBuscar = new System.Windows.Forms.Label();
            this.cBox_EstadoRolBuscar = new System.Windows.Forms.ComboBox();
            this.cBox_RolBuscar = new System.Windows.Forms.ComboBox();
            this.Dgv_Roles = new System.Windows.Forms.DataGridView();
            this.btn_NuevoRol = new System.Windows.Forms.Button();
            this.btn_BuscarRol = new System.Windows.Forms.Button();
            this.btn_ImprimirRol = new System.Windows.Forms.Button();
            this.btn_ModifRol = new System.Windows.Forms.Button();
            this.btn_BajaRol = new System.Windows.Forms.Button();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.btn_CerrarRolesList = new System.Windows.Forms.Button();
            this.Panel_RolesList = new System.Windows.Forms.Panel();
            this.lbl_TitRoles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            this.Panel_RolesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Estado:";
            // 
            // lbl_RolBuscar
            // 
            this.lbl_RolBuscar.AutoSize = true;
            this.lbl_RolBuscar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RolBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_RolBuscar.Location = new System.Drawing.Point(34, 137);
            this.lbl_RolBuscar.Name = "lbl_RolBuscar";
            this.lbl_RolBuscar.Size = new System.Drawing.Size(39, 17);
            this.lbl_RolBuscar.TabIndex = 55;
            this.lbl_RolBuscar.Text = "Rol: ";
            // 
            // cBox_EstadoRolBuscar
            // 
            this.cBox_EstadoRolBuscar.FormattingEnabled = true;
            this.cBox_EstadoRolBuscar.Items.AddRange(new object[] {
            "Seleccione",
            "Activo",
            "Inactivo"});
            this.cBox_EstadoRolBuscar.Location = new System.Drawing.Point(128, 181);
            this.cBox_EstadoRolBuscar.Name = "cBox_EstadoRolBuscar";
            this.cBox_EstadoRolBuscar.Size = new System.Drawing.Size(157, 21);
            this.cBox_EstadoRolBuscar.TabIndex = 54;
            // 
            // cBox_RolBuscar
            // 
            this.cBox_RolBuscar.FormattingEnabled = true;
            this.cBox_RolBuscar.Items.AddRange(new object[] {
            "Seleccione",
            "Empleado",
            "Encargado",
            "Supervisor"});
            this.cBox_RolBuscar.Location = new System.Drawing.Point(128, 137);
            this.cBox_RolBuscar.Name = "cBox_RolBuscar";
            this.cBox_RolBuscar.Size = new System.Drawing.Size(157, 21);
            this.cBox_RolBuscar.TabIndex = 53;
            // 
            // Dgv_Roles
            // 
            this.Dgv_Roles.AllowUserToAddRows = false;
            this.Dgv_Roles.AllowUserToDeleteRows = false;
            this.Dgv_Roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Roles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_Roles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Roles.Location = new System.Drawing.Point(12, 272);
            this.Dgv_Roles.Name = "Dgv_Roles";
            this.Dgv_Roles.ReadOnly = true;
            this.Dgv_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Roles.Size = new System.Drawing.Size(836, 150);
            this.Dgv_Roles.TabIndex = 45;
            this.Dgv_Roles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Roles_CellContentClick);
            // 
            // btn_NuevoRol
            // 
            this.btn_NuevoRol.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_NuevoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoRol.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoRol.Location = new System.Drawing.Point(213, 445);
            this.btn_NuevoRol.Name = "btn_NuevoRol";
            this.btn_NuevoRol.Size = new System.Drawing.Size(140, 39);
            this.btn_NuevoRol.TabIndex = 57;
            this.btn_NuevoRol.Text = "Nuevo Rol";
            this.btn_NuevoRol.UseVisualStyleBackColor = false;
            this.btn_NuevoRol.Click += new System.EventHandler(this.btn_NuevoRol_Click);
            // 
            // btn_BuscarRol
            // 
            this.btn_BuscarRol.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BuscarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarRol.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarRol.Location = new System.Drawing.Point(338, 137);
            this.btn_BuscarRol.Name = "btn_BuscarRol";
            this.btn_BuscarRol.Size = new System.Drawing.Size(140, 39);
            this.btn_BuscarRol.TabIndex = 59;
            this.btn_BuscarRol.Text = "Buscar";
            this.btn_BuscarRol.UseVisualStyleBackColor = false;
            this.btn_BuscarRol.Click += new System.EventHandler(this.btn_BuscarRol_Click);
            // 
            // btn_ImprimirRol
            // 
            this.btn_ImprimirRol.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ImprimirRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirRol.ForeColor = System.Drawing.Color.White;
            this.btn_ImprimirRol.Location = new System.Drawing.Point(706, 445);
            this.btn_ImprimirRol.Name = "btn_ImprimirRol";
            this.btn_ImprimirRol.Size = new System.Drawing.Size(140, 39);
            this.btn_ImprimirRol.TabIndex = 60;
            this.btn_ImprimirRol.Text = "Imprimir";
            this.btn_ImprimirRol.UseVisualStyleBackColor = false;
            // 
            // btn_ModifRol
            // 
            this.btn_ModifRol.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ModifRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifRol.ForeColor = System.Drawing.Color.White;
            this.btn_ModifRol.Location = new System.Drawing.Point(381, 445);
            this.btn_ModifRol.Name = "btn_ModifRol";
            this.btn_ModifRol.Size = new System.Drawing.Size(140, 39);
            this.btn_ModifRol.TabIndex = 61;
            this.btn_ModifRol.Text = "Modificar Rol";
            this.btn_ModifRol.UseVisualStyleBackColor = false;
            this.btn_ModifRol.Click += new System.EventHandler(this.btn_ModifRol_Click);
            // 
            // btn_BajaRol
            // 
            this.btn_BajaRol.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BajaRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BajaRol.ForeColor = System.Drawing.Color.White;
            this.btn_BajaRol.Location = new System.Drawing.Point(540, 445);
            this.btn_BajaRol.Name = "btn_BajaRol";
            this.btn_BajaRol.Size = new System.Drawing.Size(140, 39);
            this.btn_BajaRol.TabIndex = 62;
            this.btn_BajaRol.Text = "Dar de baja Rol";
            this.btn_BajaRol.UseVisualStyleBackColor = false;
            this.btn_BajaRol.Click += new System.EventHandler(this.btn_BajaRol_Click);
            // 
            // Fabrizzi_logoRoles
            // 
            this.Fabrizzi_logoRoles.BackColor = System.Drawing.Color.Transparent;
            this.Fabrizzi_logoRoles.Image = ((System.Drawing.Image)(resources.GetObject("Fabrizzi_logoRoles.Image")));
            this.Fabrizzi_logoRoles.Location = new System.Drawing.Point(0, 0);
            this.Fabrizzi_logoRoles.Name = "Fabrizzi_logoRoles";
            this.Fabrizzi_logoRoles.Size = new System.Drawing.Size(241, 82);
            this.Fabrizzi_logoRoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fabrizzi_logoRoles.TabIndex = 63;
            this.Fabrizzi_logoRoles.TabStop = false;
            // 
            // btn_CerrarRolesList
            // 
            this.btn_CerrarRolesList.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CerrarRolesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_CerrarRolesList.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarRolesList.Location = new System.Drawing.Point(764, 20);
            this.btn_CerrarRolesList.Name = "btn_CerrarRolesList";
            this.btn_CerrarRolesList.Size = new System.Drawing.Size(39, 23);
            this.btn_CerrarRolesList.TabIndex = 64;
            this.btn_CerrarRolesList.Text = "X";
            this.btn_CerrarRolesList.UseVisualStyleBackColor = false;
            this.btn_CerrarRolesList.Click += new System.EventHandler(this.btn_CerrarRolesList_Click);
            // 
            // Panel_RolesList
            // 
            this.Panel_RolesList.BackColor = System.Drawing.Color.Black;
            this.Panel_RolesList.Controls.Add(this.lbl_TitRoles);
            this.Panel_RolesList.Controls.Add(this.btn_CerrarRolesList);
            this.Panel_RolesList.Controls.Add(this.Fabrizzi_logoRoles);
            this.Panel_RolesList.Location = new System.Drawing.Point(0, 1);
            this.Panel_RolesList.Name = "Panel_RolesList";
            this.Panel_RolesList.Size = new System.Drawing.Size(861, 82);
            this.Panel_RolesList.TabIndex = 65;
            // 
            // lbl_TitRoles
            // 
            this.lbl_TitRoles.AutoSize = true;
            this.lbl_TitRoles.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitRoles.ForeColor = System.Drawing.Color.White;
            this.lbl_TitRoles.Location = new System.Drawing.Point(388, 20);
            this.lbl_TitRoles.Name = "lbl_TitRoles";
            this.lbl_TitRoles.Size = new System.Drawing.Size(90, 40);
            this.lbl_TitRoles.TabIndex = 65;
            this.lbl_TitRoles.Text = "Roles";
            // 
            // RolesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.Panel_RolesList);
            this.Controls.Add(this.btn_BajaRol);
            this.Controls.Add(this.btn_ModifRol);
            this.Controls.Add(this.btn_ImprimirRol);
            this.Controls.Add(this.btn_BuscarRol);
            this.Controls.Add(this.btn_NuevoRol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_RolBuscar);
            this.Controls.Add(this.cBox_EstadoRolBuscar);
            this.Controls.Add(this.cBox_RolBuscar);
            this.Controls.Add(this.Dgv_Roles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RolesListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RolesListado";
            this.Load += new System.EventHandler(this.RolesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            this.Panel_RolesList.ResumeLayout(false);
            this.Panel_RolesList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_RolBuscar;
        public System.Windows.Forms.ComboBox cBox_EstadoRolBuscar;
        public System.Windows.Forms.ComboBox cBox_RolBuscar;
        private System.Windows.Forms.Button btn_NuevoRol;
        private System.Windows.Forms.Button btn_BuscarRol;
        private System.Windows.Forms.Button btn_ImprimirRol;
        public System.Windows.Forms.Button btn_ModifRol;
        public System.Windows.Forms.Button btn_BajaRol;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        private System.Windows.Forms.Button btn_CerrarRolesList;
        private System.Windows.Forms.Panel Panel_RolesList;
        private System.Windows.Forms.Label lbl_TitRoles;
        public System.Windows.Forms.DataGridView Dgv_Roles;
    }
}