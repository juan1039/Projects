namespace Tortuga
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
            this.btnPlumaArriba = new System.Windows.Forms.Button();
            this.btnPlumaAbajo = new System.Windows.Forms.Button();
            this.brnGiraDerecha = new System.Windows.Forms.Button();
            this.btnGirarIzquierda = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.txtAvanzar = new System.Windows.Forms.TextBox();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPluma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlumaArriba
            // 
            this.btnPlumaArriba.AutoSize = true;
            this.btnPlumaArriba.Location = new System.Drawing.Point(12, 12);
            this.btnPlumaArriba.Name = "btnPlumaArriba";
            this.btnPlumaArriba.Size = new System.Drawing.Size(136, 27);
            this.btnPlumaArriba.TabIndex = 0;
            this.btnPlumaArriba.Text = "Pluma hacia arriba";
            this.btnPlumaArriba.UseVisualStyleBackColor = true;
            this.btnPlumaArriba.Click += new System.EventHandler(this.btnPlumaArriba_Click);
            // 
            // btnPlumaAbajo
            // 
            this.btnPlumaAbajo.AutoSize = true;
            this.btnPlumaAbajo.Location = new System.Drawing.Point(12, 55);
            this.btnPlumaAbajo.Name = "btnPlumaAbajo";
            this.btnPlumaAbajo.Size = new System.Drawing.Size(134, 27);
            this.btnPlumaAbajo.TabIndex = 1;
            this.btnPlumaAbajo.Text = "Pluma hacia abajo";
            this.btnPlumaAbajo.UseVisualStyleBackColor = true;
            this.btnPlumaAbajo.Click += new System.EventHandler(this.btnPlumaAbajo_Click);
            // 
            // brnGiraDerecha
            // 
            this.brnGiraDerecha.AutoSize = true;
            this.brnGiraDerecha.Location = new System.Drawing.Point(12, 98);
            this.brnGiraDerecha.Name = "brnGiraDerecha";
            this.brnGiraDerecha.Size = new System.Drawing.Size(159, 27);
            this.brnGiraDerecha.TabIndex = 2;
            this.brnGiraDerecha.Text = "Girar hacia la derecha";
            this.brnGiraDerecha.UseVisualStyleBackColor = true;
            this.brnGiraDerecha.Click += new System.EventHandler(this.brnGiraDerecha_Click);
            // 
            // btnGirarIzquierda
            // 
            this.btnGirarIzquierda.AutoSize = true;
            this.btnGirarIzquierda.Location = new System.Drawing.Point(12, 141);
            this.btnGirarIzquierda.Name = "btnGirarIzquierda";
            this.btnGirarIzquierda.Size = new System.Drawing.Size(165, 27);
            this.btnGirarIzquierda.TabIndex = 3;
            this.btnGirarIzquierda.Text = "Girar hacia la izquierda";
            this.btnGirarIzquierda.UseVisualStyleBackColor = true;
            this.btnGirarIzquierda.Click += new System.EventHandler(this.btnGirarIzquierda_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.AutoSize = true;
            this.btnAvanzar.Location = new System.Drawing.Point(12, 184);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 27);
            this.btnAvanzar.TabIndex = 4;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Location = new System.Drawing.Point(12, 269);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 27);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFin
            // 
            this.btnFin.AutoSize = true;
            this.btnFin.Location = new System.Drawing.Point(12, 302);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(96, 27);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "Fin de datos";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtAvanzar
            // 
            this.txtAvanzar.Location = new System.Drawing.Point(93, 189);
            this.txtAvanzar.Name = "txtAvanzar";
            this.txtAvanzar.Size = new System.Drawing.Size(49, 22);
            this.txtAvanzar.TabIndex = 7;
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(238, 22);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(431, 369);
            this.txtTabla.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Posicion de tortuga";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(15, 234);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(176, 22);
            this.txtPosicion.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(177, 113);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(55, 22);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtPluma
            // 
            this.txtPluma.Location = new System.Drawing.Point(154, 31);
            this.txtPluma.Name = "txtPluma";
            this.txtPluma.Size = new System.Drawing.Size(62, 22);
            this.txtPluma.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 403);
            this.Controls.Add(this.txtPluma);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.txtAvanzar);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnGirarIzquierda);
            this.Controls.Add(this.brnGiraDerecha);
            this.Controls.Add(this.btnPlumaAbajo);
            this.Controls.Add(this.btnPlumaArriba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlumaArriba;
        private System.Windows.Forms.Button btnPlumaAbajo;
        private System.Windows.Forms.Button brnGiraDerecha;
        private System.Windows.Forms.Button btnGirarIzquierda;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtAvanzar;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPluma;
    }
}

