using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Base
    {
        private string _nombre;
        private TimeSpan _tiempo;
        private Base _siguiente;
        private Base _anterior;
        
        public Base(string nombre, int tiempo)
        {
            TimeSpan t = TimeSpan.FromMinutes(tiempo);
            _nombre = nombre;
            _tiempo = t;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public TimeSpan Tiempo
        {
            get { return _tiempo; }
        }

        public Base Siguiente
        {
            get { return _siguiente; }
            set { _anterior = value; }
        }

        public Base Anterior
        {
            get { return _anterior; }
            set { _siguiente = value; }
        }

        public override string ToString()
        {
            return _nombre;
        }

        public string Cadena()
        {
            return _nombre + "(" + Tiempo.ToString() + ")";
        }
    }
}
