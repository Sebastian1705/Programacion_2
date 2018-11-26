using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Campos

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor de clase.
        /// Inicializa el atributo random.
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor publico por defecto.
        /// </summary>
        public Profesor()
            : base()
        {
            
        }

        /// <summary>
        /// Constructor de instancia.
        /// Inicia el atributo clasesDelDia y asigna 2 clases al azar.
        /// </summary>
        /// <param name="id">Legajo del profesor</param>
        /// <param name="nombre">Nombre del profesor.</param>
        /// <param name="apellido">Apellido del profesor.</param>
        /// <param name="dni">DNI del profesor.</param>
        /// <param name="nacionalidad">Nacionalidad del profesor.</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        /// <summary>
        /// Rotorna en una cadena los datos del profesor por medio llamando al metodo MostrarDato().
        /// </summary>
        /// <returns>Retorna datos del profesor.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Sobreescritura del medodo.
        /// </summary>
        /// <returns>Rtorna una cadena con los datos completos del profesor.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que muestra las clases que da el profesor.
        /// </summary>
        /// <returns>Retorna la leyenda CLASES DEL DIA: junto a las clases dadas.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASES DEL DIA: ");
            foreach(Universidad.EClases item in clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
       
        /// <summary>
        /// Metodo privado que asigna 2 clases al azar al profesor.
        /// </summary>
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
        }

        /// <summary>
        /// Sobrecarga de operador ==.
        /// Un Profesor será igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="i">Objeto de tipo profesor.</param>
        /// <param name="clase">Clase a comparar con profesor.</param>
        /// <returns>Rotorna true si el profesor da la clase, false caso contrario.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach(Universidad.EClases item in i.clasesDelDia)
            {
                if(item == clase)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador !=.
        /// </summary>
        /// <param name="i">Objeto de tipo profesor.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>Retorna true si el profesor no da la clase, caso contrario false.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    }
}
