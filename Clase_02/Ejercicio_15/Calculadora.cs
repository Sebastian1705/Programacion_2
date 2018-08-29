using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double num1, double num2, string operador)
        {
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    if(Validar(num2))
                    {
                        resultado = num1 / num2;
                        break;
                    }
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }

        private static bool Validar(double numero2)
        {
            bool retorno = false;
            if(numero2 != 0)
            {
                retorno = true;
            }
            return retorno;
        }
       
    }
}
