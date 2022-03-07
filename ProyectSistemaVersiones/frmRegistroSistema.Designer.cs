namespace ProyectSistemaVersiones
{
    partial class frmRegistroSistema
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
            this.btnBusquedaSistema = new System.Windows.Forms.Button();
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCaracteristicaDesarrollo = new System.Windows.Forms.GroupBox();
            this.cmbReportes = new System.Windows.Forms.ComboBox();
            this.cmbLenguajeProgramacion = new System.Windows.Forms.ComboBox();
            this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
            this.cmbSistemaOperativo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbPersonalP = new System.Windows.Forms.GroupBox();
            this.txtHelpDesk = new System.Windows.Forms.TextBox();
            this.txtTester = new System.Windows.Forms.TextBox();
            this.txtDeveloperSenior = new System.Windows.Forms.TextBox();
            this.txtProyectManager = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbDatosGenerales.SuspendLayout();
            this.grbCaracteristicaDesarrollo.SuspendLayout();
            this.grbPersonalP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBusquedaSistema
            // 
            this.btnBusquedaSistema.Location = new System.Drawing.Point(12, 12);
            this.btnBusquedaSistema.Name = "btnBusquedaSistema";
            this.btnBusquedaSistema.Size = new System.Drawing.Size(107, 23);
            this.btnBusquedaSistema.TabIndex = 0;
            this.btnBusquedaSistema.Text = "Busqueda Sistema";
            this.btnBusquedaSistema.UseVisualStyleBackColor = true;
            this.btnBusquedaSistema.Click += new System.EventHandler(this.btnBusquedaSistema_Click);
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.dtpFechaFin);
            this.grbDatosGenerales.Controls.Add(this.dtpFechaInicio);
            this.grbDatosGenerales.Controls.Add(this.txtDetalle);
            this.grbDatosGenerales.Controls.Add(this.label4);
            this.grbDatosGenerales.Controls.Add(this.label3);
            this.grbDatosGenerales.Controls.Add(this.label2);
            this.grbDatosGenerales.Location = new System.Drawing.Point(12, 82);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(405, 80);
            this.grbDatosGenerales.TabIndex = 1;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos Generales";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(265, 54);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaFin.TabIndex = 9;
            this.dtpFechaFin.Tag = "Fecha Fin";
            this.toolTip1.SetToolTip(this.dtpFechaFin, "Elija la fecha de Fin");
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(82, 54);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaInicio.TabIndex = 8;
            this.dtpFechaInicio.Tag = "Fecha Inicio";
            this.toolTip1.SetToolTip(this.dtpFechaInicio, "Elija la fecha de inicio");
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(82, 24);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(139, 20);
            this.txtDetalle.TabIndex = 7;
            this.txtDetalle.Tag = "Detalle";
            this.toolTip1.SetToolTip(this.txtDetalle, "Ingrese el detalle");
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grbCaracteristicaDesarrollo
            // 
            this.grbCaracteristicaDesarrollo.Controls.Add(this.cmbReportes);
            this.grbCaracteristicaDesarrollo.Controls.Add(this.cmbLenguajeProgramacion);
            this.grbCaracteristicaDesarrollo.Controls.Add(this.cmbBaseDatos);
            this.grbCaracteristicaDesarrollo.Controls.Add(this.cmbSistemaOperativo);
            this.grbCaracteristicaDesarrollo.Controls.Add(this.label8);
            this.grbCaracteristicaDesarrollo.Controls.Add(this.label5);
            this.grbCaracteristicaDesarrollo.Controls.Add(this.label6);
            this.grbCaracteristicaDesarrollo.Controls.Add(this.label7);
            this.grbCaracteristicaDesarrollo.Location = new System.Drawing.Point(12, 168);
            this.grbCaracteristicaDesarrollo.Name = "grbCaracteristicaDesarrollo";
            this.grbCaracteristicaDesarrollo.Size = new System.Drawing.Size(405, 141);
            this.grbCaracteristicaDesarrollo.TabIndex = 2;
            this.grbCaracteristicaDesarrollo.TabStop = false;
            this.grbCaracteristicaDesarrollo.Text = "Caracteristicas de Desarrollo";
            // 
            // cmbReportes
            // 
            this.cmbReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportes.FormattingEnabled = true;
            this.cmbReportes.Items.AddRange(new object[] {
            "ReporterPro",
            "ProReporter",
            "DfRo"});
            this.cmbReportes.Location = new System.Drawing.Point(105, 110);
            this.cmbReportes.Name = "cmbReportes";
            this.cmbReportes.Size = new System.Drawing.Size(132, 21);
            this.cmbReportes.TabIndex = 16;
            this.cmbReportes.Tag = "Reportes";
            this.toolTip1.SetToolTip(this.cmbReportes, "Elija los reportes");
            // 
            // cmbLenguajeProgramacion
            // 
            this.cmbLenguajeProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLenguajeProgramacion.FormattingEnabled = true;
            this.cmbLenguajeProgramacion.Items.AddRange(new object[] {
            ".NET",
            "Java",
            "Visual Studio 6",
            "Delphi",
            "Otros"});
            this.cmbLenguajeProgramacion.Location = new System.Drawing.Point(105, 80);
            this.cmbLenguajeProgramacion.Name = "cmbLenguajeProgramacion";
            this.cmbLenguajeProgramacion.Size = new System.Drawing.Size(132, 21);
            this.cmbLenguajeProgramacion.TabIndex = 15;
            this.cmbLenguajeProgramacion.Tag = "Programacion";
            this.toolTip1.SetToolTip(this.cmbLenguajeProgramacion, "Elija el lenguaje de programacion");
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Items.AddRange(new object[] {
            "MySQL",
            "ORACLE",
            "SQL Developer",
            "Microsoft SQL"});
            this.cmbBaseDatos.Location = new System.Drawing.Point(105, 50);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(132, 21);
            this.cmbBaseDatos.TabIndex = 14;
            this.cmbBaseDatos.Tag = "Base de datos";
            this.toolTip1.SetToolTip(this.cmbBaseDatos, "Elija la base de datos");
            // 
            // cmbSistemaOperativo
            // 
            this.cmbSistemaOperativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSistemaOperativo.FormattingEnabled = true;
            this.cmbSistemaOperativo.Items.AddRange(new object[] {
            "Linux",
            "Windows",
            "MacOS"});
            this.cmbSistemaOperativo.Location = new System.Drawing.Point(105, 20);
            this.cmbSistemaOperativo.Name = "cmbSistemaOperativo";
            this.cmbSistemaOperativo.Size = new System.Drawing.Size(132, 21);
            this.cmbSistemaOperativo.TabIndex = 4;
            this.cmbSistemaOperativo.Tag = "Sistema Operativo";
            this.toolTip1.SetToolTip(this.cmbSistemaOperativo, "Elija el sistema operativo");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Reportes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Programación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Base de Datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sistema Operativo";
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
            this.grbPersonalP.Location = new System.Drawing.Point(12, 315);
            this.grbPersonalP.Name = "grbPersonalP";
            this.grbPersonalP.Size = new System.Drawing.Size(405, 135);
            this.grbPersonalP.TabIndex = 3;
            this.grbPersonalP.TabStop = false;
            this.grbPersonalP.Text = "Personal Del Proyecto";
            this.grbPersonalP.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtHelpDesk
            // 
            this.txtHelpDesk.Location = new System.Drawing.Point(105, 110);
            this.txtHelpDesk.Name = "txtHelpDesk";
            this.txtHelpDesk.Size = new System.Drawing.Size(210, 20);
            this.txtHelpDesk.TabIndex = 24;
            this.txtHelpDesk.Tag = "Help Desk";
            this.toolTip1.SetToolTip(this.txtHelpDesk, "Elija el nombre del Help Desk");
            // 
            // txtTester
            // 
            this.txtTester.Location = new System.Drawing.Point(105, 80);
            this.txtTester.Name = "txtTester";
            this.txtTester.Size = new System.Drawing.Size(210, 20);
            this.txtTester.TabIndex = 23;
            this.txtTester.Tag = "Tester";
            this.toolTip1.SetToolTip(this.txtTester, "Elija el nombre del tester");
            // 
            // txtDeveloperSenior
            // 
            this.txtDeveloperSenior.Location = new System.Drawing.Point(105, 50);
            this.txtDeveloperSenior.Name = "txtDeveloperSenior";
            this.txtDeveloperSenior.Size = new System.Drawing.Size(210, 20);
            this.txtDeveloperSenior.TabIndex = 22;
            this.txtDeveloperSenior.Tag = "Developer Senior";
            this.toolTip1.SetToolTip(this.txtDeveloperSenior, "Elija el nombre del developer senior");
            // 
            // txtProyectManager
            // 
            this.txtProyectManager.Location = new System.Drawing.Point(105, 20);
            this.txtProyectManager.Name = "txtProyectManager";
            this.txtProyectManager.Size = new System.Drawing.Size(210, 20);
            this.txtProyectManager.TabIndex = 21;
            this.txtProyectManager.Tag = "Proyect Manager";
            this.toolTip1.SetToolTip(this.txtProyectManager, "Ingrese el proyect manager");
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
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(435, 261);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(435, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(435, 184);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Registro de Sistema";
            // 
            // frmRegistroSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 458);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grbCaracteristicaDesarrollo);
            this.Controls.Add(this.grbPersonalP);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grbDatosGenerales);
            this.Controls.Add(this.btnBusquedaSistema);
            this.Name = "frmRegistroSistema";
            this.Text = "Registro Sistemas";
            this.Load += new System.EventHandler(this.frmRegistroSistema_Load);
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            this.grbCaracteristicaDesarrollo.ResumeLayout(false);
            this.grbCaracteristicaDesarrollo.PerformLayout();
            this.grbPersonalP.ResumeLayout(false);
            this.grbPersonalP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusquedaSistema;
        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.GroupBox grbCaracteristicaDesarrollo;
        private System.Windows.Forms.GroupBox grbPersonalP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbReportes;
        private System.Windows.Forms.ComboBox cmbLenguajeProgramacion;
        private System.Windows.Forms.ComboBox cmbBaseDatos;
        private System.Windows.Forms.ComboBox cmbSistemaOperativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHelpDesk;
        private System.Windows.Forms.TextBox txtTester;
        private System.Windows.Forms.TextBox txtDeveloperSenior;
        private System.Windows.Forms.TextBox txtProyectManager;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}