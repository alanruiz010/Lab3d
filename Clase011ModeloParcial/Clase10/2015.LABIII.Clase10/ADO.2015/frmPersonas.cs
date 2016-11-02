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
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();

            Entidades.ADO.ClaseADO objADO = new Entidades.ADO.ClaseADO();

            foreach (DataRow item in objADO.ObtenerProvincias().Rows)
            {
                this.cboProvincias.Items.Add(item[1].ToString());
            }
        }

        public int Dni { 
            get { return int.Parse(this.txtDni.Text); }
            set { this.txtDni.Text = value.ToString(); }
        }

        public Boolean DniIsEnabled { 
            get { return this.txtDni.Enabled; }
            set { this.txtDni.Enabled = value; }
        }

        public Boolean SexoIsEnabled
        {
            set { 
                this.rdoFemenino.Enabled = value;
                this.rdoMasculino.Enabled = value;
            }
        }

        private ESexualidad _sexo;

        public ESexualidad Sexo
        {
            get { return _sexo; }
            set 
            {
                this._sexo = value;
                switch (this._sexo)
                {
                    case ESexualidad.Masculino:
                        this.rdoMasculino.Checked = true;
                        break;
                    case ESexualidad.Femenino:
                        this.rdoFemenino.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public string Apellido {
            get { return this.txtApellido.Text; }
            set { this.txtApellido.Text = value; }
        }

        public string Nombre {
            get { return this.txtNombre.Text; }
            set { this.txtNombre.Text = value; }
        }
        public int Provincia {
            get { return this.cboProvincias.SelectedIndex; }
            set { this.cboProvincias.SelectedIndex = value - 1; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
