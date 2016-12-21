using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionExamen
{
    public partial class Form1 : Form
    {
        Queue personasC = new Queue();
        Stack VehiculosP = new Stack();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre.Text))
            {
                Persona p = new Persona();
                p.nombre = txtNombre.Text;
                personasC.Enqueue(p);
            }

            if (!String.IsNullOrEmpty(txtNoPlaca.Text) && !String.IsNullOrEmpty(txtNoPersonas.Text))
            {
                PlacaVehiculo v = new PlacaVehiculo();
                v.placa = txtNoPlaca.Text;
                v.personas = int.Parse(txtNoPersonas.Text);
                VehiculosP.Push(v);
            }

            MessageBox.Show("Agregado XD","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            PlacaVehiculo placaVehiculo = (PlacaVehiculo)VehiculosP.Peek();
            txtTabla.Text += "Vehiculo: " + placaVehiculo.placa + Environment.NewLine+"Su capacidad es de: " + placaVehiculo.personas.ToString();

            while (personasC.Count > 0 && VehiculosP.Count > 0)
            {
                Persona noPersonas = (Persona)personasC.Peek();

                placaVehiculo.personas--;

                txtTabla.Text += Environment.NewLine + noPersonas.nombre;
                personasC.Dequeue();

                if (placaVehiculo.personas == 0)
                {
                    VehiculosP.Pop();
                    if (VehiculosP.Count != 0)
                    {
                        placaVehiculo = (PlacaVehiculo)VehiculosP.Peek();
                        txtTabla.Text += Environment.NewLine + "Vehiculo: " + placaVehiculo.placa + Environment.NewLine + "Su capacidad es de: " + placaVehiculo.personas.ToString();
                    }
                }

            }
        }
    }
}
