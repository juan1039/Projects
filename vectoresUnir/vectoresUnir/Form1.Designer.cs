namespace vectoresUnir
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
            this.btnVector1 = new System.Windows.Forms.Button();
            this.btnVector2 = new System.Windows.Forms.Button();
            this.btnVector3 = new System.Windows.Forms.Button();
            this.txtVector1 = new System.Windows.Forms.TextBox();
            this.txtVector2 = new System.Windows.Forms.TextBox();
            this.txtVector3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVector1
            // 
            this.btnVector1.Location = new System.Drawing.Point(37, 37);
            this.btnVector1.Name = "btnVector1";
            this.btnVector1.Size = new System.Drawing.Size(83, 35);
            this.btnVector1.TabIndex = 0;
            this.btnVector1.Text = "Vector 1";
            this.btnVector1.UseVisualStyleBackColor = true;
            this.btnVector1.Click += new System.EventHandler(this.btnVector1_Click);
            // 
            // btnVector2
            // 
            this.btnVector2.Location = new System.Drawing.Point(165, 37);
            this.btnVector2.Name = "btnVector2";
            this.btnVector2.Size = new System.Drawing.Size(83, 35);
            this.btnVector2.TabIndex = 1;
            this.btnVector2.Text = "Vector 2";
            this.btnVector2.UseVisualStyleBackColor = true;
            this.btnVector2.Click += new System.EventHandler(this.btnVector2_Click);
            // 
            // btnVector3
            // 
            this.btnVector3.Location = new System.Drawing.Point(299, 37);
            this.btnVector3.Name = "btnVector3";
            this.btnVector3.Size = new System.Drawing.Size(83, 35);
            this.btnVector3.TabIndex = 2;
            this.btnVector3.Text = "Vector 3";
            this.btnVector3.UseVisualStyleBackColor = true;
            this.btnVector3.Click += new System.EventHandler(this.btnVector3_Click);
            // 
            // txtVector1
            // 
            this.txtVector1.Location = new System.Drawing.Point(22, 90);
            this.txtVector1.Multiline = true;
            this.txtVector1.Name = "txtVector1";
            this.txtVector1.Size = new System.Drawing.Size(108, 369);
            this.txtVector1.TabIndex = 3;
            // 
            // txtVector2
            // 
            this.txtVector2.Location = new System.Drawing.Point(148, 83);
            this.txtVector2.Multiline = true;
            this.txtVector2.Name = "txtVector2";
            this.txtVector2.Size = new System.Drawing.Size(108, 492);
            this.txtVector2.TabIndex = 4;
            // 
            // txtVector3
            // 
            this.txtVector3.Location = new System.Drawing.Point(284, 83);
            this.txtVector3.Multiline = true;
            this.txtVector3.Name = "txtVector3";
            this.txtVector3.Size = new System.Drawing.Size(108, 492);
            this.txtVector3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 576);
            this.Controls.Add(this.txtVector3);
            this.Controls.Add(this.txtVector2);
            this.Controls.Add(this.txtVector1);
            this.Controls.Add(this.btnVector3);
            this.Controls.Add(this.btnVector2);
            this.Controls.Add(this.btnVector1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVector1;
        private System.Windows.Forms.Button btnVector2;
        private System.Windows.Forms.Button btnVector3;
        private System.Windows.Forms.TextBox txtVector1;
        private System.Windows.Forms.TextBox txtVector2;
        private System.Windows.Forms.TextBox txtVector3;
    }
}

