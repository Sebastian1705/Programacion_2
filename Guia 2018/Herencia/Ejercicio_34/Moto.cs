using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Moto : VehiculoTerrestre
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

        public Moto(short cantRuedas, short cantPuertas, Colores color, short cilindrada)
            : base(cantRuedas, cantPuertas, color)
        {
            this.Cilindrada = cilindrada;
        }

        #endregion
    }
}
