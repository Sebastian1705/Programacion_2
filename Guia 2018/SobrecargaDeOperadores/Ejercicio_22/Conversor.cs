using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    /*13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
    string DecimalBinario(double). Convierte un número de decimal a binario.
    double BinarioDecimal(string). Convierte un número binario a decimal.*/
    public class Conversor
    {
        /// <summary>
        /// Método que convierte un número entero en un binario ASCII
        /// </summary>
        /// <param name="entero">Número a convertir. EJ: 9</param>
        /// <returns>Valor binario ASCII resultado de la conversión. EJ: 1001</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            while (numero > 0)
            {
                binario = (numero % 2).ToString() + binario;
                numero = numero / 2;
            }
            return binario;
        }

        /// <summary>
        /// Método que convierte un binario ASCII en un número entero
        /// </summary>
        /// <param name="binario">Binario ASCII a convertir. EJ: 1001</param>
        /// <returns>Valor entero resultado de la conversión. EJ: 9</returns>
        public static double BinarioDecimal(string binario)
        {
            double entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += double.Parse(binario[i - 1].ToString()) * (double)Math.Pow(2, binario.Length - i);
            }
            return entero;
        }
    }
}
