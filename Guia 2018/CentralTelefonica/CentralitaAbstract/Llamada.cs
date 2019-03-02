using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstract
{
    /*Llamada:
    a. La clase Llamada ahora será abstracta. Tendrá definida la propiedad de sólo lectura
    CostoLlamada que también será abstracta.
    b. Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá
    los atributos propios de la clase Llamada
    c. El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
    (utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
    origen son iguales en ambas llamadas.*/
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
