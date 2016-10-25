using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4
{
    public partial class FormOrigen : Form
    {
        public FormOrigen()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmPpal frmPpal = (FrmPpal) this.MdiParent;

            if (frmPpal.delegadoPrincipal != null)
            {
                frmPpal.delegadoPrincipal(this.lblTextoAEnviar.Text);
            }
        }
    }
}
