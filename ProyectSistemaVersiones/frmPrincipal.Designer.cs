namespace ProyectSistemaVersiones
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MnPrincipal = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVersionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVersionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeSoporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSoporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stbPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPrincipal.SuspendLayout();
            this.stbPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnPrincipal
            // 
            this.MnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.versionesToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.MnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnPrincipal.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.MnPrincipal.Name = "MnPrincipal";
            this.MnPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MnPrincipal.TabIndex = 1;
            this.MnPrincipal.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeSistemaToolStripMenuItem,
            this.registroDeClienteToolStripMenuItem,
            this.busquedaSistemaToolStripMenuItem,
            this.busquedaClienteToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // registroDeSistemaToolStripMenuItem
            // 
            this.registroDeSistemaToolStripMenuItem.Name = "registroDeSistemaToolStripMenuItem";
            this.registroDeSistemaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registroDeSistemaToolStripMenuItem.Text = "Registro de Sistema";
            this.registroDeSistemaToolStripMenuItem.Click += new System.EventHandler(this.registroDeSistemaToolStripMenuItem_Click);
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registroDeClienteToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.registroDeClienteToolStripMenuItem_Click);
            // 
            // busquedaSistemaToolStripMenuItem
            // 
            this.busquedaSistemaToolStripMenuItem.Name = "busquedaSistemaToolStripMenuItem";
            this.busquedaSistemaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.busquedaSistemaToolStripMenuItem.Text = "Editar Registro Sistema";
            this.busquedaSistemaToolStripMenuItem.Click += new System.EventHandler(this.busquedaSistemaToolStripMenuItem_Click);
            // 
            // busquedaClienteToolStripMenuItem
            // 
            this.busquedaClienteToolStripMenuItem.Name = "busquedaClienteToolStripMenuItem";
            this.busquedaClienteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.busquedaClienteToolStripMenuItem.Text = "Editar Registro Cliente";
            this.busquedaClienteToolStripMenuItem.Click += new System.EventHandler(this.busquedaClienteToolStripMenuItem_Click);
            // 
            // versionesToolStripMenuItem
            // 
            this.versionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVersionesToolStripMenuItem,
            this.listadoDeVersionesToolStripMenuItem});
            this.versionesToolStripMenuItem.Name = "versionesToolStripMenuItem";
            this.versionesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.versionesToolStripMenuItem.Text = "Versiones";
            // 
            // registroDeVersionesToolStripMenuItem
            // 
            this.registroDeVersionesToolStripMenuItem.Name = "registroDeVersionesToolStripMenuItem";
            this.registroDeVersionesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registroDeVersionesToolStripMenuItem.Text = "Registro de Versiones";
            this.registroDeVersionesToolStripMenuItem.Click += new System.EventHandler(this.registroDeVersionesToolStripMenuItem_Click);
            // 
            // listadoDeVersionesToolStripMenuItem
            // 
            this.listadoDeVersionesToolStripMenuItem.Name = "listadoDeVersionesToolStripMenuItem";
            this.listadoDeVersionesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDeVersionesToolStripMenuItem.Text = "Listado de Versiones";
            this.listadoDeVersionesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeVersionesToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeSoporteTecnicoToolStripMenuItem,
            this.listadoDeSoporteTecnicoToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // registroDeSoporteTecnicoToolStripMenuItem
            // 
            this.registroDeSoporteTecnicoToolStripMenuItem.Name = "registroDeSoporteTecnicoToolStripMenuItem";
            this.registroDeSoporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.registroDeSoporteTecnicoToolStripMenuItem.Text = "Registro de Soporte Tecnico";
            this.registroDeSoporteTecnicoToolStripMenuItem.Click += new System.EventHandler(this.registroDeSoporteTecnicoToolStripMenuItem_Click);
            // 
            // listadoDeSoporteTecnicoToolStripMenuItem
            // 
            this.listadoDeSoporteTecnicoToolStripMenuItem.Name = "listadoDeSoporteTecnicoToolStripMenuItem";
            this.listadoDeSoporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.listadoDeSoporteTecnicoToolStripMenuItem.Text = "Listado de Soporte Tecnico";
            this.listadoDeSoporteTecnicoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSoporteTecnicoToolStripMenuItem_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            this.ventanaToolStripMenuItem.Click += new System.EventHandler(this.ventanaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // stbPrincipal
            // 
            this.stbPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusFecha});
            this.stbPrincipal.Location = new System.Drawing.Point(0, 428);
            this.stbPrincipal.Name = "stbPrincipal";
            this.stbPrincipal.Size = new System.Drawing.Size(800, 22);
            this.stbPrincipal.TabIndex = 2;
            this.stbPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusFecha
            // 
            this.toolStripStatusFecha.Name = "toolStripStatusFecha";
            this.toolStripStatusFecha.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusFecha.Text = "toolStripStatusFecha";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(36, 24);
            this.toolStripSplitButton1.Text = "Registro Sistema";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(36, 24);
            this.toolStripSplitButton2.Text = "Registro Clientes";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(36, 24);
            this.toolStripSplitButton3.Text = "Registro Versiones";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.toolStripSplitButton3_ButtonClick);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stbPrincipal);
            this.Controls.Add(this.MnPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Software de Gestión de Versiones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MnPrincipal.ResumeLayout(false);
            this.MnPrincipal.PerformLayout();
            this.stbPrincipal.ResumeLayout(false);
            this.stbPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stbPrincipal;
        private System.Windows.Forms.ToolStripMenuItem registroDeSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVersionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeVersionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeSoporteTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSoporteTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFecha;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem busquedaSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
    }
}