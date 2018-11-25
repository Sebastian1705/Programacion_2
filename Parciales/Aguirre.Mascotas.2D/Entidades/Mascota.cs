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

        protected virtual string DatosCompletos()
        {
            return String.Format($"{this.Nombre} {this.Raza}");
        }

        #endregion
    }
}
