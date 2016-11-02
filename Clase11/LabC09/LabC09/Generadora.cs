using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LabC09
{
    public enum ETabla
    {
        Localidad,
        Proveedor,
        Producto
    }

    public class Generadora
    {
        public static DataTable DefinirTabla(ETabla unaTabla)
        {
            DataTable miTabla = new DataTable();

            switch (unaTabla)
            {
                case ETabla.Localidad:
                    miTabla.TableName = "Localidades";
                    miTabla.Columns.Add("Id",typeof(Int32));
                    miTabla.Columns.Add("Nombre",typeof(String));                    

                    miTabla.Columns[0].AutoIncrement = true;
                    miTabla.Columns[0].AutoIncrementSeed = 1;
                    miTabla.Columns[0].AutoIncrementStep = 1;

                    miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns[0] };
                    break;
                case ETabla.Proveedor:
                    miTabla.TableName = "Proveedores";
                    miTabla.Columns.Add("Id", typeof(Int32));
                    miTabla.Columns.Add("Nombre", typeof(String));
                    miTabla.Columns.Add("IdLocalidad", typeof(Int32));

                    miTabla.Columns[0].AutoIncrement = true;
                    miTabla.Columns[0].AutoIncrementSeed = 1;
                    miTabla.Columns[0].AutoIncrementStep = 1;

                    miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns[0] };
                    break;
                case ETabla.Producto:
                    miTabla.TableName = "Productos";
                    miTabla.Columns.Add("Id", typeof(Int32));
                    miTabla.Columns.Add("Nombre", typeof(String));
                    miTabla.Columns.Add("IdProveedor", typeof(Int32));

                    miTabla.Columns[0].AutoIncrement = true;
                    miTabla.Columns[0].AutoIncrementSeed = 1;
                    miTabla.Columns[0].AutoIncrementStep = 1;

                    miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns[0] };
                    break;
                default:
                    break;
            }
            return miTabla;
        }

        public static DataSet CargarDataSet(DataTable[] misTablas)
        {
            DataSet miDataSet = new DataSet();
            foreach (DataTable unaTabla in misTablas)
            {
                miDataSet.Tables.Add(unaTabla);
            }
            return miDataSet;
        }

        //public static DataSet CrearRelaciones(DataSet ds) 
        //{
        //    DataRelation dstRaltacion;

        //    dstRaltacion= new DataRelation(
        //}
    }
}
