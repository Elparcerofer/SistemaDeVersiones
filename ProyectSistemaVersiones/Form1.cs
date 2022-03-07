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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmPrincipal objFormulario = new frmPrincipal();
            if((txtUsuario.Text == "admin") && (txtPassword.Text== "admin") && (cmbAcceso.Text == "admin"))
            {
                objFormulario.ShowDialog();
                objFormulario = null;
                this.Close();
            } else
            {
                MessageBox.Show("Datos Incorrectos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
