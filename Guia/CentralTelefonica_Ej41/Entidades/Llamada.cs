using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public abstract class Llamada
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

        public abstract float CostoLlamada
        {
            get;
        }

        #endregion

        #region Methods

        public Llamada(string nroOrigen, string nroDestino, float duracion)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Origen: {this.NroOrigen}\t Destino: {this.nroDestino}\t Duracion: {this.Duracion.ToString()}");
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.duracion.CompareTo(llamada2.duracion);
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if(l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
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
