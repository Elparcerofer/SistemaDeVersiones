namespace ProyectSistemaVersiones
{
    partial class frmBusquedaCliente
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DG_Clientes = new System.Windows.Forms.DataGridView();
            this.sisCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliRUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SistemaDataSetGeneral = new ProyectSistemaVersiones.DB_SistemaDataSetGeneral();
            this.tblClienteTableAdapter = new ProyectSistemaVersiones.DB_SistemaDataSetGeneralTableAdapters.TblClienteTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(135, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 177);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Gnerales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(64, 140);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(100, 20);
            this.txtContacto.TabIndex = 10;
            this.txtContacto.Tag = "Contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(63, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Tag = "Teléfono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(63, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(245, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.Tag = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(63, 20);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(144, 20);
            this.txtRuc.TabIndex = 6;
            this.txtRuc.Tag = "RUC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "RUC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(368, 389);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(165, 389);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DG_Clientes
            // 
            this.DG_Clientes.AllowUserToAddRows = false;
            this.DG_Clientes.AllowUserToDeleteRows = false;
            this.DG_Clientes.AutoGenerateColumns = false;
            this.DG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sisCodigoDataGridViewTextBoxColumn,
            this.cliRUCDataGridViewTextBoxColumn,
            this.cliNombreDataGridViewTextBoxColumn,
            this.cliDireccionDataGridViewTextBoxColumn,
            this.cliTelefonoDataGridViewTextBoxColumn,
            this.cliContactoDataGridViewTextBoxColumn,
            this.cliCodigoDataGridViewTextBoxColumn});
            this.DG_Clientes.DataSource = this.tblClienteBindingSource;
            this.DG_Clientes.Location = new System.Drawing.Point(12, 31);
            this.DG_Clientes.Name = "DG_Clientes";
            this.DG_Clientes.ReadOnly = true;
            this.DG_Clientes.Size = new System.Drawing.Size(543, 150);
            this.DG_Clientes.TabIndex = 16;
            this.DG_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Clientes_CellContentClick_1);
            this.DG_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Clientes_CellContentClick_1);
            this.DG_Clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Clientes_CellContentClick_1);
            // 
            // sisCodigoDataGridViewTextBoxColumn
            // 
            this.sisCodigoDataGridViewTextBoxColumn.DataPropertyName = "SisCodigo";
            this.sisCodigoDataGridViewTextBoxColumn.HeaderText = "Codigo de Sistema";
            this.sisCodigoDataGridViewTextBoxColumn.Name = "sisCodigoDataGridViewTextBoxColumn";
            this.sisCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sisCodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cliRUCDataGridViewTextBoxColumn
            // 
            this.cliRUCDataGridViewTextBoxColumn.DataPropertyName = "CliRUC";
            this.cliRUCDataGridViewTextBoxColumn.HeaderText = "Cedula o RUC";
            this.cliRUCDataGridViewTextBoxColumn.Name = "cliRUCDataGridViewTextBoxColumn";
            this.cliRUCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliNombreDataGridViewTextBoxColumn
            // 
            this.cliNombreDataGridViewTextBoxColumn.DataPropertyName = "CliNombre";
            this.cliNombreDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.cliNombreDataGridViewTextBoxColumn.Name = "cliNombreDataGridViewTextBoxColumn";
            this.cliNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliDireccionDataGridViewTextBoxColumn
            // 
            this.cliDireccionDataGridViewTextBoxColumn.DataPropertyName = "CliDireccion";
            this.cliDireccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.cliDireccionDataGridViewTextBoxColumn.Name = "cliDireccionDataGridViewTextBoxColumn";
            this.cliDireccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliTelefonoDataGridViewTextBoxColumn
            // 
            this.cliTelefonoDataGridViewTextBoxColumn.DataPropertyName = "CliTelefono";
            this.cliTelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono Convencional";
            this.cliTelefonoDataGridViewTextBoxColumn.Name = "cliTelefonoDataGridViewTextBoxColumn";
            this.cliTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliContactoDataGridViewTextBoxColumn
            // 
            this.cliContactoDataGridViewTextBoxColumn.DataPropertyName = "CliContacto";
            this.cliContactoDataGridViewTextBoxColumn.HeaderText = "Telefono Movil";
            this.cliContactoDataGridViewTextBoxColumn.Name = "cliContactoDataGridViewTextBoxColumn";
            this.cliContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliCodigoDataGridViewTextBoxColumn
            // 
            this.cliCodigoDataGridViewTextBoxColumn.DataPropertyName = "CliCodigo";
            this.cliCodigoDataGridViewTextBoxColumn.HeaderText = "CliCodigo";
            this.cliCodigoDataGridViewTextBoxColumn.Name = "cliCodigoDataGridViewTextBoxColumn";
            this.cliCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliCodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "TblCliente";
            this.tblClienteBindingSource.DataSource = this.dB_SistemaDataSetGeneral;
            // 
            // dB_SistemaDataSetGeneral
            // 
            this.dB_SistemaDataSetGeneral.DataSetName = "DB_SistemaDataSetGeneral";
            this.dB_SistemaDataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClienteTableAdapter
            // 
            this.tblClienteTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "EDITAR REGISTRO DE CLIENTE";
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Clientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBusquedaCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.frmBusquedaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView DG_Clientes;
        private DB_SistemaDataSetGeneral dB_SistemaDataSetGeneral;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private DB_SistemaDataSetGeneralTableAdapters.TblClienteTableAdapter tblClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliRUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}