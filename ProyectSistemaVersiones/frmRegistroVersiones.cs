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
    public partial class frmRegistroVersiones : Form
    {
        private string datoCmbx ="";
        private byte codigoVersion;
        public frmRegistroVersiones()
        {
            InitializeComponent();
        }

        private void fill_Data()
        {
            SqlConnection Conn = new SqlConnection(clsGeneral.strCadena);
            try
            {
                Conn.Open();
                this.dB_SistemaDataSetGeneral.TblVersion.Clear();
                SqlDataAdapter asd = new SqlDataAdapter("SELECT * FROM TblVersion", Conn);
                asd.Fill(this.dB_SistemaDataSetGeneral, "TblVersion");
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

        private void ControladorInterfaz(byte estado)
        {
            switch (estado)
            {
                case 1:
                    this.cmbSistema.Enabled = true;
                    this.cmbSistema.SelectedIndex = 0;
                    this.btnGuardar.Enabled = true;
                    this.grbRegistroVersiones.Enabled = true;
                    this.dtpRegistroFecha.Value = DateTime.Today.Date;

                    this.txtVersion.Text = "Beta";
                    this.txtDetalleGeneral.Text = "Sistema no funciona";
                    this.txtCambio.Text = "Interfaces ....";
                    this.txtInstrucciones.Text = "Ejecutar";
                    break;

                case 2:
                    break;

                case 3:
                    this.btnGuardar.Enabled = false;
                    this.grbRegistroVersiones.Enabled = false;
                    this.cmbSistema.Enabled = false;

                    break;

            }
        }

        private void datoComboBox()
        {
            if (cmbSistema.SelectedIndex >= 0)
            {
                datoCmbx = Convert.ToString(cmbSistema.SelectedValue);
            }
            
        }

        private void frmRegistroVersiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblVersion' Puede moverla o quitarla según sea necesario.
            this.tblVersionTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblVersion);
            // TODO: esta línea de código carga datos en la tabla 'dB_SistemaDataSetGeneral.TblSistema' Puede moverla o quitarla según sea necesario.
            this.tblSistemaTableAdapter.Fill(this.dB_SistemaDataSetGeneral.TblSistema);
            ControladorInterfaz(3);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControladorInterfaz(1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            datoComboBox();
            if (MessageBox.Show("¿Esta seguro que desea guardar?",
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    if (clsGeneral.espacios(this.grbRegistroVersiones) == false)
                        if (this.dtpRegistroFecha.Value <= DateTime.Today.Date)
                        {
                            string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                            clsVersiones objVersion = new clsVersiones(strCadena);
                            objVersion.bytSistema = Convert.ToByte(datoCmbx);
                            objVersion.dteFecha = Convert.ToDateTime(this.dtpRegistroFecha.Text);
                            objVersion.strVersion = Convert.ToString(this.txtVersion.Text);
                            ////
                            objVersion.strCambios = Convert.ToString(this.txtCambio.Text);
                            objVersion.strDetalle = Convert.ToString(this.txtDetalleGeneral.Text);
                            objVersion.strInstruccion = Convert.ToString(this.txtInstrucciones.Text);
                            objVersion.strEstado = "Pendiente";

                            if (objVersion.Add_Values() == 1)
                            {
                                MessageBox.Show(objVersion.strErrores);
                            }
                            else
                            {
                                MessageBox.Show("Datos Guardados Correctamente");
                                //controlador de interfaz
                                ControladorInterfaz(3);
                                objVersion = null;
                                fill_Data();
                            }
                        }
                        else
                        {
                            MessageBox.Show("la fecha de inicio debe ser menor o igual a la fecha de fin",
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dtpRegistroFecha.Focus();
                        }
            }
        }

        private void SelectRow()
        {
            var fila = DG_Versiones.CurrentRow;

            if (fila != null)
            {
                codigoVersion = Convert.ToByte(fila.Cells[1].Value);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var fila = DG_Versiones.CurrentRow;

            if (fila != null)
            {
                string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                clsVersiones obj = new clsVersiones(strCadena);
                obj.bytCodigoVersion = codigoVersion;

                if (obj.Delete_Values() == 1)
                {
                    MessageBox.Show(obj.strErrores);
                }
                else
                {
                    MessageBox.Show("Registro Eliminado");
                    fill_Data();
                    obj = null;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var fila = DG_Versiones.CurrentRow;

            if (fila != null)
            {
                string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
                clsVersiones obj = new clsVersiones(strCadena);
                obj.bytCodigoVersion = codigoVersion;

                if (obj.Edit_Values() == 1)
                {
                    MessageBox.Show(obj.strErrores);
                }
                else
                {
                    MessageBox.Show("Registro Actualizado");
                    fill_Data();
                    obj = null;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fill_Data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
