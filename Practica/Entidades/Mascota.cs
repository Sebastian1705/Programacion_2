using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        #region Fields

        string nombre;
        string raza;

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
        /*
        public int MyProperty
        {
            get;
            {

            }
            set;
            {

            }
        }
        */
        #endregion

        #region Methods

        protected abstract string Ficha();
     
        protected virtual string DatosCompletos()
        {
            return String.Format("{0} {1}", this.Nombre, this.Raza);
        }

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        #endregion

        #region Nested Types



        #endregion
    }
}
