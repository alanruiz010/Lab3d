using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clase10Db
{
    public partial class Form1 : Form
    {
        private SqlConnection _conexion;
        private SqlDataAdapter _dataAdapter;
        private DataSet _dataSet;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ACTIVO LA REFERENCIA DE LA CONEXION 
            this._conexion = new SqlConnection(Properties.Settings.Default.ConeDbAdapter);

            this._dataSet = new DataSet ();
            //CAMINO LARGO A LA CARGA Y CONEXION
            SqlCommand _sqlComand = new SqlCommand();

            _sqlComand.CommandText = "select * from Clientes";
            _sqlComand.Connection = this._conexion;

            this._dataAdapter = new SqlDataAdapter(_sqlComand);
            //this._dataAdapter.SelectCommand = _sqlComand;
            //------------------------
            //CAMINO CORTO A LA CARGA Y CONGIGURACION
            this._dataAdapter = new SqlDataAdapter("select * from Clientes", this._conexion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapter.Fill(this._dataSet, "Clientes");
                //bindeo enlazar
                this.dataGridView1.DataSource = this._dataSet.Tables["Clientes"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
                //throw;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapter.Fill(this._dataSet, "Clientes");
                //bindeo enlazar
                this.dataGridView1.DataSource = this._dataSet.Tables["Clientes"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                //throw;
            }
        }
    }
}
