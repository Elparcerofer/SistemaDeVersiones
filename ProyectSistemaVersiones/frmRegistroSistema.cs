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
    public partial class frmRegistroSistema : Form
    {
        private string SistemaOperativo = "";
        private string BaseDatos = "";
        private string LenguajeProgramacion = "";
        private string Reportes = "";

        public frmRegistroSistema()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ControladorInterfaz(byte estado)
        {
            switch (estado)
            {
                case 1:
                    this.btnGuardar.Enabled = true;
                    this.grbDatosGenerales.Enabled = true;
                    this.grbCaracteristicaDesarrollo.Enabled = true;
                    this.grbPersonalP.Enabled = true;

                    //this.txtCodigo.Text = "Auto";
                    this.txtDetalle.Text = "Ninguno";
                    this.dtpFechaFin.Value = DateTime.Today.Date;
                    this.dtpFechaInicio.Value = DateTime.Today.Date;
                    this.cmbSistemaOperativo.SelectedIndex = 0;
                    this.cmbSistemaOperativo.SelectedIndex = 0;
                    this.cmbBaseDatos.SelectedIndex = 0;
                    this.cmbLenguajeProgramacion.SelectedIndex = 0;
                    this.cmbReportes.SelectedIndex = 0;

                    this.txtProyectManager.Text = "Ninguno";
                    this.txtDeveloperSenior.Text = "Ninguno";
                    this.txtTester.Text = "Ninguno";
                    this.txtHelpDesk.Text = "Ninguno";

                    this.txtDetalle.Focus();
                    break;

                case 2:
                    break;

                case 3:
                    this.btnGuardar.Enabled = false;
                    this.grbDatosGenerales.Enabled = false;
                    this.grbCaracteristicaDesarrollo.Enabled = false;
                    this.grbPersonalP.Enabled = false;

                    this.txtDetalle.Focus();

                    break;

            }
        }

        private void btnBusquedaSistema_Click(object sender, EventArgs e)
        {
            frmBusquedaSistema objSistema = new frmBusquedaSistema();
            if (objSistema.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("CANCEL");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControladorInterfaz(1);
        }

        private void DatosCommboBox()
        {
            if (cmbSistemaOperativo.SelectedIndex == 0 || cmbSistemaOperativo.SelectedIndex == 1 || cmbSistemaOperativo.SelectedIndex == 2)
            {
                SistemaOperativo = Convert.ToString(cmbSistemaOperativo.SelectedItem);
            }
            if (cmbBaseDatos.SelectedIndex == 0 || cmbBaseDatos.SelectedIndex == 1 || cmbBaseDatos.SelectedIndex == 2 || cmbBaseDatos.SelectedIndex == 3)
            {
                BaseDatos = Convert.ToString(cmbBaseDatos.SelectedItem);
            }
            if (cmbLenguajeProgramacion.SelectedIndex == 0 || cmbLenguajeProgramacion.SelectedIndex == 1 || cmbLenguajeProgramacion.SelectedIndex == 2 || cmbLenguajeProgramacion.SelectedIndex == 3 || cmbLenguajeProgramacion.SelectedIndex == 4)
            {
                LenguajeProgramacion = Convert.ToString(cmbLenguajeProgramacion.SelectedItem);
            }
            if (cmbReportes.SelectedIndex == 0 || cmbReportes.SelectedIndex == 1 || cmbReportes.SelectedIndex == 2 || cmbReportes.SelectedIndex == 3)
            {
                Reportes = Convert.ToString(cmbReportes.SelectedItem);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro que desea guardar?",
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DatosCommboBox();
                //controlador de vacios
                if (clsGeneral.espacios(this.grbDatosGenerales) == false)
                    if (clsGeneral.espacios(this.grbCaracteristicaDesarrollo) == false)
                        if (clsGeneral.espacios(this.grbPersonalP) == false)
                            if (this.dtpFechaInicio.Value <= this.dtpFechaFin.Value)
                            {
                                string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                                clsSistema objSistema = new clsSistema(strCadena);
                                objSistema.strDetalle = this.txtDetalle.Text;
                                objSistema.dteFechaInicio = Convert.ToDateTime(this.dtpFechaInicio.Text);
                                objSistema.dteFechaFinal = Convert.ToDateTime(this.dtpFechaFin.Text);
                                ////
                                objSistema.strSistemaOperativo = SistemaOperativo;
                                objSistema.strBaseDatos = BaseDatos;
                                objSistema.strDesarrollo = LenguajeProgramacion;
                                objSistema.strReportes = Reportes;
                                ////
                                objSistema.strProyectanager = this.txtProyectManager.Text;
                                objSistema.strDeveloperSenior = this.txtDeveloperSenior.Text;
                                objSistema.strTester = this.txtTester.Text;
                                objSistema.strSoporte = this.txtHelpDesk.Text;


                                if (objSistema.Add_Values() == 1)
                                {
                                    MessageBox.Show(objSistema.strErrores);
                                } else
                                {
                                    MessageBox.Show("Ok");
                                    //controlador de interfaz
                                    ControladorInterfaz(3);
                                    objSistema = null;
                                }
                                
                            } else
                            {
                                MessageBox.Show("la fecha de inicio debe ser menor o igual a la fecha de fin",
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.dtpFechaInicio.Focus();
                            }
                        
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroSistema_Load(object sender, EventArgs e)
        {
            ControladorInterfaz(3);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
