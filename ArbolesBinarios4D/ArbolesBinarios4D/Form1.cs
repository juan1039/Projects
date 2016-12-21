using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesBinarios4D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();
            arbol.agregar(new Nodo(20));
            arbol.agregar(new Nodo(15));
            arbol.agregar(new Nodo(14));
            arbol.agregar(new Nodo(10));
            arbol.agregar(new Nodo(18));
            arbol.agregar(new Nodo(16));
            arbol.agregar(new Nodo(19));
            arbol.agregar(new Nodo(25));
            arbol.agregar(new Nodo(23));
            arbol.agregar(new Nodo(22));
            arbol.agregar(new Nodo(24));
            arbol.agregar(new Nodo(27));
            arbol.agregar(new Nodo(26));
            arbol.agregar(new Nodo(30));
            arbol.agregar(new Nodo(50));

            string s = arbol.inOrder();
            MessageBox.Show(s);
        }
    }
}
