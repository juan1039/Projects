using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_Escaleras
{
    class Tablero
    {
        public int tablero(int pstres)
        {
            //Escaleras del tablero
            if (pstres == 9)
            {
                return pstres = 28;
            }
            else if (pstres == 18)
            {
                return pstres = 79;
            }

            else if (pstres == 20)
            {
                return pstres = 53;
            }
            else if (pstres == 27)
            {
                return pstres = 64;
            }
            else if (pstres == 30)
            {
                return pstres = 50;
            }
            else if (pstres == 36)
            {
                return pstres = 92;
            }
            else if (pstres == 40)
            {
                return pstres = 60;
            }
            else if (pstres == 56)
            {
                return pstres = 68;
            }
            else if (pstres == 65)
            {
                return pstres = 78;
            }
            else if (pstres == 90)
            {
                return pstres = 100;
            }

            //Serpientes del tablero

            else if (pstres == 16)
            {
                return pstres = 5;
            }
            else if (pstres == 25)
            {
                return pstres = 14;
            }
            else if (pstres == 45)
            {
                return pstres = 40;
            }
            else if (pstres == 70)
            {
                return pstres = 12;
            }
            else if (pstres == 71)
            {
                return pstres = 65;
            }
            else if (pstres == 80)
            {
                return pstres = 34;
            }
            else if (pstres == 86)
            {
                return pstres = 24;
            }
            else if (pstres == 99)
            {
                return pstres = 1;
            }

            else
                return pstres;



        }
    }
}
