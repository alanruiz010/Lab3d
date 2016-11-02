using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO._2015
{
    public partial class frmBusquedaPersonas : Form
    {
        private ETablasADO _queTabla;

        public frmBusquedaPersonas()
        {
            InitializeComponent();
        }
        public frmBusquedaPersonas(ETablasADO tabla)
            : this()
        {
            this._queTabla = tabla;

            ConfigurarDataGridView();

            foreach (DataRow item in Program.dsADO_2015.Tables["Provincias"].Rows)
            {
                this.cboProvincias.Items.Add(item[1].ToString());   
            }

            this.cboProvincias.SelectedIndex = 0;

        }

        private void ConfigurarDataGridView()
        {
            int cantidadDeColumnas = 0;
            List<string> nombreColumnas = new List<string>();

            switch (this._queTabla)
            {
                case ETablasADO.Personas:
                    cantidadDeColumnas = Program.dsADO_2015.Tables["Personas"].Columns.Count;
                    foreach (DataColumn columna in Program.dsADO_2015.Tables["Personas"].Columns)
                    {
                        nombreColumnas.Add(columna.ColumnName);
                    }
                    break;
                case ETablasADO.Provincias:
                    cantidadDeColumnas = Program.dsADO_2015.Tables["Provincias"].Columns.Count;
                    foreach (DataColumn columna in Program.dsADO_2015.Tables["Provincias"].Columns)
                    {
                        nombreColumnas.Add(columna.ColumnName);
                    }
                    break;
            }
            //INDICO CANTIDAD DE COLUMNAS
            dgvDatos.ColumnCount = cantidadDeColumnas;

            //SETEO COLORES
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Violet;
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDatos.Font, FontStyle.Bold);


            dgvDatos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;

            dgvDatos.GridColor = Color.Black;

            dgvDatos.RowHeadersVisible = false;

            for (int index = 0; index < nombreColumnas.Count; index++)
            {
                dgvDatos.Columns[index].Name = nombreColumnas[index];
            }

            dgvDatos.MultiSelect = false; //multiselección No permitida
            dgvDatos.AllowUserToAddRows = false;

            nombreColumnas = null;
        }
        private void CargarDataGridView()
        {
            this.dgvDatos.Rows.Clear();

            switch (this._queTabla)
            {
                case ETablasADO.Personas:

                    int indice = this.cboProvincias.SelectedIndex;

                    DataRow filaPadre;

                    //CREO UN ARRAY DE DATAROW
                    DataRow[] filasHijas;

                    filaPadre = Program.dsADO_2015.Tables["Provincias"].Rows[indice];
                    filasHijas = filaPadre.GetChildRows("ProvinciasPersonas");

                    //RECORRO LA COLECCION DE FILAS HIJAS
                    foreach (DataRow fila in filasHijas)
	                {
                        if(fila.RowState != DataRowState.Deleted)
                        	this.dgvDatos.Rows.Add(fila.ItemArray);
	                }
                    break;
                case ETablasADO.Provincias:
                    break;
            }
        }

        private void cboProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

    }
}
