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
    public partial class frmRowState : Form
    {
        private ETablasADO _queTabla;

        public frmRowState()
        {
            InitializeComponent();
        }
        public frmRowState(ETablasADO tabla)
            : this()
        {
            DataTable dt = null;

            this._queTabla = tabla;

            switch (this._queTabla)
            {
                case ETablasADO.Personas:
                    dt = Program.dsADO_2015.Tables["Personas"];
                    break;
                case ETablasADO.Provincias:
                    dt = Program.dsADO_2015.Tables["Provincias"];
                    break;
                default:
                    break;
            }

            foreach (DataRow item in dt.Rows)
            {
                this.dgvRowState.Rows.Add(item.RowState.ToString());
            }

        }
    }
}
