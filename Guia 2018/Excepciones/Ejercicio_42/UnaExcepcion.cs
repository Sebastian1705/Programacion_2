using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class UnaExcepcion : Exception
    {
        #region Methods

        public UnaExcepcion(string msg, Exception innerException)
            : base(msg, innerException)
        {

        }

        #endregion
    }
}
