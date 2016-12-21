using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaEnClase
{
    public partial class Form1 : Form
    {
        private Inventario inventario;
        
        public Form1()
        {
            InitializeComponent();
            inventario = new Inventario();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int clave = Convert.ToInt16(txtClave.Text);
            string nombre = txtNombre.Text;
            int cantidad = Convert.ToInt16(txtCantidad.Text);
            int precio = Convert.ToInt16(txtPrecio.Text);

            Nodo nuevo = new Nodo(clave, nombre);
            nuevo.precio = precio;
            nuevo.Cantidad = cantidad;

            inventario.agregarProducto(nuevo);   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Nodo art = inventario.Buscar(Convert.ToInt16(txtClave.Text));
            if (art != null)
            {
                txtClave.Text = art.Id.ToString();
                txtNombre.Text = art.Nombre;
                txtPrecio.Text = art.precio.ToString();
                txtCantidad.Text = art.Cantidad.ToString();
            }
            else
                MessageBox.Show("No hay artuclos agragados X'(");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.EliminarProducto(Convert.ToInt16(txtClave.Text));
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.generarReporte();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int clave = Convert.ToInt16(txtClave.Text);
            string nombre = txtNombre.Text;
            int cantidad = Convert.ToInt16(txtCantidad.Text);
            int precio = Convert.ToInt16(txtPrecio.Text);

            Nodo nuevo = new Nodo(clave, nombre);
            nuevo.precio = precio;
            nuevo.Cantidad = cantidad;

            inventario.Modificar(nuevo, clave);
        }
    }
}
