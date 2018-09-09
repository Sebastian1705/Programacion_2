using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    class Estante
    {
        #region Fields

        private Producto[] productos;
        private int ubicacionEstante;

        #endregion

        #region Methods

        public Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La ubicacion del estante es: " + e.ubicacionEstante);
            Producto[] p = e.GetProductos();
            for (int i = 0; i < p.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(p[i]));
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool ans = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    ans = true;
                    break;
                }
            }
            return ans;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], p))
                    {
                        e.productos[i] = null;
                    }
                }
            }
            return e;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool ans = false;
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        ans = true;
                        break;
                    }
                }
            }
            return ans;
        }

        #endregion
    }
}
