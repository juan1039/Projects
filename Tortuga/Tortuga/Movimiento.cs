using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga
{
    class Movimiento
    {
        private int x = 0;
        private int y = 0;

        private string direccion = "S";
        private bool pluma = false;
        private string[,] m = new string[20, 20];
        
        public Movimiento()
        {

        }
        public void iniciador()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++) 
                {
                    m[i, j] = "0";
                }
            }
        }
        public string plumaArriba()
        {
            pluma = false;
            return "Arriba";
        }
        public string plumaAbajo()
        {
            pluma = true;
            return "Abajo";
        }
        public string giroDerecha()
        {
            if (direccion == "S")
            {
                direccion = "E";
            }

            else if (direccion == "E")
            {
                direccion = "N";

            }
            else if (direccion == "N")
            {
                direccion = "O";

            }

            else
            {
                direccion = "S";
            }

            return direccion;
        }

        public string giroIzquierda()
        {
            if (direccion == "S")
            {
                direccion = "O";
            }

            else if (direccion == "O")
            {
                direccion = "N";

            }
            else if (direccion == "N")
            {
                direccion = "E";

            }

            else
            {
                direccion = "S";
            }

            return direccion;
        }
        public string pasos(int pasos)
        {

            if (direccion == "S")
            {
                int comprobadorY = pasos + y;
                if (comprobadorY >= 0 && comprobadorY <= 19)
                {

                    if (pluma == true)
                    {
                        for (int i = y; i < (y + pasos) + 1; i++)
                        {
                            m[i, x] = "1";
                        }
                    }
                    y = y + pasos;

                    return "(" + Convert.ToString(x) + "," + Convert.ToString(y) + ")";
                }

                else
                {
                    return "Error, Supera limites";
                }

            }

            else if (direccion == "O")
            {
                int comprobadorX = x - pasos;
                if (comprobadorX >= 0 && comprobadorX <= 19)
                {
                    if (pluma == true)
                    {
                        for (int i = x; i > (x - pasos) - 1; i--)
                        {
                            m[y, i] = "1";
                        }
                    }
                    x = x - pasos;
                    return "(" + Convert.ToString(x) + "," + Convert.ToString(y) + ")";

                }
                else
                {
                    return "Error, Supera limites";
                }
            }
            else if (direccion == "N")
            {
                int comprobadorY = y - pasos;
                if (comprobadorY >= 0 && comprobadorY <= 19)
                {
                    if (pluma == true)
                    {
                        for (int i = y; i > (y - pasos) - 1; i--)
                        {
                            m[i, x] = "1";
                        }
                    }
                    y = y - pasos;
                    return "(" + Convert.ToString(x) + "," + Convert.ToString(y) + ")";

                }
                else
                {
                    return "Error, Supera limites";
                }
            }

            else
            {
                int comprobadorX = pasos + x;
                if (comprobadorX >= 0 && comprobadorX <= 19)
                {
                    if (pluma == true)
                    {
                        for (int i = x; i < (x + pasos) + 1; i++)
                        {
                            m[y, i] = "1";
                        }
                    }

                    x = x + pasos;
                    return "(" + Convert.ToString(x) + "," + Convert.ToString(y) + ")";

                }
                else
                {
                    return "Error, Supera limites";
                }

            }


        }

        public string imprimir()
        {
            string tabla = "";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    tabla += m[i, j] + " ";
                }
                tabla += Environment.NewLine;
            }

            return tabla;
        }
    }
}
