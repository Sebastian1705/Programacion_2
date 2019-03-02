using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MaterialException : Exception
    {
        public MaterialException()
            : base()
        {

        }

        public MaterialException(string msj)
            : this(msj, null)
        {

        }

        public MaterialException(string msj, Exception innerExeption)
            : base(msj, innerExeption)
        {

        }
    }
}
