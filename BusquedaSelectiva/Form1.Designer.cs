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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.txtBoxBuscador = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnCopiarPortapapeles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTabla.Location = new System.Drawing.Point(12, 47);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(776, 391);
            this.dgvTabla.TabIndex = 0;
            // 
            // txtBoxBuscador
            // 
            this.txtBoxBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxBuscador.Location = new System.Drawing.Point(13, 21);
            this.txtBoxBuscador.Name = "txtBoxBuscador";
            this.txtBoxBuscador.Size = new System.Drawing.Size(324, 20);
            this.txtBoxBuscador.TabIndex = 1;
            this.txtBoxBuscador.TextChanged += new System.EventHandler(this.txtBoxBuscador_TextChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(408, 21);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(31, 23);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(445, 21);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(31, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(482, 21);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(43, 23);
            this.btnUltimo.TabIndex = 4;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(359, 21);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(43, 23);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnCopiarPortapapeles
            // 
            this.btnCopiarPortapapeles.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarPortapapeles.Location = new System.Drawing.Point(549, 18);
            this.btnCopiarPortapapeles.Name = "btnCopiarPortapapeles";
            this.btnCopiarPortapapeles.Size = new System.Drawing.Size(239, 23);
            this.btnCopiarPortapapeles.TabIndex = 6;
            this.btnCopiarPortapapeles.Text = "Copiar celda seleccionada en el portapapeles";
            this.btnCopiarPortapapeles.UseVisualStyleBackColor = true;
            this.btnCopiarPortapapeles.Click += new System.EventHandler(this.btnCopiarPortapapeles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopiarPortapapeles);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
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
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnCopiarPortapapeles;
    }
}

