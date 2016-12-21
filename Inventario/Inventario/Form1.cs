using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        private Inventario inven;
        public Form1()
        {
            InitializeComponent();
            inven = new Inventario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int clave = Convert.ToInt16(txtClave.Text);
            string nombre = txtNombre.Text;
            int cantidad = Convert.ToInt16(txtCantidad.Text);
            int precio = Convert.ToInt16(txtPrecio.Text);

            Producto nuevo = new Producto(clave, nombre);
            nuevo.Precio = precio;
            nuevo.Cantidad = cantidad;

            inven.agregarProducto(nuevo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto art = inven.Buscar(Convert.ToInt16(txtClave.Text));
            if (art != null)
            {
                txtClave.Text = art.ID.ToString();
                txtNombre.Text = art.Nombre;
                txtPrecio.Text = art.Precio.ToString();
                txtCantidad.Text = art.Cantidad.ToString();
            }
            else
                MessageBox.Show("No hay artuclos agragados X'(");
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inven.eliminarProducto(Convert.ToInt16(txtClave.Text));
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inven.generarReporte();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int clave = Convert.ToInt16(txtClave.Text);
            string nombre = txtNombre.Text;
            int cantidad = Convert.ToInt16(txtCantidad.Text);
            int precio = Convert.ToInt16(txtPrecio.Text);

            Producto nuevo = new Producto(clave, nombre);
            nuevo.Precio = precio;
            nuevo.Cantidad = cantidad;

            inven.Modificar(nuevo,clave);
        }
    }
}
