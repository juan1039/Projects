using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Proceso
    {
        int x = 1;
        Procesos Inicio;
        Random Aleatorio = new Random();

        private int _ProcesoLibre = 0;
        private int _ProcesosNoConcluidos = 0;
        private int _SumaDeLosProcesos = 0;
        private int _ProcesosMaximos = 0;
        private int _ProcesosConcluidos = 0;

        public int ProcesoLibre
        {
            get { return _ProcesoLibre; }
        }
        public int ProcesosNoConcluidos
        {
            get { return _ProcesosNoConcluidos; }
        }
        public int SumaDeLosProcesos
        {
            get { return _SumaDeLosProcesos; }
        }
        public int ProcesosMaximos
        {
            get { return _ProcesosMaximos; }
        }
        public int ProcesosConcluidos
        {
            get { return _ProcesosConcluidos; }
        }

        public void agregar(Procesos nuevo)
        {
            Procesos p = Inicio;
            
            if (Inicio == null)
                Inicio = nuevo;

            else
            {
                while (p.Siguiente != null) 
                p = p.Siguiente;
                p.Siguiente = nuevo;
                
            }
        }

        public void NuevoProceso()
        {
            Procesos q = new Procesos("Proceso " + x, Aleatorio.Next(4, 13));
            x += 1;
            agregar(q);
        }
        public string Procesamiento()
        {
            string s = "";

            for(int i=1;i<201;i++)
            {
                if(Aleatorio.Next(1,101)<21)
                {
                    NuevoProceso();
                }
                if(Inicio==null)
                {
                    _ProcesoLibre++;
                }
                else
                {
                    Inicio.Tiempo -= 1;
                    if (Inicio.Tiempo == 0)
                    {
                        Eliminar();
                    }
                    s += "Proceso: " + i + Environment.NewLine + Reporte() + Environment.NewLine;
                }
            }
            ContadorFinal();
            return s;
        }
        public void ContadorFinal()
        {
            _ProcesosNoConcluidos = 0;
            _SumaDeLosProcesos = 0;
            Procesos n = Inicio;

            if (Inicio != null)
            {
                do
                {
                    _ProcesosNoConcluidos += 1;
                    _SumaDeLosProcesos += n.Tiempo;
                    n = n.Siguiente;
                }
                while (n.Siguiente != null);
            }
        }
        private void Eliminar()
        {
            Inicio = Inicio.Siguiente;
            _ProcesosConcluidos += 1;
        }
        public string Reporte()
        {
            Procesos o = Inicio;
            int n = 0;
            string s="";

            if (Inicio == null)
                return "";
            else
            {
                while (o.Siguiente != null)
                {
                    n += 1;
                    s = string.Format("{0}\n{1}" + "-", s, o.cadena());
                    o = o.Siguiente;
                }
                s = string.Format("{0}\n{1}" + "", s, o.cadena());
                if (n > ProcesosMaximos)
                {
                    _ProcesosMaximos = n;
                }
                return s;
            }
        }
        

    }
}
