namespace dado1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCara1 = new System.Windows.Forms.TextBox();
            this.txtCara2 = new System.Windows.Forms.TextBox();
            this.txtCara3 = new System.Windows.Forms.TextBox();
            this.txtCara4 = new System.Windows.Forms.TextBox();
            this.txtCara5 = new System.Windows.Forms.TextBox();
            this.txtCara6 = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cara 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cara 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cara 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cara 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cara 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cara 6:";
            // 
            // txtCara1
            // 
            this.txtCara1.Location = new System.Drawing.Point(63, 4);
            this.txtCara1.Name = "txtCara1";
            this.txtCara1.Size = new System.Drawing.Size(100, 22);
            this.txtCara1.TabIndex = 6;
            // 
            // txtCara2
            // 
            this.txtCara2.Location = new System.Drawing.Point(63, 31);
            this.txtCara2.Name = "txtCara2";
            this.txtCara2.Size = new System.Drawing.Size(100, 22);
            this.txtCara2.TabIndex = 7;
            // 
            // txtCara3
            // 
            this.txtCara3.Location = new System.Drawing.Point(63, 58);
            this.txtCara3.Name = "txtCara3";
            this.txtCara3.Size = new System.Drawing.Size(100, 22);
            this.txtCara3.TabIndex = 8;
            // 
            // txtCara4
            // 
            this.txtCara4.Location = new System.Drawing.Point(63, 86);
            this.txtCara4.Name = "txtCara4";
            this.txtCara4.Size = new System.Drawing.Size(100, 22);
            this.txtCara4.TabIndex = 9;
            // 
            // txtCara5
            // 
            this.txtCara5.Location = new System.Drawing.Point(63, 113);
            this.txtCara5.Name = "txtCara5";
            this.txtCara5.Size = new System.Drawing.Size(100, 22);
            this.txtCara5.TabIndex = 10;
            // 
            // txtCara6
            // 
            this.txtCara6.Location = new System.Drawing.Point(63, 141);
            this.txtCara6.Name = "txtCara6";
            this.txtCara6.Size = new System.Drawing.Size(100, 22);
            this.txtCara6.TabIndex = 11;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(63, 191);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(100, 23);
            this.btnProcesar.TabIndex = 12;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 280);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtCara6);
            this.Controls.Add(this.txtCara5);
            this.Controls.Add(this.txtCara4);
            this.Controls.Add(this.txtCara3);
            this.Controls.Add(this.txtCara2);
            this.Controls.Add(this.txtCara1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCara1;
        private System.Windows.Forms.TextBox txtCara2;
        private System.Windows.Forms.TextBox txtCara3;
        private System.Windows.Forms.TextBox txtCara4;
        private System.Windows.Forms.TextBox txtCara5;
        private System.Windows.Forms.TextBox txtCara6;
        private System.Windows.Forms.Button btnProcesar;
    }
}

