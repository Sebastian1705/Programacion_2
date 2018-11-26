using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        #region Fields

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region Propieties

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Methods

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0, acumLocal = 0, acumProvincial = 0;
            foreach(Llamada llamada in listaDeLlamadas)
            {
                if(llamada is Local)
                {
                    Local auxLocal = (Local)llamada;
                    acumLocal  += auxLocal.CostoLlamada;
                }
                else if(llamada is Provincial)
                {
                    Provincial auxProvincial = (Provincial)llamada;
                    acumProvincial += auxProvincial.CostoLlamada;
                }
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        retorno = acumLocal;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        retorno = acumProvincial;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        retorno = acumLocal + acumProvincial;
                        break;
                }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------");
            sb.AppendLine("Razon Social: " + razonSocial);
            sb.AppendLine("Ganancia Total: \t$" + GananciasPorTotal.ToString("0.##"));
            sb.AppendLine("Ganancia Local: \t$" + GananciasPorLocal.ToString("0.##"));
            sb.AppendLine("Ganancia Provincial: \t$" + GananciasPorProvincial.ToString("0.##"));
            sb.AppendLine("------------------------------------");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    Local aux = (Local)llamada;
                    sb.AppendLine(aux.ToString());
                }
                else if (llamada is Provincial)
                {
                    Provincial aux = (Provincial)llamada;
                    sb.AppendLine(aux.ToString());
                }
            }
            return sb.ToString();
        }

        #endregion
    }
}
