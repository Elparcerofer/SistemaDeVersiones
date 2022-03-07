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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroSistema objSistema = new frmRegistroSistema();
            objSistema.MdiParent = this;
            objSistema.Show();
            objSistema = null;
        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroClientes objCliente= new frmRegistroClientes();
            objCliente.MdiParent = this;
            objCliente.Show();
            objCliente = null;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " " + Application.ProductVersion;
            this.toolStripStatusLabel1.Text = "Listo";

            this.toolStripStatusFecha.Text=DateTime.Today.Date.Day.ToString()+"/"+
                DateTime.Today.Date.Month.ToString() + "/"+
                DateTime.Today.Date.Year.ToString();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFlash objFlash = new frmFlash();
            objFlash.Show();
            objFlash = null;
        }

        private void listadoDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSistema objListadoSistema = new frmListadoSistema();
            objListadoSistema.MdiParent = this;
            objListadoSistema.Show();
            objListadoSistema = null;
        }

        private void listadoDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes objListadoCliente = new frmListadoClientes();
            objListadoCliente.MdiParent = this;
            objListadoCliente.Show();
            objListadoCliente = null;
        }

        private void listadoDeVersionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoVersiones objListadoVersiones = new frmListadoVersiones();
            objListadoVersiones.MdiParent = this;
            objListadoVersiones.Show();
            objListadoVersiones = null;
        }

        private void listadoDeSoporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSoporte objListadoSoporte = new frmListadoSoporte();
            objListadoSoporte.MdiParent = this;
            objListadoSoporte.Show();
            objListadoSoporte = null;
        }

        private void registroDeSoporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroSoporte objSoporte = new frmRegistroSoporte();
            objSoporte.MdiParent = this;
            objSoporte.Show();
            objSoporte = null;
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            frmRegistroSistema objSistema = new frmRegistroSistema();
            objSistema.MdiParent = this;
            objSistema.Show();
            objSistema = null;

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            frmRegistroSistema objClientes = new frmRegistroSistema();
            objClientes.MdiParent = this;
            objClientes.Show();
            objClientes = null;
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            frmRegistroVersiones objVersiones = new frmRegistroVersiones();
            objVersiones.MdiParent = this;
            objVersiones.Show();
            objVersiones = null;
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeVersionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroVersiones objVersiones = new frmRegistroVersiones();
            objVersiones.MdiParent = this;
            objVersiones.Show();
            objVersiones = null;
        }

        private void busquedaSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaSistema objBuscarSistema = new frmBusquedaSistema();
            objBuscarSistema.MdiParent = this;
            objBuscarSistema.Show();
            objBuscarSistema = null;
        }

        private void busquedaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente objBuscarCliente = new frmBusquedaCliente();
            objBuscarCliente.MdiParent = this;
            objBuscarCliente.Show();
            objBuscarCliente = null;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cliente = new Form2();
            cliente.MdiParent = this;
            cliente.Show();
            cliente = null;
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReporteSistemas sistem = new formReporteSistemas();
            sistem.MdiParent = this;
            sistem.Show();
            sistem = null;
        }
    }
}
