using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        #region Fields

        protected Franja franjaHoraria;

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

        public Provincial(Franja franjaHoraria, Llamada llamada)
            : this(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion, franjaHoraria)
        {

        }

        public Provincial(string origen, string destino, float duracion, Franja miFranja)
            :base(origen, destino, duracion)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = this.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    retorno = this.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    retorno = this.Duracion * 0.66f;
                    break;
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.Mostrar()}\tCosto: ${this.CostoLlamada}\t\tFranja horaria: {this.franjaHoraria}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        #endregion

        #region Nested Types

        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        #endregion
    }
}
