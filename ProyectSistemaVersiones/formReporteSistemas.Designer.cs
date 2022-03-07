namespace ProyectSistemaVersiones
{
    partial class formReporteSistemas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dB_SistemaDataSetGeneral = new ProyectSistemaVersiones.DB_SistemaDataSetGeneral();
            this.tblSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSistemaTableAdapter = new ProyectSistemaVersiones.DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblSistemaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectSistemaVersiones.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1169, 450);
            this.reportViewer1.TabIndex = 0;
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
            // formReporteSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReporteSistemas";
            this.Text = "Reporte de Sisstemas";
            this.Load += new System.EventHandler(this.reporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_SistemaDataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSistemaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DB_SistemaDataSetGeneral dB_SistemaDataSetGeneral;
        private System.Windows.Forms.BindingSource tblSistemaBindingSource;
        private DB_SistemaDataSetGeneralTableAdapters.TblSistemaTableAdapter tblSistemaTableAdapter;
    }
}