using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region Fields

        private short cilindrada;

        #endregion

        #region Propieties

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        #endregion

        #region Methods

        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia,short cilindrada)
            : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            if ((VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2 && m1.Cilindrada == m2.Cilindrada)
                return true;
            return false;
        }

        public static bool operator !=(MotoCross m1,MotoCross m2)
        {
            return !(m1 == m2);
        }

        public new string MostrarDatos()
        {
            return String.Format($"{base.MostrarDatos()} - Cilindrada: {this.Cilindrada}");
        }

        #endregion
    }
}
