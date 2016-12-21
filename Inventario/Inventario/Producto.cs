using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        private int _ID;
        private Producto _siguiente;

        public Producto Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public int ID
        {
            get { return _ID; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
        }
        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private int _precio;

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Producto(int id, string nombre)
        {
            _ID = id;
            _nombre = nombre;
        }

        public override string ToString()
        {
            return "Mi ID es el numero " + _ID + ", mi nombre es " + _nombre + ", mi precio es" + _precio + "y la cantidad es de " + _cantidad;
        }
    }
}
