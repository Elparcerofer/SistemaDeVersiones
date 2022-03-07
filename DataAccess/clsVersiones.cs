using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
   public class clsVersiones
    {
        //propiedades privadas
        private string strCadenaConexion;
        //propiedades publicas
        public string strErrores;
        public byte bytSistema;
        public DateTime dteFecha;
        public string strVersion;
        public string strCambios;
        public string strDetalle;
        public string strInstruccion;
        public string strEstado;
        public byte bytCodigoVersion;

        public clsVersiones(string strConexion)
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
                cmd.CommandText = "sp_Insert_Versiones";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SisCodigo", SqlDbType.TinyInt);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[0].Value = this.bytSistema;

                cmd.Parameters.Add("@VerFecha", SqlDbType.DateTime);
                cmd.Parameters[1].Direction = ParameterDirection.Input;
                cmd.Parameters[1].Value = this.dteFecha;

                cmd.Parameters.Add("@VerVersion", SqlDbType.VarChar);
                cmd.Parameters[2].Direction = ParameterDirection.Input;
                cmd.Parameters[2].Value = this.strVersion;

                cmd.Parameters.Add("@VerDetalle", SqlDbType.VarChar);
                cmd.Parameters[3].Direction = ParameterDirection.Input;
                cmd.Parameters[3].Value = this.strDetalle;

                cmd.Parameters.Add("@VerCambios", SqlDbType.VarChar);
                cmd.Parameters[4].Direction = ParameterDirection.Input;
                cmd.Parameters[4].Value = this.strCambios;

                cmd.Parameters.Add("@VerInstruccion", SqlDbType.VarChar);
                cmd.Parameters[5].Direction = ParameterDirection.Input;
                cmd.Parameters[5].Value = this.strInstruccion;

                cmd.Parameters.Add("@VerEstado", SqlDbType.VarChar);
                cmd.Parameters[6].Direction = ParameterDirection.Input;
                cmd.Parameters[6].Value = this.strEstado;

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
                cmd.CommandText = "sp_Update_Versiones";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@numeroId", SqlDbType.TinyInt);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[0].Value = this.bytCodigoVersion;

                cmd.Parameters.Add("@VerEstado", SqlDbType.VarChar);
                cmd.Parameters[1].Direction = ParameterDirection.Input;
                cmd.Parameters[1].Value = "Actualizado";

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
                cmd.CommandText = "sp_Delete_Versiones";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@numero", SqlDbType.TinyInt);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[0].Value = this.bytCodigoVersion;

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
    }
}
