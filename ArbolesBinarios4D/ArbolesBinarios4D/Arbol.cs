using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBinarios4D
{
    class Arbol
    {
        private Nodo raiz = null;
        public void agregar(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                agregar(nuevo, raiz);
        }
        private void agregar(Nodo n, Nodo r)
        {
            if (n.dato < r.dato)
                if (r.hIzquierdo == null)
                    r.hIzquierdo = n;
                else
                    agregar(n, r.hIzquierdo);
            else
                if (r.hDerecho == null)
                    r.hDerecho = n;
                else
                    agregar(n, r.hDerecho);
        }

        public string inOrder()
        {
            string res = "";
            if (raiz != null)
                res = inOrder(raiz);
            return res;
        }

        private string inOrder(Nodo r)
        {
            string res = "";
            if (r.hIzquierdo != null)
                res = inOrder(r.hIzquierdo);
            res += r.ToString();
            if (r.hDerecho != null)
                res += inOrder(r.hDerecho);
            return res;
        }

        public string preOrder()
        {
            return "";
        }
    }
}
