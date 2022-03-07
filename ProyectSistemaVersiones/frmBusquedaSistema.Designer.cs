namespace ProyectSistemaVersiones
{
    partial class frmBusquedaSistema
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
            this.grbPersonalP = new System.Windows.Forms.GroupBox();
            this.txtHelpDesk = new System.Windows.Forms.TextBox();
            this.txtTester = new System.Windows.Forms.TextBox();
            this.txtDeveloperSenior = new System.Windows.Forms.TextBox();
            this.txtProyectManager = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DG_Sistema = new System.Windows.Forms.DataGridView();
            this.dB_SistemaDataSetGeneral = new ProyectSistemaVersiones.DB_SistemaDataSetGeneral();
            this.dBSistemaDataSetGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSistemaTableAdapter = new ProyectSistemaVersiones.DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter();
            this.sisCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisFechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisFechaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisSistemaOperativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisBaseDatosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisDesarrolloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisReportesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisProyectManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisDeveloperSeniorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisTesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisSoporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPersonalP.SuspendLayout();
            this.grbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSistemaDataSetGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonalP
            // 
            this.grbPersonalP.Controls.Add(this.txtHelpDesk);
            this.grbPersonalP.Controls.Add(this.txtTester);
            this.grbPersonalP.Controls.Add(this.txtDeveloperSenior);
            this.grbPersonalP.Controls.Add(this.txtProyectManager);
            this.grbPersonalP.Controls.Add(this.label9);
            this.grbPersonalP.Controls.Add(this.label10);
            this.grbPersonalP.Controls.Add(this.label12);
            this.grbPersonalP.Controls.Add(this.label11);
            this.grbPersonalP.Location = new System.Drawing.Point(95, 289);
            this.grbPersonalP.Name = "grbPersonalP";
            this.grbPersonalP.Size = new System.Drawing.Size(405, 135);
            this.grbPersonalP.TabIndex = 17;
            this.grbPersonalP.TabStop = false;
            this.grbPersonalP.Text = "Personal Del Proyecto";
            // 
            // txtHelpDesk
            // 
            this.txtHelpDesk.Location = new System.Drawing.Point(105, 110);
            this.txtHelpDesk.Name = "txtHelpDesk";
            this.txtHelpDesk.Size = new System.Drawing.Size(210, 20);
            this.txtHelpDesk.TabIndex = 24;
            this.txtHelpDesk.Tag = "Help Desk";
            // 
            // txtTester
            // 
            this.txtTester.Location = new System.Drawing.Point(105, 80);
            this.txtTester.Name = "txtTester";
            this.txtTester.Size = new System.Drawing.Size(210, 20);
            this.txtTester.TabIndex = 23;
            this.txtTester.Tag = "Tester";
            // 
            // txtDeveloperSenior
            // 
            this.txtDeveloperSenior.Location = new System.Drawing.Point(105, 50);
            this.txtDeveloperSenior.Name = "txtDeveloperSenior";
            this.txtDeveloperSenior.Size = new System.Drawing.Size(210, 20);
            this.txtDeveloperSenior.TabIndex = 22;
            this.txtDeveloperSenior.Tag = "Developer Senior";
            // 
            // txtProyectManager
            // 
            this.txtProyectManager.Location = new System.Drawing.Point(105, 20);
            this.txtProyectManager.Name = "txtProyectManager";
            this.txtProyectManager.Size = new System.Drawing.Size(210, 20);
            this.txtProyectManager.TabIndex = 21;
            this.txtProyectManager.Tag = "Proyect Manager";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Help Desk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tester";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Proyect Manager";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Developer Senior";
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.txtDetalle);
            this.grbDatosGenerales.Controls.Add(this.label2);
            this.grbDatosGenerales.Location = new System.Drawing.Point(95, 221);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(405, 62);
            this.grbDatosGenerales.TabIndex = 15;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos Generales";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(82, 24);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(139, 20);
            this.txtDetalle.TabIndex = 7;
            this.txtDetalle.Tag = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(526, 265);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(526, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DG_Sistema
            // 
            this.DG_Sistema.AllowUserToAddRows = false;
            this.DG_Sistema.AllowUserToDeleteRows = false;
            this.DG_Sistema.AutoGenerateColumns = false;
            this.DG_Sistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Sistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sisCodigoDataGridViewTextBoxColumn,
            this.sisDetalleDataGridViewTextBoxColumn,
            this.sisFechaInicioDataGridViewTextBoxColumn,
            this.sisFechaFinalDataGridViewTextBoxColumn,
            this.sisSistemaOperativoDataGridViewTextBoxColumn,
            this.sisBaseDatosDataGridViewTextBoxColumn,
            this.sisDesarrolloDataGridViewTextBoxColumn,
            this.sisReportesDataGridViewTextBoxColumn,
            this.sisProyectManagerDataGridViewTextBoxColumn,
            this.sisDeveloperSeniorDataGridViewTextBoxColumn,
            this.sisTesterDataGridViewTextBoxColumn,
            this.sisSoporteDataGridViewTextBoxColumn});
            this.DG_Sistema.DataSource = this.tblSistemaBindingSource;
            this.DG_Sistema.Location = new System.Drawing.Point(12, 46);
            this.DG_Sistema.Name = "DG_Sistema";
            this.DG_Sistema.ReadOnly = true;
            this.DG_Sistema.Size = new System.Drawing.Size(752, 150);
            this.DG_Sistema.TabIndex = 20;
            this.DG_Sistema.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Sistema_CellContentClick_1);
            this.DG_Sistema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Sistema_CellContentClick_1);
            this.DG_Sistema.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Sistema_CellContentClick_1);
            this.DG_Sistema.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Sistema_CellContentClick_1);
            // 
            // dB_SistemaDataSetGeneral
            // 
            this.dB_SistemaDataSetGeneral.DataSetName = "DB_SistemaDataSetGeneral";
            this.dB_SistemaDataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBSistemaDataSetGeneralBindingSource
            // 
            this.dBSistemaDataSetGeneralBindingSource.DataSource = this.dB_SistemaDataSetGeneral;
            this.dBSistemaDataSetGeneralBindingSource.Position = 0;
            // 
            // tblSistemaBindingSource
            // 
            this.tblSistemaBindingSource.DataMember = "TblSistema";
            this.tblSistemaBindingSource.DataSource = this.dBSistemaDataSetGeneralBindingSource;
            // 
            // tblSistemaTableAdapter
            // 
            this.tblSistemaTableAdapter.ClearBeforeFill = true;
            // 
            // sisCodigoDataGridViewTextBoxColumn
            // 
            this.sisCodigoDataGridViewTextBoxColumn.DataPropertyName = "SisCodigo";
            this.sisCodigoDataGridViewTextBoxColumn.HeaderText = "Codigo Sistema";
            this.sisCodigoDataGridViewTextBoxColumn.Name = "sisCodigoDataGridViewTextBoxColumn";
            // 
            // sisDetalleDataGridViewTextBoxColumn
            // 
            this.sisDetalleDataGridViewTextBoxColumn.DataPropertyName = "SisDetalle";
            this.sisDetalleDataGridViewTextBoxColumn.HeaderText = "Nombre Sistema";
            this.sisDetalleDataGridViewTextBoxColumn.Name = "sisDetalleDataGridViewTextBoxColumn";
            // 
            // sisFechaInicioDataGridViewTextBoxColumn
            // 
            this.sisFechaInicioDataGridViewTextBoxColumn.DataPropertyName = "SisFechaInicio";
            this.sisFechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.sisFechaInicioDataGridViewTextBoxColumn.Name = "sisFechaInicioDataGridViewTextBoxColumn";
            // 
            // sisFechaFinalDataGridViewTextBoxColumn
            // 
            this.sisFechaFinalDataGridViewTextBoxColumn.DataPropertyName = "SisFechaFinal";
            this.sisFechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha Final";
            this.sisFechaFinalDataGridViewTextBoxColumn.Name = "sisFechaFinalDataGridViewTextBoxColumn";
            // 
            // sisSistemaOperativoDataGridViewTextBoxColumn
            // 
            this.sisSistemaOperativoDataGridViewTextBoxColumn.DataPropertyName = "SisSistemaOperativo";
            this.sisSistemaOperativoDataGridViewTextBoxColumn.HeaderText = "SistemaOperativo";
            this.sisSistemaOperativoDataGridViewTextBoxColumn.Name = "sisSistemaOperativoDataGridViewTextBoxColumn";
            // 
            // sisBaseDatosDataGridViewTextBoxColumn
            // 
            this.sisBaseDatosDataGridViewTextBoxColumn.DataPropertyName = "SisBaseDatos";
            this.sisBaseDatosDataGridViewTextBoxColumn.HeaderText = "Base Datos";
            this.sisBaseDatosDataGridViewTextBoxColumn.Name = "sisBaseDatosDataGridViewTextBoxColumn";
            // 
            // sisDesarrolloDataGridViewTextBoxColumn
            // 
            this.sisDesarrolloDataGridViewTextBoxColumn.DataPropertyName = "SisDesarrollo";
            this.sisDesarrolloDataGridViewTextBoxColumn.HeaderText = "Desarrollo";
            this.sisDesarrolloDataGridViewTextBoxColumn.Name = "sisDesarrolloDataGridViewTextBoxColumn";
            // 
            // sisReportesDataGridViewTextBoxColumn
            // 
            this.sisReportesDataGridViewTextBoxColumn.DataPropertyName = "SisReportes";
            this.sisReportesDataGridViewTextBoxColumn.HeaderText = "Reportes";
            this.sisReportesDataGridViewTextBoxColumn.Name = "sisReportesDataGridViewTextBoxColumn";
            // 
            // sisProyectManagerDataGridViewTextBoxColumn
            // 
            this.sisProyectManagerDataGridViewTextBoxColumn.DataPropertyName = "SisProyectManager";
            this.sisProyectManagerDataGridViewTextBoxColumn.HeaderText = "Proyect Manager";
            this.sisProyectManagerDataGridViewTextBoxColumn.Name = "sisProyectManagerDataGridViewTextBoxColumn";
            // 
            // sisDeveloperSeniorDataGridViewTextBoxColumn
            // 
            this.sisDeveloperSeniorDataGridViewTextBoxColumn.DataPropertyName = "SisDeveloperSenior";
            this.sisDeveloperSeniorDataGridViewTextBoxColumn.HeaderText = "Developer Senior";
            this.sisDeveloperSeniorDataGridViewTextBoxColumn.Name = "sisDeveloperSeniorDataGridViewTextBoxColumn";
            // 
            // sisTesterDataGridViewTextBoxColumn
            // 
            this.sisTesterDataGridViewTextBoxColumn.DataPropertyName = "SisTester";
            this.sisTesterDataGridViewTextBoxColumn.HeaderText = "Tester";
            this.sisTesterDataGridViewTextBoxColumn.Name = "sisTesterDataGridViewTextBoxColumn";
            // 
            // sisSoporteDataGridViewTextBoxColumn
            // 
            this.sisSoporteDataGridViewTextBoxColumn.DataPropertyName = "SisSoporte";
            this.sisSoporteDataGridViewTextBoxColumn.HeaderText = "Soporte";
            this.sisSoporteDataGridViewTextBoxColumn.Name = "sisSoporteDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "EDITAR SISTEMA";
            // 
            // frmBusquedaSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Sistema);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbPersonalP);
            this.Controls.Add(this.grbDatosGenerales);
            this.Name = "frmBusquedaSistema";
            this.Text = "Editar Registro de Sistema";
            this.Load += new System.EventHandler(this.frmBusquedaSistema_Load);
            this.grbPersonalP.ResumeLayout(false);
            this.grbPersonalP.PerformLayout();
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSistemaDataSetGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPersonalP;
        private System.Windows.Forms.TextBox txtHelpDesk;
        private System.Windows.Forms.TextBox txtTester;
        private System.Windows.Forms.TextBox txtDeveloperSenior;
        private System.Windows.Forms.TextBox txtProyectManager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView DG_Sistema;
        private System.Windows.Forms.BindingSource dBSistemaDataSetGeneralBindingSource;
        private DB_SistemaDataSetGeneral dB_SistemaDataSetGeneral;
        private System.Windows.Forms.BindingSource tblSistemaBindingSource;
        private DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter tblSistemaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisFechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisFechaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisSistemaOperativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisBaseDatosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisDesarrolloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisReportesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisProyectManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisDeveloperSeniorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisTesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisSoporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}