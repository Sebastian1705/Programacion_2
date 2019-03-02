using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extras
{
    /*  Generar un método de extensión dentro del proyecto Extra para la clase de sistema DateTime que retorne si la instancia
        de este tipo es menor a la fecha actual (miInstanciaDeDateTime <= Now).*/
    public static class MetodoExtension
    {
        #region Methods

        public static bool MiMetodoDeExtencion(this DateTime fecha)
        {
            if (fecha <= DateTime.Now)
                return true;
            else
                return false;
        }

        #endregion
    }
}
