using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectSistemaVersiones.Class;
using System.Data.SqlClient;
using DataAccess;


namespace ProyectSistemaVersiones
{
    public partial class frmRegistroClientes : Form
    {
        private string valueCmb = "";
        public frmRegistroClientes()
        {
            InitializeComponent();
        }

        //controlador de interfaz
        // 1 = nuevo    2 = modificar   3 = Inicio/Fin

        private void ControladorInterfaz(byte estado)
        {
            switch (estado)
            {
                case 1:
                    //habilitar-deshabilitar controles
                    this.btnGuardar.Enabled = true;
                    this.grbDatosGenerales.Enabled = true;

                    //inicializar los valores predeterminados
                    this.txtRuc.Text = "230000XXXX";
                    this.txtNombre.Text = "Usuario";
                    this.txtDireccion.Text = "Santo Domingo";
                    this.txtTelefono.Text = "022222222";
                    this.txtContacto.Text = "099999XXXX";
                    this.cmbSistema.SelectedIndex = 0; 

                    //enviando foco
                    this.txtRuc.Focus();
                    break;
                case 2:
                    //habilitar-deshabilitar controles
                    this.btnGuardar.Enabled = true;
                    this.grbDatosGenerales.Enabled = true;

                    //inicializa valores predeterminados
                    this.txtRuc.Focus();
                    break;
                case 3:
                    //habilitar-deshabilitar controles
                    this.btnGuardar.Enabled = false;
                    this.grbDatosGenerales.Enabled = false;

                    break;
            }
        }

        private void btnBusquedaCliente_Click_1(object sender, EventArgs e)
        {
            frmBusquedaCliente objCliente = new frmBusquedaCliente();
            if (objCliente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("CANCEL");
            }
        }

        private void frmRegistroClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblSistema' Puede moverla o quitarla según sea necesario.
            this.tblSistemaTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblSistema);
            ControladorInterfaz(3);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControladorInterfaz(1);
        }

        private void getDatoCombo()
        {
            if (cmbSistema.SelectedIndex >= 0)
            {
                valueCmb = Convert.ToString(cmbSistema.SelectedValue);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            getDatoCombo();
            if (MessageBox.Show("¿Esta seguro que desea guardar?",
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //controlador de vacios
                if (clsGeneral.espacios(this.grbDatosGenerales) == false)
                {
                    string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                    clsCliente objCliente = new clsCliente(strCadena);
                    objCliente.bytCodigoSistema = Convert.ToByte(valueCmb);
                    objCliente.strRUC = Convert.ToString(this.txtRuc.Text);
                    objCliente.strNombre = Convert.ToString(this.txtNombre.Text);
                    ////
                    objCliente.strDireccion = Convert.ToString(this.txtDireccion.Text);
                    objCliente.strTelefono = Convert.ToString(this.txtTelefono.Text);
                    objCliente.strContacto = Convert.ToString(this.txtContacto.Text);
                    if (objCliente.Add_Values() == 1)
                    {
                        MessageBox.Show(objCliente.strErrores);
                    }
                    else
                    {
                        MessageBox.Show("Datos Guardados");
                        ControladorInterfaz(3);
                        objCliente = null;
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
