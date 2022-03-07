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

    public class clsSistema
    {
        //propiedades privadas
        private string strCadenaConexion;
        //propiedades publicas
        public string strErrores;
        public byte bytCodigoSistema;
        public string strDetalle;
        public DateTime dteFechaInicio;
        public DateTime dteFechaFinal;
        public string strSistemaOperativo;
        public string strBaseDatos;
        public string strDesarrollo;
        public string strReportes;
        public string strProyectanager;
        public string strDeveloperSenior;
        public string strTester;
        public string strSoporte;


        public clsSistema(string strConexion)
        {
            //asigno la cadena
            strCadenaConexion = strConexion;
        }

        //insertar Datos
        public byte Add_Values()
        {
            Console.WriteLine("Standard Numeric Format Specifiers");
            byte bytEstado = 0;
            SqlConnection conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_Insert_Sistema";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SisDetalle", SqlDbType.VarChar);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[0].Value = this.strDetalle;

                cmd.Parameters.Add("@SisFechaInicio", SqlDbType.DateTime);
                cmd.Parameters[1].Direction = ParameterDirection.Input;
                cmd.Parameters[1].Value = this.dteFechaInicio;

                cmd.Parameters.Add("@SisFechaFinal", SqlDbType.DateTime);
                cmd.Parameters[2].Direction = ParameterDirection.Input;
                cmd.Parameters[2].Value = this.dteFechaFinal;

                cmd.Parameters.Add("@SisSistemaOperativo", SqlDbType.VarChar);
                cmd.Parameters[3].Direction = ParameterDirection.Input;
                cmd.Parameters[3].Value = this.strSistemaOperativo;

                cmd.Parameters.Add("@SisBaseDatos", SqlDbType.VarChar);
                cmd.Parameters[4].Direction = ParameterDirection.Input;
                cmd.Parameters[4].Value = this.strBaseDatos;

                cmd.Parameters.Add("@SisDesarrollo", SqlDbType.VarChar);
                cmd.Parameters[5].Direction = ParameterDirection.Input;
                cmd.Parameters[5].Value = this.strDesarrollo;

                cmd.Parameters.Add("@SisReportes", SqlDbType.VarChar);
                cmd.Parameters[6].Direction = ParameterDirection.Input;
                cmd.Parameters[6].Value = this.strReportes;

                cmd.Parameters.Add("@SisProyectManager", SqlDbType.VarChar);
                cmd.Parameters[7].Direction = ParameterDirection.Input;
                cmd.Parameters[7].Value = this.strProyectanager;

                cmd.Parameters.Add("@SisDeveloperSenior", SqlDbType.VarChar);
                cmd.Parameters[8].Direction = ParameterDirection.Input;
                cmd.Parameters[8].Value = this.strDeveloperSenior;

                cmd.Parameters.Add("@SisTester", SqlDbType.VarChar);
                cmd.Parameters[9].Direction = ParameterDirection.Input;
                cmd.Parameters[9].Value = this.strTester;

                cmd.Parameters.Add("@SisSoporte", SqlDbType.VarChar);
                cmd.Parameters[10].Direction = ParameterDirection.Input;
                cmd.Parameters[10].Value = this.strSoporte;

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
            SqlConnection conn2 = new SqlConnection(strCadenaConexion);
            try
            {
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn2;
                cmd2.CommandText = "sp_Update_Sistema";
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add("@numeroId", SqlDbType.TinyInt);
                cmd2.Parameters[0].Direction = ParameterDirection.Input;
                cmd2.Parameters[0].Value = this.bytCodigoSistema;

                cmd2.Parameters.Add("@SisDetalle", SqlDbType.VarChar);
                cmd2.Parameters[1].Direction = ParameterDirection.Input;
                cmd2.Parameters[1].Value = this.strDetalle;

                cmd2.Parameters.Add("@SisProyectManager", SqlDbType.VarChar);
                cmd2.Parameters[2].Direction = ParameterDirection.Input;
                cmd2.Parameters[2].Value = this.strProyectanager;

                cmd2.Parameters.Add("@SisDeveloperSenior", SqlDbType.VarChar);
                cmd2.Parameters[3].Direction = ParameterDirection.Input;
                cmd2.Parameters[3].Value = this.strDeveloperSenior;

                cmd2.Parameters.Add("@SisTester", SqlDbType.VarChar);
                cmd2.Parameters[4].Direction = ParameterDirection.Input;
                cmd2.Parameters[4].Value = this.strTester;

                cmd2.Parameters.Add("@SisSoporte", SqlDbType.VarChar);
                cmd2.Parameters[5].Direction = ParameterDirection.Input;
                cmd2.Parameters[5].Value = this.strSoporte;

                //Ejecutar coado
                cmd2.ExecuteNonQuery();
                bytEstado = 0;
            }
            catch (Exception ex)
            {
                strErrores = ex.Message.ToString();
                bytEstado = 1;
            }
            finally
            {
                conn2.Close();
            }
            return bytEstado;
        }

        //Eliminar datos
        public byte Delete_Values()
        {
            byte bytEstado = 0;
            SqlConnection conn3 = new SqlConnection(strCadenaConexion);
            try
            {
                conn3.Open();
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = conn3;
                cmd3.CommandText = "sp_Delete_Sistema";
                cmd3.CommandType = CommandType.StoredProcedure;

                cmd3.Parameters.Add("@numeroId", SqlDbType.TinyInt);
                cmd3.Parameters[0].Direction = ParameterDirection.Input;
                cmd3.Parameters[0].Value = this.bytCodigoSistema;

                cmd3.ExecuteNonQuery();
                bytEstado = 0;
            }
            catch (Exception ex)
            {
                strErrores = ex.Message.ToString();
                bytEstado = 1;
            }
            finally
            {
                conn3.Close();
            }
            return bytEstado;
        }
    }
}
