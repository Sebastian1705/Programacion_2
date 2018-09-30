using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        #region Fields

        protected float costo;

        #endregion

        #region Propieties

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Methods

        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion, costo)
        {

        }

        public Local(string origen, string destino, float duracion, float costo)
            : base(origen, destino, duracion)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            float retorno = 0;
            retorno = this.costo * base.duracion;
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.Mostrar());
            sb.AppendFormat("COSTO: ${0}", this.CostoLlamada);
            sb.AppendLine("");
            return sb.ToString();
        }

        #endregion
    }
}
