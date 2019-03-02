using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class EscrituraWrapper
    {
        #region Fields

        public ConsoleColor color;
        public string texto;

        #endregion

        #region Methods

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }

        #endregion
    }
}
