using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Documento
    {
        #region Fields

        private int numero;

        #endregion

        #region Propieties

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        #endregion

        #region Methods

        public Documento(int numero)
        {
            this.numero = numero;
        }

        #endregion
    }
}
