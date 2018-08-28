using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_02
{
    public class Automovil
    {
        public Single velocidadActual;

        public static Byte cantidadRuedas = 4;

        public static void MostrarCantidadRuedas()
        {
            Console.WriteLine(Automovil.cantidadRuedas);
        }

        public void Acelerar (Single velocidad)
        {
            this.velocidadActual += velocidad;
        }
    }
}
