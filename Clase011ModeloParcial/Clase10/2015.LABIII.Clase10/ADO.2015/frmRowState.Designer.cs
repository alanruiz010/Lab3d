namespace ADO._2015
{
    partial class frmRowState
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
            this.dgvRowState = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowState)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRowState
            // 
            this.dgvRowState.AllowUserToAddRows = false;
            this.dgvRowState.AllowUserToDeleteRows = false;
            this.dgvRowState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRowState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvRowState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRowState.Location = new System.Drawing.Point(0, 0);
            this.dgvRowState.Name = "dgvRowState";
            this.dgvRowState.ReadOnly = true;
            this.dgvRowState.Size = new System.Drawing.Size(284, 262);
            this.dgvRowState.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Estado de la Fila";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmRowState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dgvRowState);
            this.Name = "frmRowState";
            this.Text = "frmRowState";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvRowState;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}