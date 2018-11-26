using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        #region Fields

        private double numero;

        #endregion

        #region Prppieties

        /// <summary>
        /// Propiedad que asigna valor al atributo numero, previa validacion.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Numero()
        {

        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="strNumero">Numero a asignar en formato string.</param>
        public Numero(string strNumero)
            : this()
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="numero">Numero a asignar.</param>
        public Numero(double numero)
            : this(numero.ToString())
        {

        }

        /// <summary>
        /// Valida que la la cadena recibida contenga caracteres numericos.
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>Retorna el valor de ser posible o 0 en caso contrario</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0, aux = 0;
            if (!(strNumero is null))
            {
                if (double.TryParse(strNumero, out aux))
                    retorno = aux;
            }
            return retorno;
        }
       
        /// <summary>
        /// Sobrecarga de oprador +.
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = 0;
            if (!(n1 is null))
            {
                retorno = n1.numero + n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga de oprador -.
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = 0;
            if (!(n1 is null))
            {
                retorno = n1.numero - n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga de oprador *.
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = 0;
            if (!(n1 is null))
            {
                retorno = n1.numero * n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = 0;
            if (!(n1 is null))
            {
                if (n2.numero != 0)
                {
                    retorno = n1.numero / n2.numero;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte una cadena de caracteres binarios en un string decimal.
        /// </summary>
        /// <param name="binario">Dato en binario a corvertir</param>
        /// <returns>Cadena con el resultado decimal, o "valor invalido" si falla.</returns>
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

        /// <summary>
        /// Método que convierte un número Decimal en un binario ASCII
        /// </summary>
        /// <param name="numero">Numero a convertir.</param>
        /// <returns>Valor binario ASCII resultado de la conversion.</returns>
        public static string DecimalBinario(string numero)
        {
            string error = "Valor invalido";
            double retorno = 0;
            if (Double.TryParse(numero, out retorno))
                return DecimalBinario(retorno);
            else
                return error;
        }

        /// <summary>
        ///  Método que convierte un número Decimal en un binario ASCII.
        /// </summary>
        /// <param name="numero">Numero a convertir.</param>
        /// <returns></returns>
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

        #endregion
    }
}
