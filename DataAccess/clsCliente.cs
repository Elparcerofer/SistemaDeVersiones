using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    /*
     Estados de cada método
     0 = Exito
     1 = Error
     2 = No se encontró el registro
     */
    public class clsCliente
    {
        //propiedades privadas
        private string strCadenaConexion;
        //propiedades publicas
        public string strErrores;
        public string strRUC;
        public string strNombre;
        public string strDireccion;
        public string strTelefono;
        public string strContacto;
        public byte bytCodigoSistema;

        public byte bytCodigoCliente;

        public clsCliente(string strConexion)
        {
            //asigno la cadena
            strCadenaConexion = strConexion;
        }

        //insertar Datos
        public byte Add_Values()
        {
            byte bytEstado = 0;
            SqlConnection conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_Insert_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SisCodigo", SqlDbType.TinyInt);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[0].Value = this.bytCodigoSistema;

                cmd.Parameters.Add("@CliRUC", SqlDbType.VarChar);
                cmd.Parameters[1].Direction = ParameterDirection.Input;
                cmd.Parameters[1].Value = this.strRUC;

                cmd.Parameters.Add("@CliNombre", SqlDbType.VarChar);
                cmd.Parameters[2].Direction = ParameterDirection.Input;
                cmd.Parameters[2].Value = this.strNombre;

                cmd.Parameters.Add("@CliDireccion", SqlDbType.VarChar);
                cmd.Parameters[3].Direction = ParameterDirection.Input;
                cmd.Parameters[3].Value = this.strDireccion;

                cmd.Parameters.Add("@CliTelefono", SqlDbType.VarChar);
                cmd.Parameters[4].Direction = ParameterDirection.Input;
                cmd.Parameters[4].Value = this.strTelefono;

                cmd.Parameters.Add("@CliContacto", SqlDbType.VarChar);
                cmd.Parameters[5].Direction = ParameterDirection.Input;
                cmd.Parameters[5].Value = this.strContacto;

                //Ejecutar coado
                cmd.ExecuteNonQuery();
                bytEstado = 0;
            }
            catch (Exception ex)
            {
                strErrores = ex.Message.ToString();
                bytEstado = 1;
            }
            finally
            {
                conn.Close();
            }
            return bytEstado;
        }

        //Editar datos
        public byte Edit_Values()
        {
            byte bytEstado = 0;
            SqlConnection conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_Update_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@numeroId", SqlDbType.TinyInt);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[0].Value = this.bytCodigoCliente;

                cmd.Parameters.Add("@cliRUC", SqlDbType.VarChar);
                cmd.Parameters[1].Direction = ParameterDirection.Input;
                cmd.Parameters[1].Value = this.strRUC;

                cmd.Parameters.Add("@CliNombre", SqlDbType.VarChar);
                cmd.Parameters[2].Direction = ParameterDirection.Input;
                cmd.Parameters[2].Value = this.strNombre;

                cmd.Parameters.Add("@CliDireccion", SqlDbType.VarChar);
                cmd.Parameters[3].Direction = ParameterDirection.Input;
                cmd.Parameters[3].Value = this.strDireccion;

                cmd.Parameters.Add("@CliTelefono", SqlDbType.VarChar);
                cmd.Parameters[4].Direction = ParameterDirection.Input;
                cmd.Parameters[4].Value = this.strTelefono;

                cmd.Parameters.Add("@CliContacto", SqlDbType.VarChar);
                cmd.Parameters[5].Direction = ParameterDirection.Input;
                cmd.Parameters[5].Value = this.strContacto;

                //Ejecutar coado
                cmd.ExecuteNonQuery();
                bytEstado = 0;

            }
            catch (Exception ex)
            {
                strErrores = ex.Message.ToString();
                bytEstado = 1;
            }
            finally
            {
                conn.Close();
            }
            return bytEstado;
        }

        //Eliminar datos
        public byte Delete_Values()
        {
            byte bytEstado = 0;
            SqlConnection conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_Delete_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@numero", SqlDbType.TinyInt);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[0].Value = this.bytCodigoCliente;

                //Ejecutar coado
                cmd.ExecuteNonQuery();
                bytEstado = 0;

            }
            catch (Exception ex)
            {
                strErrores = ex.Message.ToString();
                bytEstado = 1;
            }
            finally
            {
                conn.Close();
            }
            return bytEstado;
        }

        //Recuperar datos
        public byte Select_Values()
        {
            return 0;
        }
    }
}
