using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array2
{
    public partial class Form1 : Form
    {
        Vector lista = new Vector();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text=lista.mostrar();
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            lista.impares();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            lista.pares();
        }

        private void btnGAbajo_Click(object sender, EventArgs e)
        {
            lista.rotarAbajo();
        }

        private void btnGArriba_Click(object sender, EventArgs e)
        {
            lista.rotarArriba();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            lista.invertir();
        } 
    }
}
