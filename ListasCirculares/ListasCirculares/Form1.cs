using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCirculares
{
    public partial class Form1 : Form
    {
        Ruta r = new Ruta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Base b = new Base(txtNombre.Text, Convert.ToInt32(txtTiempo.Text));
            r.agregar(b);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtListaReporte.Text = r.Buscar(txtNombre.Text).Cadena();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtListaReporte.Text = r.Reporte();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtListaReporte.Text = r.GenerarRuta(r.Buscar(txtNombreBase.Text), TimeSpan.Parse(txtHoraInicio.Text), TimeSpan.Parse(txtHoraFin.Text));
        }
    }
}
