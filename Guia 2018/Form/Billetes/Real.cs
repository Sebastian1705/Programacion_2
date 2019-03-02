using System;
using System.Collections.Generic;
using System.Text;

namespace Billetes
{
    public class Real
    {
        #region Fields

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region Methods

        static Real()
        {
            cotizRespectoDolar = 3.88f;
        }

        public Real(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Real(double cantidad, float cotizacion)
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
        
        public static explicit operator Dolar(Real r)
        {
            double c = r.GetCantidad() / Real.GetCotizacion();
            return new Dolar(c);
        }

        public static explicit operator Pesos(Real r)
        {
            return (Pesos)((Dolar)r);
        }

        public static implicit operator Real(double d)
        {
            return new Real(d);
        }

        public static bool operator ==(Real r, Real r2)
        {
            if (r.GetCantidad() == r2.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(Real r, Real r2)
        {
            return !(r == r2);
        }

        public static bool operator ==(Real r, Pesos p)
        {
            return r == (Real)p;
        }

        public static bool operator !=(Real r, Pesos p)
        {
            return !(r == p);
        }

        public static Real operator +(Real r, Pesos p)
        {
            double c = r.GetCantidad() + ((Real)p).GetCantidad();
            return new Real(c);
        }

        public static Real operator -(Real r, Pesos p)
        {
            double c = r.GetCantidad() - ((Real)p).GetCantidad();
            return new Real(c);
        }

        public static bool operator ==(Real r, Dolar d)
        {
            return r == (Real)d;
        }

        public static bool operator !=(Real r, Dolar d)
        {
            return !(r == d);
        }

        public static Real operator +(Real r, Dolar d)
        {
            double c = r.GetCantidad() + ((Real)d).GetCantidad();
            return new Real(c);
        }

        public static Real operator -(Real r, Real d)
        {
            double c = r.GetCantidad() - ((Real)d).GetCantidad();
            return new Real(c);
        }

        #endregion
    }
}
