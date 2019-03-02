using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTexto
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

        #endregion

        #region Methods

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return l1.Duracion.CompareTo(l2.Duracion);
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nro Origen: {this.NroOrigen} - Nro Destino: {this.NroDestino} - Duracion: {this.Duracion}");
            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
                return true;
            return false;
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
