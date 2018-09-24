using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class VehiculoTerrestre
    {
        private short cantidaRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private int pesoCarga;
        private short cilindrada;
        private short cantidadPasajeros;

        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga, short cilindrada, short cantidadPasajeros)
        {
            this.cantidaRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
            this.cilindrada = cilindrada;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
