using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_11
{
    class Validacion
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            if (valor < min || valor > max)
            {
                return false;
            }
            return true;
        }
    }
}
