using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Fields

        private short caballosDeFuerza;

        #endregion

        #region Propieties

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        #endregion

        #region Methods

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {
            
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.CaballosDeFuerza == a2.CaballosDeFuerza && (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2)
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public new string MostrarDatos()
        {
            return String.Format($"{base.MostrarDatos()} - Caballos de fuerza: {this.CaballosDeFuerza}");
        }

        #endregion
    }
}
