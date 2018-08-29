using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_14
{
    class CalcuoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            double aux = -1;

            if (numero > 0)
            {
                aux = Math.Pow(numero, 2);
            }
            return aux;
        }

        public static double CalcularTriangulo(double num1, double num2)
        {
            double aux = -1;

            if(num1 > 0 && num2 > 0)
            {
                aux = (num1 * num2) / 2;
            }
            return aux;
        }

        public static double CalcularCirculo(double numero)
        {
            double pi = 3.1415, aux = -1;

            if(numero > 0)
            {
                aux = Math.Pow(numero, 2) * pi;
            }
            return aux;
        }
    }
}
