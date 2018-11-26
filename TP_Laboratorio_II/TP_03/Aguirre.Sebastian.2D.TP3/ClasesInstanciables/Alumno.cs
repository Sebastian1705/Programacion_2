using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Campos

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Alumno()
            : base()
        {

        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="id">Legajo del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">Dni del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="claseQueToma">Clase que toma el alumno. (Enumerado)</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="id">Legajo del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">Dni del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="claseQueToma">Clase que toma el alumno. (Enumerado)</param>
        /// <param name="estadoCuenta">Estado de cuenta - Enumerado (Al dia - Deudor - Becado)</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        /// <summary>
        /// Hace publicos los datos de un alumno llamando al metodo MostradrDatos().
        /// </summary>
        /// <returns>Retorna un string con los datos del alumno.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Metodo privado que uestra los datos completos de un alumno.
        /// </summary>
        /// <returns>Retorna un string con los datos completos de un alumno.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta}");
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que expone a traves de string la clase que toma el alumno.
        /// </summary>
        /// <returns>Retorna el string TOMA CLASE seguido del nombre de dicha clase.</returns>
        protected override string ParticiparEnClase()
        {
            return String.Format($"TOMA CLASE DE {this.claseQueToma}\n");
        }

        /// <summary>
        /// Sobrecarga de operador ==
        /// Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a">Objeto tipo alumno</param>
        /// <param name="clase">clase a comparar</param>
        /// <returns>True si el alumno  toma esa clase y su estado de cuenta no es Deudor, false caso contrario. </returns>
        public static bool operator==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;
            if(!(a is null) && a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador !=.
        /// Un Alumno será distinto a un EClase sólo si no toma esa clase.
        /// </summary>
        /// <param name="a">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>True si no toma la clase, false caso contrario.</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;
            if(!(a is null) && a.claseQueToma != clase)
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion

        #region Tipos Anidados

        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }

        #endregion
    }
}
