using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    /*a. Sobreescribir el método ToString para que retorne "¡Este es mi método ToString
    sobreescrito!".
    b. Sobreescribir el método Equals para que retorne true si son del mismo tipo (objetos de la
    misma clase), false en caso contrario.
    c. Sobreescribir el método GetHashCode para que retorne el número 1142510187.*/
    public class Sobreescrito
    {
        #region Methods

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            if (obj is Sobreescrito)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        #endregion
    }
}
