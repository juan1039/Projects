using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajadores
{
    class Programa
    {
        private int[] vector = new int[26];
        
        Random aleatorio = new Random();

        public Programa() { }

        public void acomodo()
        {
            for (int i = 0; i < 100; i++)
            {
                int num = aleatorio.Next(25, 51);

                vector[num - 25] = (vector[num - 25] + 1);
            }  
        }

        public string verificacion()
        {
            string datos = "";
            
            acomodo();


            for (int i = 0; i < 26;i++)
            {
                int trabajador = i + 25;

                if (vector[i] == 0)
                {

                }

                else if (vector[i] % 2 !=  0)
                {
                    datos += "El tabajador " + trabajador + " esta adentro" + Environment.NewLine;
                }
            }

                return datos;
        }

        public string test() 
        {
            string datos = "";

            for (int i = 0; i < 26; i++)
            {
                int trab = i + 25;

                datos += trab +" "+ vector[i].ToString() + Environment.NewLine;
            }

            return datos;
        }
    }
}
