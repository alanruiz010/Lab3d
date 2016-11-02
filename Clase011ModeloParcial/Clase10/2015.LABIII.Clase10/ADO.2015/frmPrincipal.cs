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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void PersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonas frm = new frmPersonas();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Text = "Alta de Personas";

            frm.ShowDialog();

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                DataRow fila = Program.dsADO_2015.Tables["Personas"].NewRow();
                string sexo = "M";

                if (frm.Sexo == ESexualidad.Femenino)
                {
                    sexo = "F";
                }

                fila[0] = frm.Dni;
                fila[1] = sexo;
                fila[2] = frm.Apellido;
                fila[3] = frm.Nombre;
                fila[4] = frm.Provincia + 1;

                Program.dsADO_2015.Tables["Personas"].Rows.Add(fila);
            }

        }

        private void PersonasPorProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaPersonas frm = new frmBusquedaPersonas(ETablasADO.Personas);

            frm.Text = "Búsquedas de Personas por Provincia";

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void PersonasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos(ETablasADO.Personas);

            frm.Text = "Personas";

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void ProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos(ETablasADO.Provincias);

            frm.Text = "Provincias";

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.ADO.ClaseADO objADO = new Entidades.ADO.ClaseADO();

                if( !objADO.SincronizarConBD(Program.dsADO_2015.Tables["Personas"]) )
                    MessageBox.Show("No se ha podido actualizar la BD!!!");
                else
                    MessageBox.Show("La BD ha sido actualizada!!!");            
            }
            catch(Exception)
            {

            }
        }
    }
}
