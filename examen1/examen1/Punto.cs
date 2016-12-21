using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    class Punto
    {
        private int _x, _y;

        public Punto(int x,int y)
        {
            _x = x;
            _y = y;
        }
        public int x
        {
            set
            {
                if (value >= 0)
                    _x = value;
            }
            get { return _x; }   
        }
        public int y
        {
            set
            {
                if (value >= 0)
                    _y = value;
            }
            get { return _y; }
        }
        public override string ToString()
        {
            return "x"+x+"y"+y;
        }        public double distancia(Punto p)
        {
            int d;
            Math.Sqrt((_x-x)^2+(y-_y)^2);
            return 0;
        }
    }
}
