namespace archivoexel
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
            this.tbDatos = new System.Windows.Forms.TextBox();
            this.btnleer = new System.Windows.Forms.Button();
            this.dgvExel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDatos
            // 
            this.tbDatos.Location = new System.Drawing.Point(12, 30);
            this.tbDatos.Multiline = true;
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Size = new System.Drawing.Size(329, 266);
            this.tbDatos.TabIndex = 0;
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(102, 344);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 1;
            this.btnleer.Text = "leer datos";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // dgvExel
            // 
            this.dgvExel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExel.Location = new System.Drawing.Point(410, 30);
            this.dgvExel.Name = "dgvExel";
            this.dgvExel.RowTemplate.Height = 24;
            this.dgvExel.Size = new System.Drawing.Size(623, 266);
            this.dgvExel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 450);
            this.Controls.Add(this.dgvExel);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.tbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDatos;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.DataGridView dgvExel;
    }
}

