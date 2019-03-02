using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Recibo : Documento
    {
        #region Methods

        public Recibo()
            : this(0)
        {

        }

        public Recibo(int numero)
            : base(numero)
        {

        }

        #endregion
    }
}
