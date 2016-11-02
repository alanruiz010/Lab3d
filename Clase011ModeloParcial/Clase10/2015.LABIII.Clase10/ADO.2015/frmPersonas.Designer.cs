namespace ADO._2015
{
    partial class frmPersonas
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
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProvincias
            // 
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(54, 250);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(175, 21);
            this.cboProvincias.TabIndex = 21;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(51, 234);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 20;
            this.lblProvincia.Text = "Provincia:";
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdoFemenino);
            this.grpSexo.Controls.Add(this.rdoMasculino);
            this.grpSexo.Location = new System.Drawing.Point(54, 69);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(175, 49);
            this.grpSexo.TabIndex = 19;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(98, 19);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdoFemenino.TabIndex = 1;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(6, 19);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoMasculino.TabIndex = 0;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(54, 199);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 183);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(54, 148);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(175, 20);
            this.txtApellido.TabIndex = 16;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(51, 132);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(54, 43);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(175, 20);
            this.txtDni.TabIndex = 14;
            this.txtDni.Tag = "";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(51, 27);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "Dni:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(40, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 352);
            this.Controls.Add(this.cboProvincias);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmPersonas";
            this.Text = "frmPersonas";
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox cboProvincias;
        internal System.Windows.Forms.Label lblProvincia;
        internal System.Windows.Forms.GroupBox grpSexo;
        protected System.Windows.Forms.RadioButton rdoFemenino;
        protected System.Windows.Forms.RadioButton rdoMasculino;
        protected System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.Label lblApellido;
        protected System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.Label lblDni;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Button btnCancelar;
    }
}