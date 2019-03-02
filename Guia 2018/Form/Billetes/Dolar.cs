using System;

namespace Billetes
{
    public class Dolar
    {
        #region Fields

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region Methods

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
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

        public static explicit operator Real(Dolar d)
        {
            double c = d.GetCantidad() * Real.GetCotizacion();
            return new Real(c);
        }

        public static explicit operator Pesos(Dolar d)
        {
            double c = d.GetCantidad() * Pesos.GetCotizacion();
            return new Pesos(c);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d, Dolar d2)
        {
            if (d.GetCantidad() == d2.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d == d2);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            double c = d.GetCantidad() + ((Dolar)p).GetCantidad();
            return new Dolar(c);
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            double c = d.GetCantidad() - ((Dolar)p).GetCantidad();
            return new Dolar(c);
        }

        public static bool operator ==(Dolar d, Real r)
        {
            return r == (Dolar)r;
        }

        public static bool operator !=(Dolar d, Real r)
        {
            return !(d == r);
        }

        public static Dolar operator +(Dolar d, Real r)
        {
            double c = d.GetCantidad() + ((Dolar)r).GetCantidad();
            return new Dolar(c);
        }

        public static Dolar operator -(Dolar d, Real r)
        {
            double c = d.GetCantidad() - ((Dolar)r).GetCantidad();
            return new Dolar(c);
        }

        #endregion
    }
}
