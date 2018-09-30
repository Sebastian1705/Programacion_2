using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
    {
        #region Fields

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region Propieties

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion

        #region Methods

        public Llamada(string nroOrigen, string nroDestino, float duracion)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LLAMADA");
            sb.AppendLine("-----------------------");
            sb.AppendFormat("NUMERO ORIGEN: {0}", this.nroOrigen);
            sb.AppendFormat("NUMERO DESTINO: {0}", this.nroDestino);
            sb.AppendFormat("DURACION: {0}", this.duracion);
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.duracion.CompareTo(llamada2.duracion);
        }

        #endregion

        #region Nested Types

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        #endregion
    }
}
