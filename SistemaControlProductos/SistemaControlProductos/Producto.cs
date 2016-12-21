using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlProductos
{
    class Producto
    {
        private int _clave;
        private string _nombre;
        private int _cantidad;
        private double _costo;

        public Producto(int clave, string nombre)
        {
            _clave = clave;
            _nombre = nombre;
        }
        public int clave
        {
            get{return _clave;}
        }
        public string nombre
        {
            get{return _nombre;}
        }
        public int cantidad
        {
            get{return _cantidad;}
            set 
            { if (value >= 0) 
                  _cantidad = value; 
            }
        }
        public double costo
        {
            get { return _costo; }
            set
            {
                if (value >= 0)
                    _costo = value;
            }
        }
        public override string ToString()
        {
            return "Clave: "+_clave+Environment.NewLine+"Nombre: "+_nombre+Environment.NewLine+"Cantidad: "+_cantidad+Environment.NewLine+"Costo: "+_costo+Environment.NewLine;
        }
    }
}
