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
        /// Propiedad que asigna valor al atributo numero
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
        /// Constructor sin parametros
        /// </summary>
        public Numero()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Valida que la la cadena recibida contenga caracteres numericos
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>Retorna el valor de ser posible o 0 en caso contrario</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            if (!(object.ReferenceEquals(strNumero, null)))
            {
                if (double.TryParse(strNumero, out retorno))
                    return retorno;
            }
            return retorno;
        }
       
        /// <summary>
        /// Convierte una cadena de caracteres binarios en un string decimal
        /// </summary>
        /// <param name="binario">Dato en binario a corvertir</param>
        /// <returns>Cadena con el resultado decimal</returns>
        public static string BinarioDecimal(string binario)
        {
            int numero = 0, x , y;
            
            bool v = true;
            for(x = binario.Length-1, y=0; x >= 0; x--, y ++)
            {
                if(binario[x] == '0' || binario[x] == '1')
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
                return "No es binario";
        }
        
        /// <summary>
        /// Metodo que convierte un numero deimal en binario
        /// </summary>
        /// <param name="numero">Numero a convertir</param>
        /// <returns>Cadena con el numero en binario</returns>
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
       
        /// <summary>
        /// Metodo que convierte una cadena de caracteres numericos (decimal) a binario
        /// </summary>
        /// <param name="numero">Cadena a convertir</param>
        /// <returns>Resultado de la conversion a binario</returns>
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
        /// Metodo que sobrecarga el operador +
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Metodo que sobrecarga el operador -
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Metodo que sobrecarga el operador *
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// </summary>
        /// <param name="n1">Dato de tipo Numero</param>
        /// <param name="n2">Dato de tipo Numero</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
        #endregion
    }
}
