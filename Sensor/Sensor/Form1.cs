using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            byte dato = Convert.ToByte(txtDatosEnvio.Text);

            compuerta(dato);
            lamparaUno(dato);
            lamparaDos(dato);
            tanque(dato);
            direccionAire(dato);

           
        }

        private void compuerta (byte dato)
        {
            if (dato >= 128)
            {
                lblCompuertaAlimento.Text = "Cerrado";
            }
            else
            {
                lblCompuertaAlimento.Text = "Abierto";
            }
        }

        private void lamparaDos (byte dato)
        {
            int datoFinal = dato % 2;

            if (datoFinal == 0)
            {
                lblLamparaDos.Text = "Off";
            }
            else
            {
                lblLamparaDos.Text = "On";
            }
        }

        private void lamparaUno (byte dato)
        {
            int datoFinal = dato & 2;

            if (datoFinal == 2)
            {
                lblLamparaUno.Text = "On";
                
            }

            else
            {
                lblLamparaUno.Text = "Off";
            }

        }

        private void tanque (byte dato)
        {
            int datoFinal = dato & 12;

            if (datoFinal == 0)
            {
                lblTanque.Text = "Lleno";

            }
            else if (datoFinal == 4)
            {
                lblTanque.Text = "Vacio";

            }

            else if (datoFinal == 8)
            {
                lblTanque.Text = "En llenado";

            }
            else
            {
                lblTanque.Text = "ERROR";
            }
        }

        private void direccionAire (byte dato)
        {
            int datoFinal = dato & 112;

            if (datoFinal == 0)
            {
                lblViento.Text = "Norte";
            }

            else if (datoFinal == 16)
            {
                lblViento.Text = "Noroeste";
            }

            else if (datoFinal == 32)
            {
                lblViento.Text = "Este";
            }

            else if (datoFinal == 48)
            {
                lblViento.Text = "Sureste";
            }

            else if (datoFinal == 64)
            {
                lblViento.Text = "Sur";
            }

            else if (datoFinal == 80)
            {
                lblViento.Text = "Suroeste";
            }

            else if (datoFinal == 96)
            {
                lblViento.Text = "Oeste";
            }

            else
            {
                lblViento.Text = "Noroeste";
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            byte datoDos = 0;

            if (ckbLamparaDos.Checked)
            {
                int dato = datoDos & 1;

                if (dato == 0)
                {
                    datoDos++;
                }
                
            }
            if (ckbLamparaUno.Checked)
            {
                int dato = datoDos & 2;

                if (dato == 0)
                {
                    for (byte i=0; i < 2; i++)
                    {
                        datoDos++;
                    }
                }
                
            }
            if(ckbTanque.Checked)
            {
                int dato = datoDos & 12;
                if (dato == 0)
                {
                    for (byte i = 0; i < 8; i++)
                    {
                        datoDos++;
                    }
                }

            }

            if(ckbCompuerta.Checked)
            {
                int dato = datoDos & 128;
                if (dato == 0)
                {
                    for (byte i = 0; i < 128; i++)
                    {
                        datoDos++;
                    }
                }
            }

            txtDatosCuestion.Text = Convert.ToString(datoDos);
        }

    }
}
