using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valoresAleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numMayor, numMenor;
        private void button1_Click(object sender, EventArgs e)
        {
            ListaAleatoria.Items.Clear();
            int[] vector = new int[10];
            int n = Convert.ToInt32(txtNumeros.Text);
            Random Aleatorio = new Random();

            for(int i=0; i<n; i++)
            {
                vector[i] = Aleatorio.Next(n);
                ListaAleatoria.Items.Add(vector[i]);
            } 
        }
    }
}
