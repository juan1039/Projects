using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Vector
    {
        private short[] lista = new short[15];
        
        public Vector() { }

        public void pares()
        {
            short a=8;
            for (int i = 0; i<15; i++)
            {
                a+=2;
                lista[i] = a;
            }
        }

        public void impares()
        {
            short a = -1;
            for (int i = 0; i < 15; i++)
            {
                a+=2;
                lista[i] = a;
            }
        }

        public String mostrar()
        {
           String datos="";

           for (int i = 0; i < 15; i++)
           {
               datos += lista[i] + Environment.NewLine;
           }
            return datos;
        }

        public void rotarAbajo()
        {
            short ultimo = lista[14];
            for (int i = 14; i >0; i--)
            {
                lista[i] = lista[i - 1];
            }
            lista[0] = ultimo;
        }

        public void rotarArriba()
        {
            short primero = lista[0];
            for (int i = 0; i < 14; i++)
            {
                lista[i] = lista[i + 1];
            }
            lista[14] = primero;
        }

        public void invertir()
        {
            short a,b;
            for (int i=0,j=14; i < 7; i++,j--)
            {
                a = lista[i];
                b = lista[j];

                lista[i] = b;
                lista[j] = a;
            }
           
        }
    }
}
