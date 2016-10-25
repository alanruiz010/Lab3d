using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //public static int ComparisonAtributo(Entidad uno, Entidad dos);
        //Comparison<Entidades>();
        //Array.sort(Array,entiddad compararatributo)
        public Form1()
        {
          
            InitializeComponent();
        
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
        string _user;
        string _pass;
        private TextBox txtUser;
        private TextBox txtPassword;
        
        public Form1(string usu, string pass)
        {
            _user = usu;
            _pass = pass;
        }

        public Form1(TextBox txtUser, TextBox txtPassword)
        {
            // TODO: Complete member initialization
            this.txtUser = txtUser;
            this.txtPassword = txtPassword;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        
    }
}
