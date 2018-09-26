using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aguirre.Sebastian._2D
{
    abstract class Mascota
    {
        #region Fields

        private string nombre;
        private string raza;

        #endregion

        #region Propieties

       public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        #endregion

        #region Methods

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        protected abstract string Ficha();

        /*virtual protected string DatosCompletos()
        {

        }*/

        #endregion
    }
}
