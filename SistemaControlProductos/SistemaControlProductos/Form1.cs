using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlProductos
{
    public partial class Form1 : Form
    {
        Inventario productos = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }     
       

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                Producto nuevo = new Producto(int.Parse(txtClave.Text), txtNombre.Text);
                nuevo.cantidad = int.Parse(txtCantidad.Text);
                nuevo.costo = int.Parse(txtCosto.Text);
                productos.agregar(nuevo);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Producto nuevo;
            nuevo = productos.buscar(int.Parse(txtClave.Text));

            if (nuevo != null)
                txtReporte.Text = nuevo.ToString();
            else
                MessageBox.Show("Registro no encontrado");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            productos.eliminar();
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            txtReporte.Text = productos.reporte();
        }
        private Boolean validar()
        {
            if (txtCantidad.Text == "")
                txtCantidad.Text = "0";
            if (txtCosto.Text == "")
                txtCosto.Text = "0";
            if (txtClave.Text == "")

                MessageBox.Show("Clave obligatoria");
            else if (txtNombre.Text == "")
                MessageBox.Show("Nombre obligatorio");
            else
                return true;

            return false;
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
