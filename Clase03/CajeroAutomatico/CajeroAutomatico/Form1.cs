using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calcular(object sender, EventArgs e)
        {
            MessageBox.Show("Calcular");
           
        }
        private void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("Informar");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += this.Calcular;
        }


    }
}
