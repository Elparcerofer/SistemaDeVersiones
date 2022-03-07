using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectSistemaVersiones.Class
{
    class clsGeneral
    {
        static public string strCadena = "server = DESKTOP-BK7IQSQ; database = DB_Sistema;Trusted_Connection = yes";
        public static bool espacios(GroupBox objGrupo)
        {
            bool bolValor = false;
            //recorrer controles de grupo
            for(int intContador = 0; intContador<objGrupo.Controls.Count; intContador++)
            {
                if (objGrupo.Controls[intContador].Enabled == true)
                {
                    if ((objGrupo.Controls[intContador] is TextBox) || (objGrupo.Controls[intContador] is ComboBox))
                    {
                        if ((objGrupo.Controls[intContador].Text == ""))
                        {
                            bolValor = true;
                            MessageBox.Show(objGrupo.Controls[intContador].Tag.ToString(),
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            objGrupo.Controls[intContador].Focus();
                            break;
                        }
                    }
                }
            }
            return bolValor;
        }
    }
}
