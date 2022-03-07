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
    public partial class frmBusquedaCliente : Form
    {
        private byte datoCodigoCliente;
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }
        private void fill_BuscarCliente()
        {
            SqlConnection Conn = new SqlConnection(clsGeneral.strCadena);
            try
            {
                Conn.Open();
                this.dB_SistemaDataSetGeneral.TblCliente.Clear();
                SqlDataAdapter asd = new SqlDataAdapter("SELECT * FROM TblCliente", Conn);
                asd.Fill(this.dB_SistemaDataSetGeneral, "TblCliente");
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

        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblCliente' Puede moverla o quitarla según sea necesario.
            this.tblClienteTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblCliente);
            this.fill_BuscarCliente();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vaciarTxt()
        {
            txtRuc.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtContacto.Text = "";
        }

        private void SelectRow()
        {
            var fila = DG_Clientes.CurrentRow;

            if (fila != null)
            {
                txtRuc.Text = Convert.ToString(fila.Cells[1].Value);
                txtNombre.Text = Convert.ToString(fila.Cells[2].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[3].Value);
                ////
                txtTelefono.Text = Convert.ToString(fila.Cells[4].Value);
                txtContacto.Text = Convert.ToString(fila.Cells[5].Value);
                datoCodigoCliente = Convert.ToByte(fila.Cells[6].Value);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //SelectRow()
            var fila = DG_Clientes.CurrentRow;

            if (fila != null)
            {
                string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                clsCliente objCliente = new clsCliente(strCadena);

                objCliente.strRUC = txtRuc.Text;
                objCliente.strNombre = txtNombre.Text;
                objCliente.strDireccion = txtDireccion.Text;
                ////
                objCliente.strTelefono = txtTelefono.Text;
                objCliente.strContacto = txtContacto.Text;
                objCliente.bytCodigoCliente = datoCodigoCliente;

                if (objCliente.Edit_Values() == 1)
                {
                    MessageBox.Show(objCliente.strErrores);
                }
                else
                {
                    MessageBox.Show("Registro Actualizado");
                    fill_BuscarCliente();
                    objCliente = null;
                    vaciarTxt();
                }
            }

        }

        private void DG_Clientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?",
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var fila = DG_Clientes.CurrentRow;

                if (fila != null)
                {
                    SelectRow();
                    string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                    clsCliente objCliente = new clsCliente(strCadena);

                    objCliente.bytCodigoCliente = datoCodigoCliente;

                    if (objCliente.Delete_Values() == 1)
                    {
                        MessageBox.Show(objCliente.strErrores);
                    }
                    else
                    {
                        MessageBox.Show("Registro Eliminado");
                        fill_BuscarCliente();
                        objCliente = null;
                        vaciarTxt();
                    }
                }
            }
        }
    }   
}
