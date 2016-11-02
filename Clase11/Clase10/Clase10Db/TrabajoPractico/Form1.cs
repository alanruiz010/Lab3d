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

namespace TrabajoPractico
{
    public partial class Form1 : Form
    {
        private SqlConnection _conexion;
       
        //-----------------------------
        private DataSet _dataSet;
        private SqlDataAdapter _dataAdapter;
        private SqlCommand _Select;
        private SqlCommand _Insert;
        private SqlCommand _Update;
        private SqlCommand _Delete;
       // private SqlConnection _Connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.Negocio);

          
        }
        private void CargarDataGrid()
        {
 
        }
        private void CargarEnSqlDB()
        {
            this._dataSet = new DataSet();

            SqlCommand _sqlComand = new SqlCommand();
            //tabla NEGOCIO----------no clientes
            _sqlComand.CommandText = "select * from Clientes";
            _sqlComand.Connection = this._conexion;

            this._dataAdapter = new SqlDataAdapter(_sqlComand);
            //tabla NEGOCIO---------no clientes
            this._dataAdapter = new SqlDataAdapter("select * from Clientes", this._conexion);
            //---------------------------------------------------------------------------------------
            this._Select = new SqlCommand("SELECT * FROM Productos", this._conexion);
            this._Insert = new SqlCommand("INSERT INTO Productos(Nombre,Tipo,Proveedor) VALUES (@Nombre, @Tipo, @Proveedor)",
            this._conexion);
            this._Update = new SqlCommand("UPDATE Productos SET Nombre = @Nombre,Tipo = @Tipo,Proveedor = @Proveedor WHERE Id_Producto = @Id_Producto",
            this._conexion);
            this._Delete = new SqlCommand("DELETE FROM Productos WHERE Id_Producto = @Id_Producto", this._conexion);
            //-----------------------------------------------
            this._dataAdapter = new SqlDataAdapter();
            this._dataAdapter.SelectCommand = this._Select;
            this._dataAdapter.InsertCommand = this._Insert;
            this._dataAdapter.UpdateCommand = this._Update;
            this._dataAdapter.DeleteCommand = this._Delete;
            this._dataAdapter.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.InsertCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");
            this._dataAdapter.DeleteCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");
        }
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
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
