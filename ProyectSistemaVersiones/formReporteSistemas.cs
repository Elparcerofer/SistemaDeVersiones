using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectSistemaVersiones
{
    public partial class formReporteSistemas : Form
    {
        public formReporteSistemas()
        {
            InitializeComponent();
        }

        private void reporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblSistema' Puede moverla o quitarla según sea necesario.
            this.tblSistemaTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblSistema);
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblSistema' Puede moverla o quitarla según sea necesario.
            this.tblSistemaTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblSistema);

            this.reportViewer1.RefreshReport();
        }
    }
}
