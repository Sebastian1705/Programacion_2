using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    /*Llamada:
    b. La clase Llamada, tendrá todos sus atributos con el modificador protected. Crear las
    propiedades de sólo lectura para exponer estos atributos.
    c. OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para
    ordenar una lista de llamadas de forma ascendente.
    d. Mostrar es un método de instancia. Utiliza StringBuilder.*/
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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nro Origen: {this.NroOrigen} - Nro Destino: {this.NroDestino} - Duracion: {this.Duracion}");
            return sb.ToString();
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
