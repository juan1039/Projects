using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    class Vector
    {
        int[] vector = new int[10];
        
        public Vector(){}
        public int agregar()
        {
            for(int i=0;i<10;i++)
            {
                vector[i] = vector[i] + 1;
            }
            return 0;
        }
        public int Eliminar()
        {
            for(int i=0;i<10;i++)
            {
                vector[i] = vector[i] - 1;
            }
        }
    }
}
