namespace ADO._2015
{
    partial class frmBusquedaPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(24, 52);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(420, 202);
            this.dgvDatos.TabIndex = 16;
            // 
            // cboProvincias
            // 
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(24, 25);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(175, 21);
            this.cboProvincias.TabIndex = 15;
            this.cboProvincias.SelectedIndexChanged += new System.EventHandler(this.cboProvincias_SelectedIndexChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(21, 9);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(131, 13);
            this.lblProvincia.TabIndex = 14;
            this.lblProvincia.Text = "Seleccione una Provincia:";
            // 
            // frmBusquedaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cboProvincias);
            this.Controls.Add(this.lblProvincia);
            this.Name = "frmBusquedaPersonas";
            this.Text = "frmBusquedaPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvDatos;
        protected System.Windows.Forms.ComboBox cboProvincias;
        internal System.Windows.Forms.Label lblProvincia;
    }
}