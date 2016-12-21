using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionExamen
{
    class Persona
    {
        private string _nombre;
        public Persona() 
        {

        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
