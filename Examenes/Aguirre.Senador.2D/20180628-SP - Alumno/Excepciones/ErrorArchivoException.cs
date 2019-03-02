using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(string msj)
            : this(msj, null)
        {

        }

        public ErrorArchivoException(string msj, Exception innerException)
           : base(msj, innerException)
        {

        }
    }
}
