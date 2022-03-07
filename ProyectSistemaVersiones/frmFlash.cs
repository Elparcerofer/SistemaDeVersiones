using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ProyectSistemaVersiones
{
    public partial class frmFlash : Form
    {
        public frmFlash()
        {
            InitializeComponent();
        }

        private void frmFlash_Load(object sender, EventArgs e)
        {
            string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
            string AssemblyProduct = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyProductAttribute>().Product;
            //string AssemblyVersion = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyVersionAttribute>().Version;
            string AsseblyCopyright = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            //string AssemblyCompany = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            string AssemblyDescription = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;

            this.Text = String.Format("About {0}", AssemblyTitle);

            this.lblNombreProducto.Text = AssemblyProduct;
            this.lblVersion.Text = String.Format("Version {0}", AssemblyVersion);
            //this.lblVersion.Text = AssemblyVersion;
            this.lblCopyRight.Text = AsseblyCopyright;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyCompany
        {
            get
            {
                //get all company attributes on this assembly
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                //if there aren't any company attributes, return an empty string
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    }
    /*
    public static string AssemlyTitle
    {
        get
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        }
    }
            // More code follows
      /*
          //Generaci6n de los metodos para el assembly
          public static string AssemblyTitle
          {    get
              {
                  // Extraigo todos los atributos de la asamblea
                  object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                  // Si hay porlomenos un atributo
                  if (attributes.Length > 0)
                  {
                      AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];

                      // Seleccione el primero

                      // if es diferente de vacio:
                      if (titleAttribute.Title != "")
                          return titleAttribute.Title;
                  }
                  //sino habia ningún atributo, o si el atributo del itulo fuera vacio, vuelva el. el nombre del.exe
                  return
              System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
              }
          }
      ------------->>>>>>>
        /*

        public string AssemblyVersion
        {
            get
            {
                return
                Assembly.GetExecutingAssembly().GetName().Version.ToString();
                }
       }

        public string AssemblyDescription
        {
            get
            {
                // Extraigo la descripcion de los atributos
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                //consulto atributos
                if (attributes.Length == 0)
                    return "";
                return
                ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // extraer todoa loa atributo• de la Deacripci6n en data aaamblea
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // ai no hay •tributo5, devuelve vacio
                if (attributes.Length == O)
                    return "";
                // si hay un atributo del Producto, devuelva 5U valor
                return
                ((AssemblyProductAttribute)attributes[0]).Product;
            }
      }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // ai no hay •tributo5, devuelve vacio
                if (attributes.Length == O)
                    return "";
                // si hay un atributo del Producto, devuelva 5U valor
                return
                   ((AssemblyCopyrightAttribute)attributes[0]).Copyright;

            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // ai no hay •tributo5, devuelve vacio
                if (attributes.Length == O)
                    return "";
                // si hay un atributo del Producto, devuelva 5U valor
                return
                   ((AssemblyCompanyAttribute)attributes[0]).Company;

            }
        }

    */


}
