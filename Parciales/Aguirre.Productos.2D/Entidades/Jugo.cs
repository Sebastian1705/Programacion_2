using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Productos
    {
        #region Fields

        protected ESaborJugo sabor;
        protected static bool DeConsumo;

        #endregion

        #region Propieties

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.Precio * 0.4f;
            }
        }

        #endregion

        #region Methods

        static Jugo()
        {
            DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this.sabor = sabor;
        }

        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendLine($"Sabor: {this.sabor}");
            return sb.ToString();
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }

        #endregion

        #region Nested Types

        public enum ESaborJugo
        {
            Asqueroso, Pasable, Rico
        }

        #endregion
    }
}
