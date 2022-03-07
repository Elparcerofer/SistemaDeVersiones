namespace ProyectSistemaVersiones
{
    partial class frmRegistroClientes
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
            this.btnBusquedaCliente = new System.Windows.Forms.Button();
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.cmbSistema = new System.Windows.Forms.ComboBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dB_SistemaDataSetGeneral = new ProyectSistemaVersiones.DB_SistemaDataSetGeneral();
            this.tblSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSistemaTableAdapter = new ProyectSistemaVersiones.DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter();
            this.grbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusquedaCliente
            // 
            this.btnBusquedaCliente.Location = new System.Drawing.Point(26, 12);
            this.btnBusquedaCliente.Name = "btnBusquedaCliente";
            this.btnBusquedaCliente.Size = new System.Drawing.Size(118, 23);
            this.btnBusquedaCliente.TabIndex = 0;
            this.btnBusquedaCliente.Text = "Busqueda de Cliente";
            this.btnBusquedaCliente.UseVisualStyleBackColor = true;
            this.btnBusquedaCliente.Click += new System.EventHandler(this.btnBusquedaCliente_Click_1);
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.cmbSistema);
            this.grbDatosGenerales.Controls.Add(this.txtContacto);
            this.grbDatosGenerales.Controls.Add(this.txtTelefono);
            this.grbDatosGenerales.Controls.Add(this.txtDireccion);
            this.grbDatosGenerales.Controls.Add(this.txtNombre);
            this.grbDatosGenerales.Controls.Add(this.txtRuc);
            this.grbDatosGenerales.Controls.Add(this.label6);
            this.grbDatosGenerales.Controls.Add(this.label5);
            this.grbDatosGenerales.Controls.Add(this.label4);
            this.grbDatosGenerales.Controls.Add(this.label3);
            this.grbDatosGenerales.Controls.Add(this.label2);
            this.grbDatosGenerales.Controls.Add(this.label1);
            this.grbDatosGenerales.Location = new System.Drawing.Point(17, 43);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(323, 204);
            this.grbDatosGenerales.TabIndex = 1;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos Gnerales";
            // 
            // cmbSistema
            // 
            this.cmbSistema.DataSource = this.tblSistemaBindingSource;
            this.cmbSistema.DisplayMember = "SisDetalle";
            this.cmbSistema.FormattingEnabled = true;
            this.cmbSistema.Location = new System.Drawing.Point(63, 170);
            this.cmbSistema.Name = "cmbSistema";
            this.cmbSistema.Size = new System.Drawing.Size(121, 21);
            this.cmbSistema.TabIndex = 11;
            this.cmbSistema.Tag = "Sistema";
            this.toolTip1.SetToolTip(this.cmbSistema, "Elija el Sistema");
            this.cmbSistema.ValueMember = "SisCodigo";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(64, 140);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(100, 20);
            this.txtContacto.TabIndex = 10;
            this.txtContacto.Tag = "Contacto";
            this.toolTip1.SetToolTip(this.txtContacto, "Ingrese el contacto");
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(63, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Tag = "Teléfono";
            this.toolTip1.SetToolTip(this.txtTelefono, "Ingrese el telefono");
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(63, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(245, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.Tag = "Direccion";
            this.toolTip1.SetToolTip(this.txtDireccion, "Ingrese la direccion");
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Tag = "Nombre";
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese el Nombre");
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(63, 20);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(144, 20);
            this.txtRuc.TabIndex = 6;
            this.txtRuc.Tag = "RUC";
            this.toolTip1.SetToolTip(this.txtRuc, "Ingrese el RUC");
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sistema";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(347, 156);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(347, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(346, 97);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Registro de Clientes";
            // 
            // dB_SistemaDataSetGeneral
            // 
            this.dB_SistemaDataSetGeneral.DataSetName = "DB_SistemaDataSetGeneral";
            this.dB_SistemaDataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSistemaBindingSource
            // 
            this.tblSistemaBindingSource.DataMember = "TblSistema";
            this.tblSistemaBindingSource.DataSource = this.dB_SistemaDataSetGeneral;
            // 
            // tblSistemaTableAdapter
            // 
            this.tblSistemaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 258);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grbDatosGenerales);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBusquedaCliente);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmRegistroClientes";
            this.Text = "Registro Clientes";
            this.Load += new System.EventHandler(this.frmRegistroClientes_Load);
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusquedaCliente;
        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.ComboBox cmbSistema;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private DB_SistemaDataSetGeneral dB_SistemaDataSetGeneral;
        private System.Windows.Forms.BindingSource tblSistemaBindingSource;
        private DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter tblSistemaTableAdapter;
    }
}