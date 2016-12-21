using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaEnClase
{
    class Inventario
    {
        private Nodo _primero;

        public Inventario()
        {

        }
        public void agregarProducto(Nodo articulo)
        {
            if (_primero == null)
                _primero = articulo;
            else
                agregarProducto(articulo, _primero);
        }
        public void agregarProducto(Nodo articulo, Nodo PosibleUltimo)
        {
            if (PosibleUltimo.Siguiente == null)
                PosibleUltimo.Siguiente = articulo;
            else
                agregarProducto(articulo, PosibleUltimo.Siguiente);
        }
        public Nodo Buscar(int clave)
        {
            if (_primero == null)
                return null;
            else if (_primero.Id == clave)
            {
                return _primero;
            }
            else
                return Buscar(clave, _primero);
        }
        public Nodo Buscar(int clave, Nodo PosibleUltima)
        {
            if (PosibleUltima.Siguiente == null)
                return null;
            else if (PosibleUltima.Siguiente.Id == clave)
            {
                return PosibleUltima.Siguiente;
            }
            else
                return Buscar(clave, PosibleUltima.Siguiente);
        }
        public void EliminarProducto(int clave)
        {
            Nodo temp = Buscar(clave);

            if (temp == null)
                return;
            else if (_primero == temp)
            {
                if (_primero.Siguiente == null)
                    _primero = null;
                else
                {
                    _primero = _primero.Siguiente;
                }
            }
            else
                EliminarProducto(temp, _primero); 
        }
        public void EliminarProducto(Nodo temp, Nodo PosibleEliminado)
        {
            if(PosibleEliminado.Siguiente==temp)
            {
                if (PosibleEliminado.Siguiente.Siguiente == null)
                {
                    PosibleEliminado.Siguiente = null;
                }
                else
                    PosibleEliminado.Siguiente = PosibleEliminado.Siguiente.Siguiente;
            }
            else
            {
                EliminarProducto(temp, PosibleEliminado.Siguiente);
            }
        }
        public string generarReporte()
        {
            string cadena = "";
            Nodo temp = _primero;

            while (temp != null)
            {
                cadena += temp.ToString() + Environment.NewLine;
                temp = temp.Siguiente;
            }
            return cadena;
        }

        public void Modificar(Nodo nuevo, int clave)
        {
            if (_primero == null)
                return;
            else if (_primero.Id == clave)
            {
                nuevo.Siguiente = _primero.Siguiente;
                _primero = nuevo;
            }
            else
                Modificar(clave, _primero, nuevo);
        }

        public void Modificar(int clave, Nodo viejo, Nodo nuevo)
        {
            if (viejo.Siguiente == null)
                return;
            else if (viejo.Siguiente.Id == clave)
            {
                nuevo.Siguiente = viejo.Siguiente.Siguiente;
                viejo.Siguiente = nuevo;
            }
            else
                Modificar(clave, viejo.Siguiente, nuevo);
        }
    }
}
