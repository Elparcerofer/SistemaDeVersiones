namespace ProyectSistemaVersiones
{
    partial class frmRegistroVersiones
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbRegistroVersiones = new System.Windows.Forms.GroupBox();
            this.txtDetalleGeneral = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtInstrucciones = new System.Windows.Forms.RichTextBox();
            this.txtCambio = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRegistroFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbhistorial = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DG_Versiones = new System.Windows.Forms.DataGridView();
            this.cmbSistema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.dB_SistemaDataSetGeneral = new ProyectSistemaVersiones.DB_SistemaDataSetGeneral();
            this.tblSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSistemaTableAdapter = new ProyectSistemaVersiones.DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter();
            this.tblVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVersionTableAdapter = new ProyectSistemaVersiones.DB_SistemaDataSetGeneralTableAdapters.TblVersionTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.sisCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verCambiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verInstruccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbRegistroVersiones.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbhistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Versiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVersionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 48);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 301);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.grbRegistroVersiones);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(498, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de Versiones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 231);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 25);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grbRegistroVersiones
            // 
            this.grbRegistroVersiones.Controls.Add(this.txtDetalleGeneral);
            this.grbRegistroVersiones.Controls.Add(this.txtVersion);
            this.grbRegistroVersiones.Controls.Add(this.txtInstrucciones);
            this.grbRegistroVersiones.Controls.Add(this.txtCambio);
            this.grbRegistroVersiones.Controls.Add(this.label8);
            this.grbRegistroVersiones.Controls.Add(this.label7);
            this.grbRegistroVersiones.Controls.Add(this.label6);
            this.grbRegistroVersiones.Controls.Add(this.label5);
            this.grbRegistroVersiones.Controls.Add(this.dtpRegistroFecha);
            this.grbRegistroVersiones.Controls.Add(this.label4);
            this.grbRegistroVersiones.Location = new System.Drawing.Point(4, 4);
            this.grbRegistroVersiones.Margin = new System.Windows.Forms.Padding(2);
            this.grbRegistroVersiones.Name = "grbRegistroVersiones";
            this.grbRegistroVersiones.Padding = new System.Windows.Forms.Padding(2);
            this.grbRegistroVersiones.Size = new System.Drawing.Size(488, 223);
            this.grbRegistroVersiones.TabIndex = 0;
            this.grbRegistroVersiones.TabStop = false;
            this.grbRegistroVersiones.Text = "Registro";
            // 
            // txtDetalleGeneral
            // 
            this.txtDetalleGeneral.Location = new System.Drawing.Point(101, 80);
            this.txtDetalleGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetalleGeneral.Name = "txtDetalleGeneral";
            this.txtDetalleGeneral.Size = new System.Drawing.Size(226, 20);
            this.txtDetalleGeneral.TabIndex = 9;
            this.txtDetalleGeneral.Tag = "Detalle";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(101, 50);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(2);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(226, 20);
            this.txtVersion.TabIndex = 8;
            this.txtVersion.Tag = "Versiones";
            // 
            // txtInstrucciones
            // 
            this.txtInstrucciones.Location = new System.Drawing.Point(180, 163);
            this.txtInstrucciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.Size = new System.Drawing.Size(232, 54);
            this.txtInstrucciones.TabIndex = 7;
            this.txtInstrucciones.Tag = "Instrucciones";
            this.txtInstrucciones.Text = "";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(180, 110);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(232, 48);
            this.txtCambio.TabIndex = 6;
            this.txtCambio.Tag = "Cambios";
            this.txtCambio.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cambio Realizados en esta sesión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Intrucciones para instalación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Detalle General";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Version";
            // 
            // dtpRegistroFecha
            // 
            this.dtpRegistroFecha.Location = new System.Drawing.Point(79, 17);
            this.dtpRegistroFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRegistroFecha.Name = "dtpRegistroFecha";
            this.dtpRegistroFecha.Size = new System.Drawing.Size(215, 20);
            this.dtpRegistroFecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha y Hora";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(184, 231);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 25);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grbhistorial);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(498, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grbhistorial
            // 
            this.grbhistorial.Controls.Add(this.btnRefresh);
            this.grbhistorial.Controls.Add(this.btnUpdate);
            this.grbhistorial.Controls.Add(this.btnEliminar);
            this.grbhistorial.Controls.Add(this.DG_Versiones);
            this.grbhistorial.Location = new System.Drawing.Point(8, 10);
            this.grbhistorial.Margin = new System.Windows.Forms.Padding(2);
            this.grbhistorial.Name = "grbhistorial";
            this.grbhistorial.Padding = new System.Windows.Forms.Padding(2);
            this.grbhistorial.Size = new System.Drawing.Size(476, 257);
            this.grbhistorial.TabIndex = 0;
            this.grbhistorial.TabStop = false;
            this.grbhistorial.Text = "Historial";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(384, 214);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 24);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 214);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 24);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DG_Versiones
            // 
            this.DG_Versiones.AllowUserToAddRows = false;
            this.DG_Versiones.AllowUserToDeleteRows = false;
            this.DG_Versiones.AutoGenerateColumns = false;
            this.DG_Versiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Versiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sisCodigoDataGridViewTextBoxColumn,
            this.verCodigoDataGridViewTextBoxColumn,
            this.verFechaDataGridViewTextBoxColumn,
            this.verVersionDataGridViewTextBoxColumn,
            this.verDetalleDataGridViewTextBoxColumn,
            this.verCambiosDataGridViewTextBoxColumn,
            this.verInstruccionDataGridViewTextBoxColumn,
            this.verEstadoDataGridViewTextBoxColumn});
            this.DG_Versiones.DataSource = this.tblVersionBindingSource;
            this.DG_Versiones.Location = new System.Drawing.Point(12, 22);
            this.DG_Versiones.Margin = new System.Windows.Forms.Padding(2);
            this.DG_Versiones.Name = "DG_Versiones";
            this.DG_Versiones.ReadOnly = true;
            this.DG_Versiones.RowHeadersWidth = 51;
            this.DG_Versiones.RowTemplate.Height = 24;
            this.DG_Versiones.Size = new System.Drawing.Size(449, 165);
            this.DG_Versiones.TabIndex = 0;
            this.DG_Versiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbSistema
            // 
            this.cmbSistema.DataSource = this.tblSistemaBindingSource;
            this.cmbSistema.DisplayMember = "SisDetalle";
            this.cmbSistema.FormattingEnabled = true;
            this.cmbSistema.Location = new System.Drawing.Point(98, 23);
            this.cmbSistema.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSistema.Name = "cmbSistema";
            this.cmbSistema.Size = new System.Drawing.Size(192, 21);
            this.cmbSistema.TabIndex = 2;
            this.cmbSistema.Tag = "Sistema";
            this.toolTip2.SetToolTip(this.cmbSistema, "Elija el sistema");
            this.cmbSistema.ValueMember = "SisCodigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema";
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
            // tblVersionBindingSource
            // 
            this.tblVersionBindingSource.DataMember = "TblVersion";
            this.tblVersionBindingSource.DataSource = this.dB_SistemaDataSetGeneral;
            // 
            // tblVersionTableAdapter
            // 
            this.tblVersionTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(192, 214);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Reload";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // sisCodigoDataGridViewTextBoxColumn
            // 
            this.sisCodigoDataGridViewTextBoxColumn.DataPropertyName = "SisCodigo";
            this.sisCodigoDataGridViewTextBoxColumn.HeaderText = "SisCodigo";
            this.sisCodigoDataGridViewTextBoxColumn.Name = "sisCodigoDataGridViewTextBoxColumn";
            this.sisCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sisCodigoDataGridViewTextBoxColumn.Visible = false;
            this.sisCodigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // verCodigoDataGridViewTextBoxColumn
            // 
            this.verCodigoDataGridViewTextBoxColumn.DataPropertyName = "VerCodigo";
            this.verCodigoDataGridViewTextBoxColumn.HeaderText = "VerCodigo";
            this.verCodigoDataGridViewTextBoxColumn.Name = "verCodigoDataGridViewTextBoxColumn";
            this.verCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.verCodigoDataGridViewTextBoxColumn.Visible = false;
            this.verCodigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // verFechaDataGridViewTextBoxColumn
            // 
            this.verFechaDataGridViewTextBoxColumn.DataPropertyName = "VerFecha";
            this.verFechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.verFechaDataGridViewTextBoxColumn.Name = "verFechaDataGridViewTextBoxColumn";
            this.verFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verVersionDataGridViewTextBoxColumn
            // 
            this.verVersionDataGridViewTextBoxColumn.DataPropertyName = "VerVersion";
            this.verVersionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.verVersionDataGridViewTextBoxColumn.Name = "verVersionDataGridViewTextBoxColumn";
            this.verVersionDataGridViewTextBoxColumn.ReadOnly = true;
            this.verVersionDataGridViewTextBoxColumn.Width = 60;
            // 
            // verDetalleDataGridViewTextBoxColumn
            // 
            this.verDetalleDataGridViewTextBoxColumn.DataPropertyName = "VerDetalle";
            this.verDetalleDataGridViewTextBoxColumn.HeaderText = "Detalle";
            this.verDetalleDataGridViewTextBoxColumn.Name = "verDetalleDataGridViewTextBoxColumn";
            this.verDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verCambiosDataGridViewTextBoxColumn
            // 
            this.verCambiosDataGridViewTextBoxColumn.DataPropertyName = "VerCambios";
            this.verCambiosDataGridViewTextBoxColumn.HeaderText = "Cambios";
            this.verCambiosDataGridViewTextBoxColumn.Name = "verCambiosDataGridViewTextBoxColumn";
            this.verCambiosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verInstruccionDataGridViewTextBoxColumn
            // 
            this.verInstruccionDataGridViewTextBoxColumn.DataPropertyName = "VerInstruccion";
            this.verInstruccionDataGridViewTextBoxColumn.HeaderText = "Instrucciones";
            this.verInstruccionDataGridViewTextBoxColumn.Name = "verInstruccionDataGridViewTextBoxColumn";
            this.verInstruccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verEstadoDataGridViewTextBoxColumn
            // 
            this.verEstadoDataGridViewTextBoxColumn.DataPropertyName = "VerEstado";
            this.verEstadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.verEstadoDataGridViewTextBoxColumn.Name = "verEstadoDataGridViewTextBoxColumn";
            this.verEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.verEstadoDataGridViewTextBoxColumn.Width = 65;
            // 
            // frmRegistroVersiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 382);
            this.Controls.Add(this.cmbSistema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRegistroVersiones";
            this.Text = "frmRegistroVersiones";
            this.Load += new System.EventHandler(this.frmRegistroVersiones_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbRegistroVersiones.ResumeLayout(false);
            this.grbRegistroVersiones.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grbhistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Versiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVersionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grbRegistroVersiones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDetalleGeneral;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.RichTextBox txtInstrucciones;
        private System.Windows.Forms.RichTextBox txtCambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRegistroFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbhistorial;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView DG_Versiones;
        private System.Windows.Forms.ComboBox cmbSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private DB_SistemaDataSetGeneral dB_SistemaDataSetGeneral;
        private System.Windows.Forms.BindingSource tblSistemaBindingSource;
        private DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter tblSistemaTableAdapter;
        private System.Windows.Forms.BindingSource tblVersionBindingSource;
        private DB_SistemaDataSetGeneralTableAdapters.TblVersionTableAdapter tblVersionTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verCambiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verInstruccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verEstadoDataGridViewTextBoxColumn;
    }
}