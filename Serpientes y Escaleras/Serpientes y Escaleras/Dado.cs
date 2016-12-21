using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_Escaleras
{
    class Dado
    {
        public int dados()
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            int dado = aleatorio.Next(6) + 1;
            return dado;
        }
    }
}
