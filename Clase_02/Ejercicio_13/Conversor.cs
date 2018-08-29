using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int entero = (int)numero;
            while (entero >= 2)
            {
                binario = (entero % 2).ToString() + binario;
                entero = (int)entero / 2;
            }
            return entero.ToString() + binario;
        }

        public static double BinarioDecimal(string binario)
        {
            int nroDecimal = 0, aux = 0;
            string retorno = "";
            double auxiliar;
            for (int i = 1; i <= binario.Length; i++)
            {
                if (Int32.TryParse(binario[i - 1].ToString(), out aux) && (aux == 1 || aux == 0))
                {
                    nroDecimal += aux * (int)Math.Pow(2, binario.Length - i);
                    retorno = nroDecimal.ToString();
                }
                else
                    retorno = "Valor invalido";
            }
            double.TryParse(retorno, out auxiliar);
            return auxiliar;
        }
    }
}
