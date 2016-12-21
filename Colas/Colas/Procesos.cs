using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Procesos
    {
        private string _nombre;
        private int _tiempo;
        private Procesos _siguiente;

        public Procesos(string nombre, int tiempo)
        {
            _nombre = nombre;
            _tiempo = tiempo;
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public int Tiempo
        {
            get { return _tiempo; }
            set { _tiempo = value; }
        }
        public Procesos Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public override string ToString()
        {
            return _nombre;
        }
        public string cadena()
        {
            return _nombre + "(" + _tiempo.ToString() + ")";
        }
    }
}
