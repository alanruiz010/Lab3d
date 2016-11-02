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
    public partial class frmDatos : Form
    {
        private ETablasADO _queTabla;

        public frmDatos()
        {
            InitializeComponent();
        }
        public frmDatos(ETablasADO tabla)
            :this()
        {
            this._queTabla = tabla;
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();

            CargarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            int cantidadDeColumnas=0;
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

                    foreach (DataRow fila in Program.dsADO_2015.Tables["Personas"].Rows)
                    {
                        if (fila.RowState != DataRowState.Deleted)
                        {
                            this.dgvDatos.Rows.Add(fila.ItemArray);
                        }
                    }
                    break;
                case ETablasADO.Provincias:
                    foreach (DataRow fila in Program.dsADO_2015.Tables["Provincias"].Rows)
                    {
                        if (fila.RowState != DataRowState.Deleted)
                        {
                            this.dgvDatos.Rows.Add(fila.ItemArray);
                        }
                    }
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (this._queTabla)
            {
                case ETablasADO.Personas:
                    frmPersonas frm = new frmPersonas();
                    ESexualidad sexo;

                    frm.Text = "Modificación de Datos";
                    frm.StartPosition = FormStartPosition.CenterScreen;

                    frm.DniIsEnabled = false;
                    frm.SexoIsEnabled = false;

                    int indice = this.dgvDatos.SelectedRows[0].Index;
                    string sexoDeGrilla = this.dgvDatos.SelectedRows[0].Cells[1].Value.ToString();

                    if (sexoDeGrilla == "M")
                        sexo = ESexualidad.Masculino;
                    else
                        sexo = ESexualidad.Femenino;

                    frm.Dni = int.Parse(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
                    frm.Sexo = sexo;
                    frm.Apellido = this.dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
                    frm.Nombre = this.dgvDatos.SelectedRows[0].Cells[3].Value.ToString();
                    frm.Provincia = int.Parse(this.dgvDatos.SelectedRows[0].Cells[4].Value.ToString());

                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Program.dsADO_2015.Tables["Personas"].Rows[indice]["Apellido"] = frm.Apellido;
                        Program.dsADO_2015.Tables["Personas"].Rows[indice]["Nombre"] = frm.Nombre;
                        Program.dsADO_2015.Tables["Personas"].Rows[indice]["Provincia"] = frm.Provincia + 1;
                    }

                    CargarDataGridView();

                    break;
                case ETablasADO.Provincias:
                    //REALIZAR MODIFICACIÓN DE PROVINCIAS
                    break;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            switch (this._queTabla)
            {
                case ETablasADO.Personas:
                    frmPersonas frm = new frmPersonas();
                    ESexualidad sexo;

                    frm.Text = "Eliminación de Datos";
                    frm.StartPosition = FormStartPosition.CenterScreen;

                    frm.DniIsEnabled = false;
                    frm.SexoIsEnabled = false;

                    int indice = this.dgvDatos.SelectedRows[0].Index;
                    string sexoDeGrilla = this.dgvDatos.SelectedRows[0].Cells[1].Value.ToString();

                    if (sexoDeGrilla == "M")
                        sexo = ESexualidad.Masculino;
                    else
                        sexo = ESexualidad.Femenino;

                    frm.Dni = int.Parse(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
                    frm.Sexo = sexo;
                    frm.Apellido = this.dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
                    frm.Nombre = this.dgvDatos.SelectedRows[0].Cells[3].Value.ToString();
                    frm.Provincia = int.Parse(this.dgvDatos.SelectedRows[0].Cells[4].Value.ToString());

                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Program.dsADO_2015.Tables["Personas"].Rows[indice].Delete();
                    }

                    CargarDataGridView();

                    break;
                case ETablasADO.Provincias:
                    //REALIZAR MODIFICACIÓN DE PROVINCIAS
                    break;
            }
        }

        private void btnRowState_Click(object sender, EventArgs e)
        {
            frmRowState frm = new frmRowState(this._queTabla);

            frm.Text = "RowState";

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

    }
}
