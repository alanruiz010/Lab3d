using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase02
{
    public partial class frmPersona : Form
    {
        public frmPersona()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            
            frm.Show();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = MaximumSize();
            this.IsMdiContainer = true;
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
        
    }
}
