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
    public partial class frmBusquedaSistema : Form
    {
        private byte datoCodigoSistema;
        public frmBusquedaSistema()
        {
            InitializeComponent();
        }
        private void fill_CargarDatos()
        {
            //Config cadena conexion+
            SqlConnection Conn = new SqlConnection(clsGeneral.strCadena);
            try
            {
                Conn.Open();
                this.dB_SistemaDataSetGeneral.TblSistema.Clear();
                SqlDataAdapter asd = new SqlDataAdapter("SELECT * FROM TblSistema", Conn);
                asd.Fill(this.dB_SistemaDataSetGeneral, "TblSistema");
                asd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        private void frmBusquedaSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblSistema' Puede moverla o quitarla según sea necesario.
            this.tblSistemaTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblSistema);
            //this.fill_BuscarUsuario();
            this.fill_CargarDatos();


        }

        private void SelectRow()
        {
            var filaSeleccionada = DG_Sistema.CurrentRow;

            if (filaSeleccionada != null)
            {
                string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                clsSistema objSistema = new clsSistema(strCadena);
                this.datoCodigoSistema = Convert.ToByte(filaSeleccionada.Cells[0].Value);
                this.txtDetalle.Text = Convert.ToString(filaSeleccionada.Cells[1].Value);
                this.txtProyectManager.Text = Convert.ToString(filaSeleccionada.Cells[8].Value);
                this.txtDeveloperSenior.Text = Convert.ToString(filaSeleccionada.Cells[9].Value);
                this.txtTester.Text = Convert.ToString(filaSeleccionada.Cells[10].Value);
                this.txtHelpDesk.Text = Convert.ToString(filaSeleccionada.Cells[11].Value);  

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = DG_Sistema.CurrentRow;

            if (filaSeleccionada != null)
            {
                string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                clsSistema objSistema = new clsSistema(strCadena);

                objSistema.bytCodigoSistema = datoCodigoSistema;
                objSistema.strDetalle = txtDetalle.Text;           ////
                objSistema.strProyectanager = txtProyectManager.Text;
                objSistema.strDeveloperSenior = txtDeveloperSenior.Text;
                objSistema.strTester = txtTester.Text;
                objSistema.strSoporte = txtHelpDesk.Text;
                
                if (objSistema.Edit_Values() == 1)
                {
                    MessageBox.Show(objSistema.strErrores);
                }
                else
                {
                    MessageBox.Show("Datos Actualizados");
                    objSistema = null;
                    fill_CargarDatos();
                }
            }
            fill_CargarDatos();
        }

        private void DG_Sistema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = DG_Sistema.CurrentRow;

            if (filaSeleccionada != null)
            {
                string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                clsSistema objSistema = new clsSistema(strCadena);
                objSistema.bytCodigoSistema = Convert.ToByte(filaSeleccionada.Cells[0].Value);
                objSistema.strDetalle = Convert.ToString(filaSeleccionada.Cells[1].Value);
                objSistema.dteFechaInicio = Convert.ToDateTime(filaSeleccionada.Cells[2].Value);
                objSistema.dteFechaFinal = Convert.ToDateTime(filaSeleccionada.Cells[3].Value);
                ////
                objSistema.strSistemaOperativo = Convert.ToString(filaSeleccionada.Cells[4].Value);
                objSistema.strBaseDatos = Convert.ToString(filaSeleccionada.Cells[5].Value);
                objSistema.strDesarrollo = Convert.ToString(filaSeleccionada.Cells[6].Value);
                objSistema.strReportes = Convert.ToString(filaSeleccionada.Cells[7].Value);
                ////
                objSistema.strProyectanager = Convert.ToString(filaSeleccionada.Cells[8].Value);
                objSistema.strDeveloperSenior = Convert.ToString(filaSeleccionada.Cells[9].Value);
                objSistema.strTester = Convert.ToString(filaSeleccionada.Cells[10].Value);
                objSistema.strSoporte = Convert.ToString(filaSeleccionada.Cells[11].Value);

            }
        }

        private void vaciarTxt()
        {
            txtDetalle.Text = "";
            txtProyectManager.Text = "";
            txtDeveloperSenior.Text = "";
            ////
            txtTester.Text = "";
            txtHelpDesk.Text = "";
            datoCodigoSistema = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?",
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var fila = DG_Sistema.CurrentRow;

                if (fila != null)
                {
                    string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                    clsSistema objSistema = new clsSistema(strCadena);

                    objSistema.bytCodigoSistema = datoCodigoSistema;

                    if (objSistema.Delete_Values() == 1)
                    {
                        MessageBox.Show(objSistema.strErrores);
                    }
                    else
                    {
                        MessageBox.Show("Registro Eliminado");
                        fill_CargarDatos();
                        vaciarTxt();
                        objSistema = null;
                    }
                }
            }
        }

        private void DG_Sistema_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow();
        }
    }
}
