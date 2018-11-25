using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Productos
    {
        #region Fields

        protected float peso;
        protected static bool DeConsumo;

        #endregion

        #region Propieties

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.precio * 0.33f;
            }
        }

        #endregion

        #region Methods

        static Galletita()
        {
            DeConsumo = true;
        }

        public Galletita(int codigoBarras, float precio, EMarcaProducto marca, float peso)
            : base(codigoBarras, marca, precio)
        {
            this.peso = peso;
        }

        private string MostrarGalletita()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendLine($"Peso: {this.peso}");
            return sb.ToString();
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        public override string ToString()
        {
            return this.MostrarGalletita();
        }


        #endregion
    }
}
