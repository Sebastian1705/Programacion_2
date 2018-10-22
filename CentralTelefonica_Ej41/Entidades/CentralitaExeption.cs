using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class CentralitaExeption : Exception
    {
        #region Fields

        private string nombreClase;
        private string nombreMetodo;

        #endregion

        #region Propieties

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        #endregion

        #region Methods

        public CentralitaExeption(string mensaje, string clase, string metodo)
           : this(mensaje, clase, metodo, null)
        {
            
        }

        public CentralitaExeption(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        #endregion

    }
}
