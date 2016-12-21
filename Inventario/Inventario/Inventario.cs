using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        private Producto _primero; 
        
        public Inventario()
        {
         
        }

        public void agregarProducto(Producto articulo)
        {
            if (_primero == null) 
                _primero = articulo;
            else
                agregarProducto(articulo, _primero);  
        }

        public void agregarProducto(Producto articulo, Producto posUlit)
        {
            if (posUlit.Siguiente == null)
                posUlit.Siguiente = articulo;
            else
                agregarProducto(articulo, posUlit.Siguiente);
        }

        public void eliminarProducto(int clave)
        {
            Producto temp = Buscar(clave); 

            if (temp == null) 
                return;

            else if (_primero == temp)
            {
                if (_primero.Siguiente == null) 
                    _primero = null; 
                else 
                {
                    _primero=_primero.Siguiente; 
                }
            }
            else
                eliminarProducto(temp, _primero); 
        }

        public void eliminarProducto(Producto temp, Producto posEliminado)
        {
            if (posEliminado.Siguiente == temp) 
            {
                if (posEliminado.Siguiente.Siguiente == null) 
                {
                    posEliminado.Siguiente = null; 
                }
                else
                    posEliminado.Siguiente = posEliminado.Siguiente.Siguiente;
            }
            else
            {
                eliminarProducto(temp, posEliminado.Siguiente); 
            }
        }

        public Producto Buscar(int clave)
        {
            if (_primero == null) 
                return null;
            else if (_primero.ID == clave) 
            {
                return _primero; 
            }
            else
                return Buscar(clave, _primero); 
        }

        public Producto Buscar(int clave , Producto posUlti)
        {
            if (posUlti.Siguiente == null) 
                return null;

            else if (posUlti.Siguiente.ID == clave)
            {
                return posUlti.Siguiente;
            }
            else
                return Buscar(clave, posUlti.Siguiente);
        }

        public string generarReporte()
        {
            string cadena = "";
            Producto temp = _primero;

            while (temp != null)
            {
                cadena += temp.ToString() + Environment.NewLine;
                temp = temp.Siguiente;
            }
            return cadena;
        }

        public void Modificar(Producto nuevo, int clave)
        {
            if (_primero == null)
                return;
            else if (_primero.ID == clave)
            {
                nuevo.Siguiente = _primero.Siguiente;
                _primero = nuevo;
            }
            else
                Modificar(clave, _primero, nuevo);
        }

        public void Modificar(int clave, Producto viejo, Producto nuevo)
        {
            if (viejo.Siguiente == null)
                return;
            else if (viejo.Siguiente.ID == clave)
            {
                nuevo.Siguiente = viejo.Siguiente.Siguiente;
                viejo.Siguiente = nuevo;
            }
            else
                Modificar(clave, viejo.Siguiente, nuevo);
        }

    }

    
}
