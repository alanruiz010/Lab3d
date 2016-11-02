using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ADO._2015
{
    static class Program
    {
        public static System.Data.DataSet dsADO_2015;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Entidades.ADO.ClaseADO objADO = new Entidades.ADO.ClaseADO();
                Program.dsADO_2015 = objADO.ObtenerDataSetADO_2015();

                Program.dsADO_2015 = objADO.ObtenerDataSetADO_2015();

                frmPrincipal frm = new frmPrincipal();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;

                Application.Run(frm);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
