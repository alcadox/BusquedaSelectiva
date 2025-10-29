namespace BusquedaSelectiva
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.txtBoxBuscador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 47);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(776, 391);
            this.dgvTabla.TabIndex = 0;
            // 
            // txtBoxBuscador
            // 
            this.txtBoxBuscador.Location = new System.Drawing.Point(13, 21);
            this.txtBoxBuscador.Name = "txtBoxBuscador";
            this.txtBoxBuscador.Size = new System.Drawing.Size(324, 20);
            this.txtBoxBuscador.TabIndex = 1;
            this.txtBoxBuscador.TextChanged += new System.EventHandler(this.txtBoxBuscador_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxBuscador);
            this.Controls.Add(this.dgvTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.TextBox txtBoxBuscador;
    }
}

