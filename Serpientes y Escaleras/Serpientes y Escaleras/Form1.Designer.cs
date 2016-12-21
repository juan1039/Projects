namespace Serpientes_y_Escaleras
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
            this.txtJugador1 = new System.Windows.Forms.TextBox();
            this.txtJugador2 = new System.Windows.Forms.TextBox();
            this.btnJugador1 = new System.Windows.Forms.Button();
            this.btnJugador2 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJugador1
            // 
            this.txtJugador1.Location = new System.Drawing.Point(16, 15);
            this.txtJugador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.Size = new System.Drawing.Size(69, 22);
            this.txtJugador1.TabIndex = 0;
            // 
            // txtJugador2
            // 
            this.txtJugador2.Location = new System.Drawing.Point(309, 15);
            this.txtJugador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJugador2.Name = "txtJugador2";
            this.txtJugador2.Size = new System.Drawing.Size(99, 22);
            this.txtJugador2.TabIndex = 1;
            // 
            // btnJugador1
            // 
            this.btnJugador1.Location = new System.Drawing.Point(16, 47);
            this.btnJugador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJugador1.Name = "btnJugador1";
            this.btnJugador1.Size = new System.Drawing.Size(71, 28);
            this.btnJugador1.TabIndex = 2;
            this.btnJugador1.Text = "Dado 1";
            this.btnJugador1.UseVisualStyleBackColor = true;
            this.btnJugador1.Click += new System.EventHandler(this.btnJugador1_Click);
            // 
            // btnJugador2
            // 
            this.btnJugador2.Location = new System.Drawing.Point(341, 47);
            this.btnJugador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJugador2.Name = "btnJugador2";
            this.btnJugador2.Size = new System.Drawing.Size(68, 28);
            this.btnJugador2.TabIndex = 3;
            this.btnJugador2.Text = "Dado 2";
            this.btnJugador2.UseVisualStyleBackColor = true;
            this.btnJugador2.Click += new System.EventHandler(this.btnJugador2_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(16, 79);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 4;
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(175, 29);
            this.btnReinicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(100, 28);
            this.btnReinicio.TabIndex = 5;
            this.btnReinicio.Text = "Salir";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(221, 79);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(0, 17);
            this.lblInfo2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 127);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnJugador2);
            this.Controls.Add(this.btnJugador1);
            this.Controls.Add(this.txtJugador2);
            this.Controls.Add(this.txtJugador1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sepientes y Escaleras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJugador1;
        private System.Windows.Forms.TextBox txtJugador2;
        private System.Windows.Forms.Button btnJugador1;
        private System.Windows.Forms.Button btnJugador2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Label lblInfo2;
    }
}

