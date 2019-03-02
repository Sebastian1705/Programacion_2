using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Productos
    {
        #region Fields

        protected ETipoHarina tipo;
        protected static bool DeConsumo;

        #endregion

        #region Propieties

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.Precio * 0.6f;
            }
        }

        #endregion

        #region Methods

        static Harina()
        {
            DeConsumo = false;
        }

        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigoBarra, marca, precio)
        {
            this.tipo = tipo;
        }

        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendLine($"Tipo: {this.tipo}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }

        #endregion

        #region Nested Types

        public enum ETipoHarina
        {
            CuatroCeros, TresCeros, Integral
        }

        #endregion
    }
}
