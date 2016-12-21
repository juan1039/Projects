namespace prueba1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btnSueldo = new System.Windows.Forms.Button();
            this.btnPerfecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(28, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 0;
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(28, 92);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(100, 164);
            this.txtLista.TabIndex = 1;
            // 
            // btnSueldo
            // 
            this.btnSueldo.Location = new System.Drawing.Point(218, 49);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(75, 23);
            this.btnSueldo.TabIndex = 2;
            this.btnSueldo.Text = "Sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // btnPerfecto
            // 
            this.btnPerfecto.Location = new System.Drawing.Point(218, 132);
            this.btnPerfecto.Name = "btnPerfecto";
            this.btnPerfecto.Size = new System.Drawing.Size(75, 23);
            this.btnPerfecto.TabIndex = 3;
            this.btnPerfecto.Text = "Perfecto";
            this.btnPerfecto.UseVisualStyleBackColor = true;
            this.btnPerfecto.Click += new System.EventHandler(this.btnPerfecto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 328);
            this.Controls.Add(this.btnPerfecto);
            this.Controls.Add(this.btnSueldo);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Button btnPerfecto;
    }
}

