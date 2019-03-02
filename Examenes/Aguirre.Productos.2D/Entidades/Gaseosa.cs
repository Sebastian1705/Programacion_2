using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Productos
    {
        #region Fields

        protected float litros;
        protected static bool DeConsumo;

        #endregion

        #region Propieties

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.Precio * 0.42f;
            }
        }

        #endregion

        #region Methods

        static Gaseosa()
        {
            DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, EMarcaProducto marca, float precio,float litros )
            : base(codigoBarra, marca, precio)
        {
            this.litros = litros;
        }

        public Gaseosa(Productos p, float litros)
            : this((int)p, p.Marca, p.Precio, litros)
        {

        }

        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendLine($"Litros: {this.litros}");
            return sb.ToString();
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }

        #endregion
    }
}
