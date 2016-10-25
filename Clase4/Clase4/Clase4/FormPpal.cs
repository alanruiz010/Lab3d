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
    public partial class FrmPpal : Form
    {
        public delegate void delegadoString(String mensaje);

        public delegadoString delegadoPrincipal;
        
        public FrmPpal()
        {
            InitializeComponent();
        }

        private void frmPpal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrigen frmOrigen = new FormOrigen();
            frmOrigen.MdiParent = this;
            frmOrigen.Show();
        }

        private void segundoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDestino frmDestino = new FormDestino();
            frmDestino.Show(this);
        }
    }
}
