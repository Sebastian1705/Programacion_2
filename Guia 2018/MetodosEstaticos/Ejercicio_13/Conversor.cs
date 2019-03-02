using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    /*13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
    string DecimalBinario(double). Convierte un número de decimal a binario.
    double BinarioDecimal(string). Convierte un número binario a decimal.*/
    public class Conversor
    {
        public static string BinarioDecimal(string binario)
        {
            int numero = 0, x, y;
            bool v = true;
            for (x = binario.Length - 1, y = 0; x >= 0; x--, y++)
            {
                if (binario[x] == '0' || binario[x] == '1')
                {
                    numero += (int)(int.Parse(binario[x].ToString()) * Math.Pow(2, y));
                }
                else
                {
                    v = false;
                    break;
                }
            }
            if (v)
                return numero.ToString();
            else
                return "Valor invalido";
        }

        public static string DecimalBinario(string numero)
        {
            string error = "Valor invalido";
            double retorno = 0;
            if (Double.TryParse(numero, out retorno))
                return DecimalBinario(retorno);
            else
                return error;
        }

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
    }
}
