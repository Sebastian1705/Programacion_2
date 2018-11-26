using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Metodo que valida operadores
        /// </summary>
        /// <param name="operador">string a validar</param>
        /// <returns>operador validado</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador != "-" && operador != "/" && operador != "*")
                return "+";
            return operador;
        }
        
        /// <summary>
        /// Metodo que realiza la operacion
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operando</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            Double resultado = 0;
            if (!(Object.ReferenceEquals(num1, null)) && 
                !(Object.ReferenceEquals(num2, null)) &&
                !(Object.ReferenceEquals(operador, null)))
            {
                switch (ValidarOperador(operador))
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                }
            }
            return resultado;
        }
    }
}
