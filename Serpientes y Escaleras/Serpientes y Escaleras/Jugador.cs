using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_Escaleras
{
    class Jugador
    {
        private int psuno = 0;
        private int psdos = 0;
        private int pstres = 0;
        
        Tablero t = new Tablero();
        Dado d = new Dado();

        private bool turno = false;
       
        public string jugador(int n)
        {
            string resultado = "";

            if (n == 1 && turno == false)
            {
                pstres = psuno + d.dados();
                pstres = t.tablero(pstres);
                if (pstres >= 100)
                {
                    pstres = 666;
                }
               psuno = pstres  ;
                turno = true;

                resultado = Convert.ToString(pstres);

            }

            else if (n == 2 && turno == true)
            {
                pstres = psdos + d.dados();
                pstres = t.tablero(pstres);
                if (pstres >= 100)
                {
                    pstres = 666;
                }
                psdos = pstres  ;
                turno = false;

                resultado = Convert.ToString(pstres);
            }

            else
            {
                resultado = "Jugardor " + n + " no es su turno.";
            }

            return resultado;

        }
    }
}
