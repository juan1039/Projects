using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga
{
    public partial class Form1 : Form
    {
        Movimiento tortuga = new Movimiento();
        public Form1()
        {
            InitializeComponent();
            tortuga.iniciador();
            txtDireccion.Text = "S";
            txtPluma.Text = "Arriba";
            txtPosicion.Text = "(0,0)";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtTabla.Text = tortuga.imprimir();
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            txtPluma.Text = tortuga.plumaArriba();  
        }

        private void btnPlumaAbajo_Click(object sender, EventArgs e)
        {
            txtPluma.Text = tortuga.plumaAbajo();
        }

        private void brnGiraDerecha_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = tortuga.giroDerecha();
        }

        private void btnGirarIzquierda_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = tortuga.giroIzquierda();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            string informacion = tortuga.pasos(Convert.ToInt16(txtAvanzar.Text));
            if(informacion=="Error, Supera los Limites")
            {
                label1.Text = informacion;
            }
            else
            {
                label1.Text = "";
                txtPosicion.Text = informacion;
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
