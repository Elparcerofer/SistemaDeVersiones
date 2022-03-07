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

namespace SistemasVersiones
{
    public partial class frmFlash : Form
    {
        public frmFlash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFlash_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("About {0}" , AssemblyTitle);
            this.lblNombreProducto.Text = AssemblyProduct;

            this.lblVersion.Text = string.Format("Version {0}", AssemblyVersion);
            this.lblVersion.Text = AssemblyVersionAttribute;

            this.LBLCompanyName.Text = string.Format("Version {0}", AssemblyCompany);
            this.LBLCompanyName.Text = AssemblyCompany;

            this.richTextBox1.Text = AssemblyProduct + AssemblyVersion;
        }
    }
}
