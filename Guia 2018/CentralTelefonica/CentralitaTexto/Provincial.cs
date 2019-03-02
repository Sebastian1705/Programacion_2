using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTexto
{
    public class Provincial : Llamada,IGuardar<string>
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

        public string RutaDeArchivo { get; set; }

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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()} - Costo: {this.CostoLlamada} - Franja Horaria: {this.franjaHoraria} ");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            return false;
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
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
