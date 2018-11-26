using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Campos

        private int legajo;

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Universitario()
            : base()
        {

        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="legajo">Legajo asignado al universitario</param>
        /// <param name="nombre">Nombre del universitario</param>
        /// <param name="apellido">Apellido del universitario</param>
        /// <param name="dni">Dni del universitario</param>
        /// <param name="nacionalidad">Nacionalidad del universotario (Argentino - Extranjero)</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Metodo virtual que muestra los datos completos del universitario.
        /// </summary>
        /// <returns>Srtring con los datos del universitario.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"LEGAJO: {this.legajo}");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga operador ==.
        /// Compara que 2 universitarios tengan igual numero de legajo, tipo, y dni.
        /// </summary>
        /// <param name="pg1">objeto de tipo universitario a comparar</param>
        /// <param name="pg2">objeto de tipo universitario a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario false.</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if(!(pg1 is null) && !(pg2 is null))
            {
                if((pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo ) && pg1.GetType() == pg2.GetType())
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador !=.
        /// Compara que 2 universitarios tengan igual numero de legajo, tipo, y dni.
        /// </summary>
        /// <param name="pg1">objeto de tipo universitario a comparar</param>
        /// <param name="pg2">objeto de tipo universitario a comparar</param>
        /// <returns>Retorna true si son distintos, caso contrario false.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Sobrecarga de Equals.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Retorno true si el objeto es igual, caso conrario retorna false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null) && (obj is Universitario))
            {
                if (this == (Universitario)obj)
                    retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Metodo abstracto.
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        #endregion
    }
}
