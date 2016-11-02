using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace LabC09
{
    public partial class Form1 : Form
    {
        private DataTable _localidades;
        private DataTable _proveedores;
        private DataTable _productos;
        private DataSet _unDataSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._localidades = Generadora.DefinirTabla(ETabla.Localidad);
            this._proveedores = Generadora.DefinirTabla(ETabla.Proveedor);
            this._productos = Generadora.DefinirTabla(ETabla.Producto);

            this._unDataSet = Generadora.CargarDataSet(new DataTable[] { this._localidades, this._productos, this._proveedores });

            MessageBox.Show("DataSet y DataTable creados");
        }
    }
}
