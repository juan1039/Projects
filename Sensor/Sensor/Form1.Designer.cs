namespace Sensor
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
            this.lblCompuertaAlimento = new System.Windows.Forms.Label();
            this.lblLamparaUno = new System.Windows.Forms.Label();
            this.lblLamparaDos = new System.Windows.Forms.Label();
            this.btnEnvio = new System.Windows.Forms.Button();
            this.txtDatosEnvio = new System.Windows.Forms.TextBox();
            this.lblTanque = new System.Windows.Forms.Label();
            this.lblViento = new System.Windows.Forms.Label();
            this.ckbLamparaUno = new System.Windows.Forms.CheckBox();
            this.ckbLamparaDos = new System.Windows.Forms.CheckBox();
            this.ckbCompuerta = new System.Windows.Forms.CheckBox();
            this.ckbTanque = new System.Windows.Forms.CheckBox();
            this.txtDatosCuestion = new System.Windows.Forms.TextBox();
            this.btnDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompuertaAlimento
            // 
            this.lblCompuertaAlimento.AutoSize = true;
            this.lblCompuertaAlimento.Location = new System.Drawing.Point(13, 65);
            this.lblCompuertaAlimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompuertaAlimento.Name = "lblCompuertaAlimento";
            this.lblCompuertaAlimento.Size = new System.Drawing.Size(77, 17);
            this.lblCompuertaAlimento.TabIndex = 0;
            this.lblCompuertaAlimento.Text = "Compuerta";
            // 
            // lblLamparaUno
            // 
            this.lblLamparaUno.AutoSize = true;
            this.lblLamparaUno.Location = new System.Drawing.Point(98, 65);
            this.lblLamparaUno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLamparaUno.Name = "lblLamparaUno";
            this.lblLamparaUno.Size = new System.Drawing.Size(76, 17);
            this.lblLamparaUno.TabIndex = 1;
            this.lblLamparaUno.Text = "Lampara 1";
            // 
            // lblLamparaDos
            // 
            this.lblLamparaDos.AutoSize = true;
            this.lblLamparaDos.Location = new System.Drawing.Point(180, 65);
            this.lblLamparaDos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLamparaDos.Name = "lblLamparaDos";
            this.lblLamparaDos.Size = new System.Drawing.Size(76, 17);
            this.lblLamparaDos.TabIndex = 2;
            this.lblLamparaDos.Text = "Lampara 2";
            // 
            // btnEnvio
            // 
            this.btnEnvio.Location = new System.Drawing.Point(263, 15);
            this.btnEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(100, 28);
            this.btnEnvio.TabIndex = 3;
            this.btnEnvio.Text = "Comprobar";
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // txtDatosEnvio
            // 
            this.txtDatosEnvio.Location = new System.Drawing.Point(16, 21);
            this.txtDatosEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatosEnvio.Name = "txtDatosEnvio";
            this.txtDatosEnvio.Size = new System.Drawing.Size(132, 22);
            this.txtDatosEnvio.TabIndex = 4;
            // 
            // lblTanque
            // 
            this.lblTanque.AutoSize = true;
            this.lblTanque.Location = new System.Drawing.Point(17, 96);
            this.lblTanque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanque.Name = "lblTanque";
            this.lblTanque.Size = new System.Drawing.Size(57, 17);
            this.lblTanque.TabIndex = 5;
            this.lblTanque.Text = "Tanque";
            // 
            // lblViento
            // 
            this.lblViento.AutoSize = true;
            this.lblViento.Location = new System.Drawing.Point(98, 96);
            this.lblViento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViento.Name = "lblViento";
            this.lblViento.Size = new System.Drawing.Size(72, 17);
            this.lblViento.TabIndex = 6;
            this.lblViento.Text = "direc. Aire";
            // 
            // ckbLamparaUno
            // 
            this.ckbLamparaUno.AutoSize = true;
            this.ckbLamparaUno.Location = new System.Drawing.Point(20, 224);
            this.ckbLamparaUno.Margin = new System.Windows.Forms.Padding(4);
            this.ckbLamparaUno.Name = "ckbLamparaUno";
            this.ckbLamparaUno.Size = new System.Drawing.Size(72, 21);
            this.ckbLamparaUno.TabIndex = 7;
            this.ckbLamparaUno.Text = "On/Off";
            this.ckbLamparaUno.UseVisualStyleBackColor = true;
            // 
            // ckbLamparaDos
            // 
            this.ckbLamparaDos.AutoSize = true;
            this.ckbLamparaDos.Location = new System.Drawing.Point(20, 252);
            this.ckbLamparaDos.Margin = new System.Windows.Forms.Padding(4);
            this.ckbLamparaDos.Name = "ckbLamparaDos";
            this.ckbLamparaDos.Size = new System.Drawing.Size(72, 21);
            this.ckbLamparaDos.TabIndex = 8;
            this.ckbLamparaDos.Text = "On/Off";
            this.ckbLamparaDos.UseVisualStyleBackColor = true;
            // 
            // ckbCompuerta
            // 
            this.ckbCompuerta.AutoSize = true;
            this.ckbCompuerta.Location = new System.Drawing.Point(135, 224);
            this.ckbCompuerta.Margin = new System.Windows.Forms.Padding(4);
            this.ckbCompuerta.Name = "ckbCompuerta";
            this.ckbCompuerta.Size = new System.Drawing.Size(130, 21);
            this.ckbCompuerta.TabIndex = 9;
            this.ckbCompuerta.Text = "Cerrada/Abierta";
            this.ckbCompuerta.UseVisualStyleBackColor = true;
            // 
            // ckbTanque
            // 
            this.ckbTanque.AutoSize = true;
            this.ckbTanque.Location = new System.Drawing.Point(135, 252);
            this.ckbTanque.Margin = new System.Windows.Forms.Padding(4);
            this.ckbTanque.Name = "ckbTanque";
            this.ckbTanque.Size = new System.Drawing.Size(169, 21);
            this.ckbTanque.TabIndex = 10;
            this.ckbTanque.Text = "En llenado/No llenado";
            this.ckbTanque.UseVisualStyleBackColor = true;
            // 
            // txtDatosCuestion
            // 
            this.txtDatosCuestion.Location = new System.Drawing.Point(20, 282);
            this.txtDatosCuestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatosCuestion.Name = "txtDatosCuestion";
            this.txtDatosCuestion.Size = new System.Drawing.Size(132, 22);
            this.txtDatosCuestion.TabIndex = 11;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(161, 282);
            this.btnDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(100, 42);
            this.btnDatos.TabIndex = 12;
            this.btnDatos.Text = "Ver Instrucción";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 334);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.txtDatosCuestion);
            this.Controls.Add(this.ckbTanque);
            this.Controls.Add(this.ckbCompuerta);
            this.Controls.Add(this.ckbLamparaDos);
            this.Controls.Add(this.ckbLamparaUno);
            this.Controls.Add(this.lblViento);
            this.Controls.Add(this.lblTanque);
            this.Controls.Add(this.txtDatosEnvio);
            this.Controls.Add(this.btnEnvio);
            this.Controls.Add(this.lblLamparaDos);
            this.Controls.Add(this.lblLamparaUno);
            this.Controls.Add(this.lblCompuertaAlimento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompuertaAlimento;
        private System.Windows.Forms.Label lblLamparaUno;
        private System.Windows.Forms.Label lblLamparaDos;
        private System.Windows.Forms.Button btnEnvio;
        private System.Windows.Forms.TextBox txtDatosEnvio;
        private System.Windows.Forms.Label lblTanque;
        private System.Windows.Forms.Label lblViento;
        private System.Windows.Forms.CheckBox ckbLamparaUno;
        private System.Windows.Forms.CheckBox ckbLamparaDos;
        private System.Windows.Forms.CheckBox ckbCompuerta;
        private System.Windows.Forms.CheckBox ckbTanque;
        private System.Windows.Forms.TextBox txtDatosCuestion;
        private System.Windows.Forms.Button btnDatos;

    }
}

