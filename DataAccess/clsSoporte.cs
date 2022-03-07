using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /*
     Estados de cada método
     0 = Exito
     1 = Error
     2 = No se encontró el registro
     */
    public class clsSoporte
    {
        //propiedades privadas
        private string strCadenaConexion;
        //propiedades publicas
        public string strErrores;
        public byte bytSistema;
        public int intCliente;
        public DateTime dteFecha;
        public string strProblema;
        public string strSolucion;
        public byte bytEstado;

        public clsSoporte(string strConexion)
        {
            //asigno la cadena
            strCadenaConexion = strConexion;
        }

        //insertar Datos
        public byte Add_Values()
        {
            return 0;
        }

        //Editar datos
        public byte Edit_Values()
        {
            return 0;
        }

        //Eliminar datos
        public byte Delete_Values()
        {
            return 0;
        }

        //Recuperar datos
        public byte Select_Values()
        {
            return 0;
        }
    }
}
