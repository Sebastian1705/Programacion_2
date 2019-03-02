using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Camion : VehiculoTerrestre
    {
        #region Fields

        private short cantidadMarchas;
        private int pesoCarga;

        #endregion


        #region Propieties

        public int PesoCarga
        {
            get
            {
                return this.pesoCarga;
            }
            set
            {
                this.pesoCarga = value;
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

        public Camion(short cantRuedas, short cantPuertas, Colores color, short cantMarchas, int pesoCarga)
            : base(cantRuedas, cantPuertas, color)
        {
            this.CantidadMarchas = cantMarchas;
            this.PesoCarga = pesoCarga;
        }

        #endregion
    }
}
