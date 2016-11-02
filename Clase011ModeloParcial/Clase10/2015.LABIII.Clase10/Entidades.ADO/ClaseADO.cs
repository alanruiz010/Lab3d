using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Entidades.ADO
{
    public class ClaseADO
    {
        private SqlConnection _cnn; 
        private SqlCommand _cmmSelect; 
        private SqlCommand _cmmInsert; 
        private SqlCommand _cmmUpdate; 
        private SqlCommand _cmmDelete;

        private SqlDataAdapter _da;
        private SqlDataReader _dr;

        public ClaseADO()
        {
            String cadenaConexion = Properties.Settings.Default.cnnADO2015;
            this._cnn = new SqlConnection(cadenaConexion);
        }

        public DataSet ObtenerDataSetADO_2015()
        {
            DataSet miDataSet = new DataSet("ADO-2015");

            miDataSet.Tables.Add(this.ObtenerPersonas());
            miDataSet.Tables.Add(this.ObtenerProvincias());

            DataRelation miRelacion = new DataRelation("ProvinciasPersonas",
                                                        miDataSet.Tables[1].Columns[0],
                                                        miDataSet.Tables[0].Columns[4]);

            miDataSet.Relations.Add(miRelacion);

            return miDataSet;

        }

        private DataTable ObtenerPersonas(){

            DataTable miTabla = new DataTable("Personas");

            this._da = new SqlDataAdapter("SELECT * FROM PERSONAS", this._cnn);
            

            try{

                this._da.Fill(miTabla);
            }
            catch(Exception)
            {
            }

            return miTabla;

        }

        public DataTable ObtenerProvincias()
        {
            DataTable miTabla = new DataTable("Provincias");
            SqlCommand cmm = new SqlCommand();



            try
            {
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM PROVINCIAS";
                cmm.Connection = this._cnn;

                this._cnn.Open();

                this._dr = cmm.ExecuteReader();

                miTabla.Load(this._dr);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (this._cnn.State != ConnectionState.Closed)
                {
                    this._cnn.Close();
                }
                    
            }


            return miTabla;
        }

        public Boolean SincronizarConBD(DataTable miDataTable)
        {
            Boolean sincronizoOK = false;

            this._cmmSelect = new SqlCommand("SELECT * FROM PERSONAS", this._cnn);

            this._cmmInsert = new SqlCommand("INSERT INTO PERSONAS VALUES(" +
                                                     "@Dni, @Sexo, @Apellido, " +
                                                     "@Nombre, @Provincia)",
                                                     this._cnn);

            this._cmmUpdate = new SqlCommand("UPDATE PERSONAS SET Apellido = @Apellido, " +
                                                     "Nombre = @Nombre, Provincia = @Provincia " +
                                                     "WHERE Dni = @Dni AND Sexo = @Sexo", this._cnn);

            this._cmmDelete = new SqlCommand("DELETE PERSONAS WHERE Dni = @Dni " +
                                                     "AND Sexo = @Sexo", this._cnn);

            this._da = new SqlDataAdapter();

            this._da.SelectCommand = this._cmmSelect;
            this._da.InsertCommand = this._cmmInsert;
            this._da.UpdateCommand = this._cmmUpdate;
            this._da.DeleteCommand = this._cmmDelete;

            SqlParameter idp = new SqlParameter("@Dni", SqlDbType.Int, 4, "Dni");

            this._da.InsertCommand.Parameters.Add(idp);
            this._da.InsertCommand.Parameters.Add("@Sexo", SqlDbType.Char, 1, "Sexo");
            this._da.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._da.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._da.InsertCommand.Parameters.Add("@Provincia", SqlDbType.Int, 4, "Provincia");


            this._da.UpdateCommand.Parameters.Add("@Dni", SqlDbType.Int, 4, "Dni");
            this._da.UpdateCommand.Parameters.Add("@Sexo", SqlDbType.Char, 1, "Sexo");
            this._da.UpdateCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._da.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._da.UpdateCommand.Parameters.Add("@Provincia", SqlDbType.Int, 4, "Provincia");


            this._da.DeleteCommand.Parameters.Add("@Dni", SqlDbType.Int, 4, "Dni");
            this._da.DeleteCommand.Parameters.Add("@Sexo", SqlDbType.Char, 1, "Sexo");


            try
            {
                this._da.Update(miDataTable);

                sincronizoOK = true;
            }
            catch (Exception)
            {

            }

            return sincronizoOK;

        }
    }
}
