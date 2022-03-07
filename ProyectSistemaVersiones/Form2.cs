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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblCliente' Puede moverla o quitarla según sea necesario.
            this.tblClienteTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblCliente);
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblCliente' Puede moverla o quitarla según sea necesario.
            this.tblClienteTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblCliente);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
