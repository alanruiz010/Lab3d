using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase02
{
    public partial class frmEmpleado : Clase02.frmPersona
    {
        public frmEmpleado()
        {
            InitializeComponent();
            frmPersona unaPersona = new frmPersona();
        }
        protected override void button1_Click(object sender, EventArgs e)
        {
          //  base.button1_Click(sender, e);
            MessageBox.Show("chauu");
        }
    }
}
