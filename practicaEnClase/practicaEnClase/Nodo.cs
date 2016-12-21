using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaEnClase
{
    class Nodo
    {
        private int _Id;
        private Nodo _siguiente;
        private string _nombre;
        private int _cantidad;
        private int _precio;
        public Nodo(int dato)
        {
            _Id = dato;
        }
        public Nodo Siguiente
        {
            set { _siguiente = value; }
            get { return Siguiente;}
        }
        public int Id
        {
            get { return Id; }
        }
        public string Nombre
        {
            get{return _nombre;}
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public int precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public Nodo(int id, string nombre)
        {
            _Id = id;
            _nombre = nombre;
        }
        string tostring()
        {
            return "Mi ID es el numero " + _Id + ", mi nombre es " + _nombre + " ,mi precio es " + _precio + " y la cantidad es de " + _cantidad;
        }
    }
}
