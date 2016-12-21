using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matriz
    {
        int[,] m = new int[5, 5];

        public Matriz()
        {

        }
        public void llenar()
        {
            int contador = 1;
            for(int i=0;i<5;i++)
            {
                for(int j=0; j<5;j++)
                {
                    m[i, j] = contador;
                    contador++;
                }
            }
        }
        public string Mostrar()
        {
            string tabla = "";
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    tabla += m[i, j] + " . ";
                }
                tabla += Environment.NewLine;
            }
            return tabla;
        }
        public string verDiagonalPrincipal()
        {
            int t = 5;
            string tabla = "";
            for (int i = 0; i < 5; i++)
            {
                tabla += m[i, i] + " . ";
            }
            return tabla;
        }
        public string verDiagonalSecundaria()
        {
            string tabla = "";
            int contador = 4;
            for (int i = 0; i < 5; i++) 
            {
                tabla += m[i, contador] + " . ";
                contador--;
            }
            return tabla;
        }
        public string verArribaDP()
        {
            string tabla = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    tabla += m[i, j] + " . ";
                }
                tabla += Environment.NewLine;
            }
            return tabla;
        }
        public string verAbajoDS()
        {
            string tabla = "";
            int contador = 0;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < contador+1; j++)
                {
                    tabla += m[i, j] + " . ";
                }
                contador++;
                tabla += Environment.NewLine;
            }
            return tabla;
        }
        public void girar()
        {
            int s;
            for (int i = 0; i < 5; i++) 
            {
                for (int j = i+1; j < 5; j++) 
                {
                    s = m[i, j];
                    m[i, j] = m[j, i];
                    m[j, i] = s;
                }
            }
        }
    }
}
