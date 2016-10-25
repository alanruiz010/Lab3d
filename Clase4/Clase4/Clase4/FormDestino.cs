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
    public partial class FormDestino : Form
    {
        public FormDestino()
        {
            InitializeComponent();
        }


        private void mostrarMensaje(String mensaje)
        {
            this.lblMensaje.Text = mensaje;
        }

        private void FormDestino_Load(object sender, EventArgs e)
        {
            ((FrmPpal)this.Owner).delegadoPrincipal = this.mostrarMensaje;
        }
    }
}
