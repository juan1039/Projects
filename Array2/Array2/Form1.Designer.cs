namespace Array2
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.btnPares = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnGAbajo = new System.Windows.Forms.Button();
            this.btnGArriba = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(25, 27);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(75, 23);
            this.btnPares.TabIndex = 0;
            this.btnPares.Text = "Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(25, 172);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(75, 23);
            this.btnInvertir.TabIndex = 1;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // btnGAbajo
            // 
            this.btnGAbajo.Location = new System.Drawing.Point(25, 143);
            this.btnGAbajo.Name = "btnGAbajo";
            this.btnGAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnGAbajo.TabIndex = 2;
            this.btnGAbajo.Text = "G. abajo";
            this.btnGAbajo.UseVisualStyleBackColor = true;
            this.btnGAbajo.Click += new System.EventHandler(this.btnGAbajo_Click);
            // 
            // btnGArriba
            // 
            this.btnGArriba.Location = new System.Drawing.Point(25, 114);
            this.btnGArriba.Name = "btnGArriba";
            this.btnGArriba.Size = new System.Drawing.Size(75, 23);
            this.btnGArriba.TabIndex = 3;
            this.btnGArriba.Text = "G. arriba";
            this.btnGArriba.UseVisualStyleBackColor = true;
            this.btnGArriba.Click += new System.EventHandler(this.btnGArriba_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(25, 85);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(25, 56);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(75, 23);
            this.btnImpares.TabIndex = 5;
            this.btnImpares.Text = "Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(106, 27);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(100, 212);
            this.txtMostrar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 251);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGArriba);
            this.Controls.Add(this.btnGAbajo);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnPares);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnGAbajo;
        private System.Windows.Forms.Button btnGArriba;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.TextBox txtMostrar;
    }
}

