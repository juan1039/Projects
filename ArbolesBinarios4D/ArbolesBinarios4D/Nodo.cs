using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBinarios4D
{
    class Nodo
    {
        public int dato { get ;set;}
        public Nodo hIzquierdo { get; set; }
        public Nodo hDerecho { get; set; }
        public Nodo(int dato)
        {
            this.dato = dato;
        }
        public override string ToString()
        {
            return dato.ToString();
        }
        
    }
}
