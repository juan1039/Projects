using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionExamen
{
    class PlacaVehiculo
    {
        private string _placa;
        private int _personas;

        public PlacaVehiculo()
        {
            
        }

        public string placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public int personas
        {
            get { return _personas; }
            set { _personas = value; }
        }
    }
}
