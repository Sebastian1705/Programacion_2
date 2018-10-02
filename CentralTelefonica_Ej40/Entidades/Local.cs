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

        public override float CostoLlamada
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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t Costo Local: ${1}", base.Mostrar(), this.CostoLlamada.ToString("0.##"));
            return sb.ToString();
        }

        #endregion
    }
}
