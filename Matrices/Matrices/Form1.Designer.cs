namespace Matrices
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
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnDiagonalPrincipal = new System.Windows.Forms.Button();
            this.btnDiagonalSecundaria = new System.Windows.Forms.Button();
            this.btnADP = new System.Windows.Forms.Button();
            this.btnADS = new System.Windows.Forms.Button();
            this.btnGirar = new System.Windows.Forms.Button();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(12, 12);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(72, 26);
            this.btnLlenar.TabIndex = 0;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 44);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(72, 26);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnDiagonalPrincipal
            // 
            this.btnDiagonalPrincipal.AutoSize = true;
            this.btnDiagonalPrincipal.Location = new System.Drawing.Point(12, 76);
            this.btnDiagonalPrincipal.Name = "btnDiagonalPrincipal";
            this.btnDiagonalPrincipal.Size = new System.Drawing.Size(132, 27);
            this.btnDiagonalPrincipal.TabIndex = 2;
            this.btnDiagonalPrincipal.Text = "Diagonal Principal";
            this.btnDiagonalPrincipal.UseVisualStyleBackColor = true;
            this.btnDiagonalPrincipal.Click += new System.EventHandler(this.btnDiagonalPrincipal_Click);
            // 
            // btnDiagonalSecundaria
            // 
            this.btnDiagonalSecundaria.AutoSize = true;
            this.btnDiagonalSecundaria.Location = new System.Drawing.Point(12, 108);
            this.btnDiagonalSecundaria.Name = "btnDiagonalSecundaria";
            this.btnDiagonalSecundaria.Size = new System.Drawing.Size(150, 27);
            this.btnDiagonalSecundaria.TabIndex = 3;
            this.btnDiagonalSecundaria.Text = "Diagonal Secundaria";
            this.btnDiagonalSecundaria.UseVisualStyleBackColor = true;
            this.btnDiagonalSecundaria.Click += new System.EventHandler(this.btnDiagonalSecundaria_Click);
            // 
            // btnADP
            // 
            this.btnADP.Location = new System.Drawing.Point(12, 140);
            this.btnADP.Name = "btnADP";
            this.btnADP.Size = new System.Drawing.Size(72, 26);
            this.btnADP.TabIndex = 4;
            this.btnADP.Text = "ADP";
            this.btnADP.UseVisualStyleBackColor = true;
            this.btnADP.Click += new System.EventHandler(this.btnADP_Click);
            // 
            // btnADS
            // 
            this.btnADS.Location = new System.Drawing.Point(12, 169);
            this.btnADS.Name = "btnADS";
            this.btnADS.Size = new System.Drawing.Size(72, 26);
            this.btnADS.TabIndex = 5;
            this.btnADS.Text = "ADS";
            this.btnADS.UseVisualStyleBackColor = true;
            this.btnADS.Click += new System.EventHandler(this.btnADS_Click);
            // 
            // btnGirar
            // 
            this.btnGirar.Location = new System.Drawing.Point(12, 201);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(72, 26);
            this.btnGirar.TabIndex = 6;
            this.btnGirar.Text = "Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(163, 12);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(151, 215);
            this.txtTabla.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 314);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.btnADS);
            this.Controls.Add(this.btnADP);
            this.Controls.Add(this.btnDiagonalSecundaria);
            this.Controls.Add(this.btnDiagonalPrincipal);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLlenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnDiagonalPrincipal;
        private System.Windows.Forms.Button btnDiagonalSecundaria;
        private System.Windows.Forms.Button btnADP;
        private System.Windows.Forms.Button btnADS;
        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.TextBox txtTabla;
    }
}

