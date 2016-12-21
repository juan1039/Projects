using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Ruta
    {
        Base Inicio;

        public void agregar(Base nuevo)
        {
            if (Inicio == null)
            {
                Inicio = nuevo;
                nuevo.Siguiente = Inicio;
                nuevo.Anterior = Inicio;
            }
            else
            {
                nuevo.Siguiente = Inicio;
                nuevo.Anterior = Inicio.Anterior;
                Inicio.Anterior.Siguiente = nuevo;
                Inicio.Anterior = nuevo;
            }
        }

        public Base Buscar(string nombre)
        {
            return Buscar(Inicio, nombre);
        }

        public Base Buscar(Base b, string nombre)
        {
            if(b.Nombre==nombre)
            {
                return b;
            }
            else
            {
                if (b.Siguiente == null)
                {
                    return null;
                }
                else
                {
                    return Buscar(b.Siguiente, nombre);
                }
            }
        }
        public string Reporte()
        {
            Base reporte = Inicio;
            string r = "";

            if(Inicio==null)
            {
                return "";
            }
            else
            {
                while (reporte.Siguiente != Inicio) 
                {
                    r = string.Format("{0}\n{1}", r, reporte.Cadena());
                    reporte = reporte.Siguiente;
                }
                r = string.Format("{0}\n{1}", r, reporte.Cadena());
                return r;
            }
        }
        
        public string GenerarRuta(Base BaseIncio, TimeSpan HoraInicio, TimeSpan HoraFin)
        {
            Base b = BaseIncio;
            string r = "\b" + b.Nombre;
            TimeSpan HoraLlegada = HoraInicio;
            
            while (b.Siguiente != BaseIncio)
            {
                r += Environment.NewLine;
                b = b.Siguiente;
            }
            r += Environment.NewLine;
            b = b.Siguiente;

            while (HoraLlegada <= HoraFin)
            {
                while(HoraLlegada<=HoraFin && b.Siguiente != BaseIncio)
                {
                    r = string.Format("{0}\b{1}", r, HoraLlegada);
                    b = b.Siguiente;
                    HoraLlegada += b.Tiempo;
                }
                
                if(HoraLlegada<=HoraFin)
                {
                    r = string.Format("{0}\b{1}", r, HoraLlegada);
                    b = b.Siguiente;
                    HoraLlegada += b.Tiempo;
                }
                r += Environment.NewLine;
            }
            return r;
        }
    }
}
