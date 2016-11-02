namespace ADO._2015
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.AccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProvinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonasPorProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccionesToolStripMenuItem,
            this.SalirToolStripMenuItem,
            this.SalirToolStripMenuItem1});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(514, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "MenuStrip1";
            // 
            // AccionesToolStripMenuItem
            // 
            this.AccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarToolStripMenuItem,
            this.MostrarToolStripMenuItem,
            this.BusquedaToolStripMenuItem});
            this.AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem";
            this.AccionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.AccionesToolStripMenuItem.Text = "&Acciones";
            // 
            // AgregarToolStripMenuItem
            // 
            this.AgregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonasToolStripMenuItem});
            this.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem";
            this.AgregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AgregarToolStripMenuItem.Text = "Agregar";
            // 
            // PersonasToolStripMenuItem
            // 
            this.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem";
            this.PersonasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PersonasToolStripMenuItem.Text = "Personas";
            this.PersonasToolStripMenuItem.Click += new System.EventHandler(this.PersonasToolStripMenuItem_Click);
            // 
            // MostrarToolStripMenuItem
            // 
            this.MostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonasToolStripMenuItem1,
            this.ProvinciasToolStripMenuItem});
            this.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem";
            this.MostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // PersonasToolStripMenuItem1
            // 
            this.PersonasToolStripMenuItem1.Name = "PersonasToolStripMenuItem1";
            this.PersonasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.PersonasToolStripMenuItem1.Text = "Personas";
            this.PersonasToolStripMenuItem1.Click += new System.EventHandler(this.PersonasToolStripMenuItem1_Click);
            // 
            // ProvinciasToolStripMenuItem
            // 
            this.ProvinciasToolStripMenuItem.Name = "ProvinciasToolStripMenuItem";
            this.ProvinciasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ProvinciasToolStripMenuItem.Text = "Provincias";
            this.ProvinciasToolStripMenuItem.Click += new System.EventHandler(this.ProvinciasToolStripMenuItem_Click);
            // 
            // BusquedaToolStripMenuItem
            // 
            this.BusquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonasPorProvinciaToolStripMenuItem});
            this.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem";
            this.BusquedaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BusquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // PersonasPorProvinciaToolStripMenuItem
            // 
            this.PersonasPorProvinciaToolStripMenuItem.Name = "PersonasPorProvinciaToolStripMenuItem";
            this.PersonasPorProvinciaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PersonasPorProvinciaToolStripMenuItem.Text = "Personas por Provincia";
            this.PersonasPorProvinciaToolStripMenuItem.Click += new System.EventHandler(this.PersonasPorProvinciaToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.SalirToolStripMenuItem.Text = "&Sincronizar";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem1
            // 
            this.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1";
            this.SalirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.SalirToolStripMenuItem1.Text = "Salir";
            this.SalirToolStripMenuItem1.Click += new System.EventHandler(this.SalirToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip mnuMenu;
        internal System.Windows.Forms.ToolStripMenuItem AccionesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AgregarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PersonasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MostrarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PersonasToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ProvinciasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BusquedaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PersonasPorProvinciaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem1;
    }
}

