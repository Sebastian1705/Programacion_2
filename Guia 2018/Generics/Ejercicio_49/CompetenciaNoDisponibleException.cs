using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_49
{
    public class CompetenciaNoDisponibleException : Exception
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

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
         : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepción en el método {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine(this.Message);
            sb.AppendLine(this.InnerException.Message);
            return sb.ToString();
        }

        #endregion
    }
}
