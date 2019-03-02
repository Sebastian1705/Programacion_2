using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class VehiculoTerrestre
    {
        #region Fields


        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        #endregion

        #region Propieties

        public short CantidadRuedas
        {
            get
            {
                return this.cantidadRuedas;
            }
            set
            {
                this.cantidadRuedas = value;
            }
        }

        public short CantidadPuertas
        {
            get
            {
                return this.cantidadPuertas;
            }
            set
            {
                this.cantidadPuertas = value;
            }
        }

        public Colores Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        #endregion

        #region Methods

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.Color = color;
        }

        #endregion
    }
}
