using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        #region Methods

        /// <summary>
        /// Metodo que valida operadores
        /// </summary>
        /// <param name="operador">string a validar</param>
        /// <returns>operador validado por defecto retorna +</returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "";
            if (!(operador is null))
            {
                switch(operador)
                {
                    case "+":
                        retorno = operador;
                        break;
                    case "-":
                        retorno = operador;
                        break;
                    case "*":
                        retorno = operador;
                        break;
                    case "/":
                        retorno = operador;
                        break;
                    default:
                        retorno = "+";
                        break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que realiza la operacion aritmetica.
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operando</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            Double resultado = 0;
            if (!(num1 is null) && !(num2 is null) && !(operador is null))
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

        #endregion
    }
}
