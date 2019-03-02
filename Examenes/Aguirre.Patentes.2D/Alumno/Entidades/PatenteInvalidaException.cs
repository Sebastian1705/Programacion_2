using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidaException : Exception
    {
        #region Methods

        public PatenteInvalidaException(string mensaje)
            : base(mensaje)
        {

        }

        public PatenteInvalidaException(string mensaje, Exception innerExeption)
            : base(mensaje, innerExeption)
        {

        }

        #endregion
    }
}
