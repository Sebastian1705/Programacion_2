using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Automovil : VehiculoTerrestre
    {
        #region Fields

        private short cantidadMarchas;
        private int cantidadPasajeros;

        #endregion

        #region Propieties

        public int CantidadPasajeros
        {
            get
            {
                return this.cantidadPasajeros;
            }
            set
            {
                this.cantidadPasajeros = value;
            }
        }

        public short CantidadMarchas
        {
            get
            {
                return this.cantidadMarchas;
            }
            set
            {
                this.cantidadMarchas = value;
            }
        }

        #endregion

        #region Methods

        public Automovil(short cantRuedas, short cantPuertas, Colores color, short cantMarchas, int cantPasajeros)
            : base(cantRuedas, cantPuertas, color)
        {
            this.CantidadMarchas = cantMarchas;
            this.CantidadPasajeros = cantPasajeros;
        }

        #endregion
    }
}
