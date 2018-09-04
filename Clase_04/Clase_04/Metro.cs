using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_04
{
    class Metro
    {
        public double valor;

        public Metro(double valor)
        {
            this.valor = valor;
        }

        public static Metro operator +(Metro metro, Centimetro centimetro)
        {
            metro.valor += centimetro.valor / 100;
            return metro;
        }
    }
}
