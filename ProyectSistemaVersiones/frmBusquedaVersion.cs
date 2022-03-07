using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace ProyectSistemaVersiones
{
    public partial class frmBusquedaVersion : Form
    {
        private byte datoCoidogVersion = 0;
        public frmBusquedaVersion()
        {
            InitializeComponent();
        }

        private void fill_CargarDatos()
        {
            /*
            SqlConnection Conn = new SqlConnection(clsGeneral.strCadena);
            try
            {
                Conn.Open();
                this.dB_SistemaData_G.TblSistema.Clear();
                SqlDataAdapter asd = new SqlDataAdapter("SELECT * FROM TblSistema", Conn);
                asd.Fill(this.dB_SistemaData_G, "TblSistema");
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
            */
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var fila = DG_Version.CurrentRow;

            if (fila != null)
            {
                string strCadena = "server = PC-ADRIAN; database = DB_Sistema;Trusted_Connection = yes";
                clsVersiones Vversiones = new clsVersiones(strCadena);

                Vversiones.bytCodigoVersion = datoCoidogVersion;


                if (Vversiones.Edit_Values() == 1)
                {
                    MessageBox.Show(Vversiones.strErrores);
                }
                else
                {
                    MessageBox.Show("Registro Actualizado");
                    fill_CargarDatos();
                    Vversiones = null;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var fila = DG_Version.CurrentRow;

            if (fila != null)
            {
                string strCadena = "server = PC-ADRIAN; database = DB_Sistema;Trusted_Connection = yes";
                clsVersiones Vversiones = new clsVersiones(strCadena);

                Vversiones.bytCodigoVersion = datoCoidogVersion;


                if (Vversiones.Delete_Values() == 1)
                {
                    MessageBox.Show(Vversiones.strErrores);
                }
                else
                {
                    MessageBox.Show("Registro Eliminado");
                    fill_CargarDatos();
                    Vversiones = null;
                }
            }
        }
    }
}
