using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Matriz m = new Matriz();
        private void btnLlenar_Click(object sender, EventArgs e)
        {
            m.llenar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtTabla.Text=m.Mostrar();
        }

        private void btnDiagonalPrincipal_Click(object sender, EventArgs e)
        {
            txtTabla.Text = m.verDiagonalPrincipal();
        }

        private void btnADP_Click(object sender, EventArgs e)
        {
            txtTabla.Text = m.verArribaDP();
        }

        private void btnADS_Click(object sender, EventArgs e)
        {
            txtTabla.Text = m.verAbajoDS();
        }

        private void btnDiagonalSecundaria_Click(object sender, EventArgs e)
        {
            txtTabla.Text = m.verDiagonalSecundaria();
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            m.girar();
        }
    }
}
