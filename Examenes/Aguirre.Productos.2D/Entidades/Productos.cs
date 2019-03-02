using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Productos
    {
        #region Fields

        protected int codigoBarra;
        protected EMarcaProducto marca;
        protected float precio;

        #endregion

        #region Propieties

        public EMarcaProducto Marca
        {
            get
            {
                return this.marca;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
        }

        public abstract float CalcularCostoDeProduccion
        {
            get;
        }

        #endregion

        #region Methods

        public Productos(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this.codigoBarra = codigoBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public static bool operator ==(Productos p1, EMarcaProducto m1)
        {
            bool retorno = false;
            if(!(p1 is null) && p1.Marca == m1)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Productos p1, EMarcaProducto m1)
        {
            return !(p1 == m1);
        }

        public static bool operator ==(Productos p1, Productos p2)
        {
            bool retorno = false;
            if (!(p1 is null) && !(p2 is null))
            {
                if (p1.Equals(p2) && p1.Marca == p2.Marca && p1.codigoBarra == p2.codigoBarra)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Productos p1, Productos p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Productos p)
        {
            int retorno = 0;
            if(!(p is null))
            {
                retorno = p.codigoBarra;
            }
            return retorno;
        }

        public static implicit operator string(Productos p)
        {
            string retorno = null;
            if (!(p is null))
            {
                retorno = p.MostrarProducto(p);
            }
            return retorno;
        }

        private string MostrarProducto(Productos p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {p.marca}");
            sb.AppendLine($"Precio:{p.precio} ");
            sb.AppendLine($"Codido de barras: {p.codigoBarra}");
            return sb.ToString();
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType()) ? true : false;
        }

        #endregion

        #region Nested Types

        public enum EMarcaProducto
        {
            Manaos, Pitusas, Naranju, Diversion, Swif, Favorita
        }

        public enum ETipoProducto
        {
            Galletita, Gaseosa, Jugo, Harina, Todos
        }

        #endregion
    }
}
