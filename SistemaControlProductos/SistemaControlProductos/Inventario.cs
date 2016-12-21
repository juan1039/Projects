using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlProductos
{
    class Inventario
    {
        private Producto[] _inventario;
        private int _contador = 0;
        private int _posicion = 0;

        public Inventario()
        {
            _inventario = new Producto[15];
        }

        public void agregar(Producto agregar)
        {
           if(_contador<15)
           {
               if (verificar(agregar.clave))
               {
                   _inventario[_contador] = agregar;
                   _contador++;
               }
               else
                   MessageBox.Show("Id ya existente");
           }
        }
        public void eliminar()
        {
            _inventario[_posicion] = null;
            _contador--;

            for (int i = _posicion; i < _contador; i++)
            {
                _inventario[i] = _inventario[i + 1];
            }

        }
        public Producto buscar(int clave)
        {
            for (int i = 0; i < _contador; i++)
            {
                if (_inventario[i].clave == clave)
                {
                    _posicion = i;
                    return _inventario[i];
                }
            }

            return null;
        }

        public String reporte()
        {
            String r = "";

            if (_contador > 0)
            {
                for (int i = 0; i < _contador; i++)
                {
                    r += _inventario[i].ToString() + Environment.NewLine + Environment.NewLine;
                }
                return r;
            }

            return "No se encontraron productos";
        }
        private Boolean verificar(int clave)
        {
            for (int i = 0; i < _contador; i++)
            {
                if (_inventario[i].clave == clave)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
