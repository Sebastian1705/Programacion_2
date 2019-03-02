using System;
using System.Collections.Generic;
using System.Text;

namespace Billetes
{
    public class Pesos
    {
        #region Fields

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region Methods

        static Pesos()
        {
            cotizRespectoDolar = 38.29f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Real(Pesos p)
        {
            return (Real)((Dolar)p);
        }

        public static explicit operator Dolar(Pesos p)
        {
            double c = p.GetCantidad() / Pesos.GetCotizacion();
            return new Dolar(c);
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator ==(Pesos p, Pesos p2)
        {
            if (p.GetCantidad() == p2.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(Pesos p, Pesos p2)
        {
            return !(p == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            double c = p.GetCantidad() + ((Pesos)d).GetCantidad();
            return new Pesos(c);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            double c = p.GetCantidad() - ((Pesos)d).GetCantidad();
            return new Pesos(c);
        }

        public static bool operator ==(Pesos p, Real r)
        {
            return p == (Pesos)r;
        }

        public static bool operator !=(Pesos p, Real r)
        {
            return !(p == r);
        }

        public static Pesos operator +(Pesos p, Real r)
        {
            double c = p.GetCantidad() + ((Pesos)r).GetCantidad();
            return new Pesos(c);
        }

        public static Pesos operator -(Pesos p, Real r)
        {
            double c = p.GetCantidad() - ((Pesos)r).GetCantidad();
            return new Pesos(c);
        }

        #endregion
    }
}
