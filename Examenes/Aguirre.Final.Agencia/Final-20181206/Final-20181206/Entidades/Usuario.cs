using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region Fields

        private string nombre;
        private string clave;

        #endregion

        #region Propieties

        public string Nombre { get => nombre; }

        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                //ALUMNO
                if (value.Length > 7)
                    clave = value;
                else
                    throw new ClaveInvalidaException("La clave debe contener al menos 8 dígitos!");
            }
        }

        #endregion

        #region Methods

        public Usuario(string nombre, string clave)
        {
            this.nombre = nombre;
            this.Clave = clave;
        }

        #endregion
    }
}
