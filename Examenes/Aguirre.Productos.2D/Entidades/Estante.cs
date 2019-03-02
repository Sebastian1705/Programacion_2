using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region Fields

        protected sbyte capacidad;
        protected List<Productos> productos;

        #endregion

        #region Propieties

        #endregion

        public float ValorEstanteTotal
        {
            get
            {
                return 0;
            }
        }

        #region Methods

        private Estante()
        {
            this.productos = new List<Productos>();
        }

        public Estante(sbyte capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }

        public static bool operator ==(Estante e, Productos p)
        {
            bool retorno = false;
            if(!(e is null) && !(p is null))
            {
                foreach(Productos item in e.productos)
                {
                    if(item == p)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Estante e, Productos p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Productos p)
        {
            bool retorno = false;
            if (!(e is null) && !(p is null))
            {
                if(e != p && e.productos.Count < e.capacidad)
                {
                    e.productos.Add(p);
                }
            }
            return retorno;
        }

        public static Estante operator -(Estante e, Productos p)
        {
            if (!(e is null) && !(p is null))
            {
                if(e == p)
                {
                    e.productos.Remove(p);
                }
            }
            return e;
        }

        public static Estante operator -(Estante e, Productos.ETipoProducto tipo)
        {
            if(!(e is null))
            {
                foreach(Productos item in e.productos)
                {
                    if(item .GetType().ToString() == tipo.ToString())
                    {
                        e -= item;
                    }
                }
            }
            return e;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad: {e.capacidad}");
            foreach (Productos prod in e.productos)
            {
                if (prod is Jugo)
                    sb.AppendLine(((Jugo)prod).ToString());
                else if (prod is Gaseosa)
                    sb.AppendLine(((Gaseosa)prod).ToString());
                else if (prod is Galletita)
                    sb.AppendLine(((Galletita)prod).ToString());
                else if (prod is Harina)
                    sb.AppendLine(((Harina)prod).ToString());
            }

            return sb.ToString();
        }

        public List<Productos> GetProductos()
        {
            return this.productos;
        }

        public float GetVAlorEstante()
        {
            return this.GetValorEstante(Productos.ETipoProducto.Todos);
        }

        public float GetValorEstante(Productos.ETipoProducto tipo)
        {
            float acumJugo = 0, acumGaseosa = 0, acumGalle = 0, acumHarina = 0, retorno = 0;
            foreach (Productos prod in this.productos)
            {
                if (prod is Jugo)
                    acumJugo += prod.Precio;
                else if (prod is Gaseosa)
                    acumGaseosa += prod.Precio;
                else if (prod is Galletita)
                    acumGalle += prod.Precio;
                else if (prod is Harina)
                    acumHarina += prod.Precio;
            }
            switch (tipo)
            {
                case Productos.ETipoProducto.Jugo:
                    retorno = acumJugo;
                    break;
                case Productos.ETipoProducto.Gaseosa:
                    retorno = acumGaseosa;
                    break;
                case Productos.ETipoProducto.Galletita:
                    retorno = acumGalle;
                    break;
                case Productos.ETipoProducto.Harina:
                    retorno = acumHarina;
                    break;
                case Productos.ETipoProducto.Todos:
                    retorno = acumJugo + acumGaseosa + acumGalle + acumHarina;
                    break;
            }
            return retorno;

        }

        #endregion
    }
}
