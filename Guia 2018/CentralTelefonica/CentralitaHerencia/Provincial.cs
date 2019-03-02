using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        #region Fields

        private Franja franjaHoraria;

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

        public Provincial(Llamada l1, Franja miFranja)
           : this(l1.NroOrigen, l1.Duracion, l1.NroDestino, miFranja)
        {

        }

        public Provincial(string origen, float duracion, string destino, Franja miFranja)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        /// <summary>
        /// CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
        /// de la misma.Los valores serán: Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float precio = 0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    precio = this.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    precio = this.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    precio = this.Duracion * 0.66f;
                    break;
            }
            return precio;
        }

        /// <summary>
        ///  Método Mostrar expondrá, además de los atributos de la clase base, la propiedad
        /// CostoLlamada y franjaHoraria.Utilizar StringBuilder.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()} - Costo: {this.CostoLlamada} - Franja Horaria: {this.franjaHoraria} ");
            return sb.ToString();
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
