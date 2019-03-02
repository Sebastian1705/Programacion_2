using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Fields

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region Propieties

        public float GanananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GanananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GanananciasPorTotal
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

        /// <summary>
        /// La lista sólo se inicializará en el constructor por defecto Centralita().
        /// </summary>
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        /// <summary>
        /// CalcularGanancia será privado. Este método recibe un Enumerado TipoLlamada y retornará
        /// el valor de lo recaudado, según el criterio elegido(ganancias por las llamadas del tipo Local,
        /// Provincial o de Todas según corresponda).
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gLocal = 0, gPrivincial = 0, retorno = 0;
            foreach (Llamada item in this.Llamadas)
            {
                if (item is Local)
                    gLocal += ((Local)item).CostoLlamada;
                else if (item is Provincial)
                    gPrivincial += ((Provincial)item).CostoLlamada;
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = gLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = gPrivincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = gLocal + gPrivincial;
                    break;
            }
            return retorno;
        }
    
        /// <summary>
        /// El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
        /// y provinciales y el detalle de las llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Centralita: {this.razonSocial}");
            sb.AppendLine("Ganancias");
            sb.AppendLine($"Local: {this.GanananciasPorLocal} - Provincial: {this.GanananciasPorProvincial} - Total: {this.GanananciasPorTotal}");
            foreach(Llamada item in this.Llamadas)
            {
                if (item is Local)
                    sb.AppendLine(((Local)item).Mostrar());
                else if (item is Provincial)
                    sb.AppendLine(((Provincial)item).Mostrar());
            }
            return sb.ToString(); ;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion

    }
}
