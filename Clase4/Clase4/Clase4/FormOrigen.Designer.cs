namespace Clase4
{
    partial class FormOrigen
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
            this.lblTextoAEnviar = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextoAEnviar
            // 
            this.lblTextoAEnviar.AutoSize = true;
            this.lblTextoAEnviar.Location = new System.Drawing.Point(92, 106);
            this.lblTextoAEnviar.Name = "lblTextoAEnviar";
            this.lblTextoAEnviar.Size = new System.Drawing.Size(90, 13);
            this.lblTextoAEnviar.TabIndex = 0;
            this.lblTextoAEnviar.Text = "SOY EL ORIGEN";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(84, 178);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 43);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar A Destino";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormOrigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblTextoAEnviar);
            this.Name = "FormOrigen";
            this.Text = "FormOrigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoAEnviar;
        private System.Windows.Forms.Button btnEnviar;
    }
}