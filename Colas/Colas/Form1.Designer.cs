namespace Colas
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
            this.btnSimularProceso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCiclosVacios = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProcesosMaximos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProcesosPendientes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProcesosAtendidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSimularProceso
            // 
            this.btnSimularProceso.AutoSize = true;
            this.btnSimularProceso.Location = new System.Drawing.Point(14, 24);
            this.btnSimularProceso.Name = "btnSimularProceso";
            this.btnSimularProceso.Size = new System.Drawing.Size(121, 30);
            this.btnSimularProceso.TabIndex = 0;
            this.btnSimularProceso.Text = "Simular Proceso";
            this.btnSimularProceso.UseVisualStyleBackColor = true;
            this.btnSimularProceso.Click += new System.EventHandler(this.btnSimularProceso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Ciclos Vacios";
            // 
            // lblCiclosVacios
            // 
            this.lblCiclosVacios.AutoSize = true;
            this.lblCiclosVacios.Location = new System.Drawing.Point(50, 132);
            this.lblCiclosVacios.Name = "lblCiclosVacios";
            this.lblCiclosVacios.Size = new System.Drawing.Size(16, 17);
            this.lblCiclosVacios.TabIndex = 3;
            this.lblCiclosVacios.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. Procesos Maximos";
            // 
            // lblProcesosMaximos
            // 
            this.lblProcesosMaximos.AutoSize = true;
            this.lblProcesosMaximos.Location = new System.Drawing.Point(50, 205);
            this.lblProcesosMaximos.Name = "lblProcesosMaximos";
            this.lblProcesosMaximos.Size = new System.Drawing.Size(16, 17);
            this.lblProcesosMaximos.TabIndex = 5;
            this.lblProcesosMaximos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. Procesos Pendientes";
            // 
            // lblProcesosPendientes
            // 
            this.lblProcesosPendientes.AutoSize = true;
            this.lblProcesosPendientes.Location = new System.Drawing.Point(50, 268);
            this.lblProcesosPendientes.Name = "lblProcesosPendientes";
            this.lblProcesosPendientes.Size = new System.Drawing.Size(16, 17);
            this.lblProcesosPendientes.TabIndex = 7;
            this.lblProcesosPendientes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiempo Total";
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Location = new System.Drawing.Point(50, 341);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTiempoTotal.TabIndex = 9;
            this.lblTiempoTotal.Text = "0";
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(192, 24);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(742, 507);
            this.txtReporte.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "No. Procesos Atendidos";
            // 
            // lblProcesosAtendidos
            // 
            this.lblProcesosAtendidos.AutoSize = true;
            this.lblProcesosAtendidos.Location = new System.Drawing.Point(50, 398);
            this.lblProcesosAtendidos.Name = "lblProcesosAtendidos";
            this.lblProcesosAtendidos.Size = new System.Drawing.Size(16, 17);
            this.lblProcesosAtendidos.TabIndex = 12;
            this.lblProcesosAtendidos.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 562);
            this.Controls.Add(this.lblProcesosAtendidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.lblTiempoTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProcesosPendientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProcesosMaximos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCiclosVacios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimularProceso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimularProceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCiclosVacios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProcesosMaximos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProcesosPendientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProcesosAtendidos;
    }
}

