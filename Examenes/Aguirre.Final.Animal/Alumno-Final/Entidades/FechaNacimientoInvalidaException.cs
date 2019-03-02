using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*2. Generar la excepción FechaNacimientoInvalidaException. La misma tendrá 3 constructores:
        a. FechaNacimientoInvalidaException(): Tendrá un mensaje por defecto.
        b. FechaNacimientoInvalidaException(string mensaje)
        c. FechaNacimientoInvalidaException(string mensaje, Exception innerException)*/
    public class FechaNacimientoInvalidaException : Exception
    {
        #region Methods

        public FechaNacimientoInvalidaException()
            : base()
        {

        }

        public FechaNacimientoInvalidaException(string mensaje)
            : this(mensaje, null)
        {

        }

        public FechaNacimientoInvalidaException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
        
        #endregion
    }
}
