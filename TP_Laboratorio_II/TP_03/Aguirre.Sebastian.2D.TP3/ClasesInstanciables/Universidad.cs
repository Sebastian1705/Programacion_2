using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad
    {
        #region Campos

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura / escritura.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }


        /// <summary>
        /// Propiedad de lectura / escritura.
        /// </summary>
        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }


        /// <summary>
        /// Propiedad de lectura / escritura.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }


        /// <summary>
        /// Propiedad de lectura / escritura con indexador.
        /// </summary>
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }

        #endregion

        /// <summary>
        /// Constructor por defecto.
        /// inicializa los listas.
        /// </summary>
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Profesores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }

        /// <summary>
        /// Sobrecarga, hace publicos los datos de Universidad a traves del metodo de clase.
        /// </summary>
        /// <returns>Retorna un string con los datos de la universidad.</returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        /// <summary>
        /// Metodo privado y de clase, muestra los datos de la universidad.
        /// </summary>
        /// <param name="uni">Universidad de referencia para obtener datos.</param>
        /// <returns>REtorna un string con los datos de la universidad.</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            foreach (Jornada item in uni.Jornadas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga operador ==.
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>Retorna true si esta inscripto, si no false.</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            if (!(g is null) && !(a is null))
            {
                foreach(Alumno item in g.Alumnos)
                {
                    if(item == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador !=.
        /// Un Universidad será distinto a un Alumno si el mismo NO está inscripto en él.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>Retorna true si NO esta inscripto, si no false.</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

       /// <summary>
       /// Sobrecarga operador +.
       /// Se agreagara al alumno si no esta previamente cargado.
       /// </summary>
       /// <param name="u">Universidad a comparar.</param>
       /// <param name="a">Alumno a comparar - agregar.</param>
       /// <returns>True si se cargo el alumno, caso contrario lanza una excepcion.</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (!(u is null) && !(a is null))
            {
                if (u != a)
                {
                    u.Alumnos.Add(a);
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
            }
            return u;
        }

        /// <summary>
        /// Sobrecarga operador ==.
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g">Universidad a comprarar.</param>
        /// <param name="i">Profesor a comparar.</param>
        /// <returns>TRue si el profesor da clases, false en caso contrario.</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;
            if (!(g is null) && !(i is null))
            {
                foreach (Profesor item in g.Profesores)
                {
                    if (item == i)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador !=.
        /// Un Universidad será distinto a un Profesor si el mismo NO está dando clases en él.
        /// </summary>
        /// <param name="g">Universidad a comprarar.</param>
        /// <param name="i">Profesor a comparar.</param>
        /// <returns>True si el profesor NO da clases, false en caso contrario.</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Sobrecarga operador +.
        /// Se agreagara al aprofesor si no esta previamente cargado.
        /// </summary>
        /// <param name="u">Universidad a comparar.</param>
        /// <param name="a">Profesor a comparar - agregar.</param>
        /// <returns>True si se cargo el profesor, false caso contrario.</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (!(u is null) && !(i is null))
            {
                if (u != i)
                {
                    u.Profesores.Add(i);
                }
            }
            return u;
        }

        /// <summary>
        /// Sobrecarga operador ==.
        /// La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="a">Clase a comparar.</param>
        /// <returns>Retorna el primer profesor, si no lanza una excepcion.</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            if (!(u is null))
            {
                foreach (Profesor item in u.Profesores)
                {
                    if (item == clase)
                    {
                        return item;
                    }
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Sobrecarga operador !=.
        /// </summary>
        /// <param name="u">Universidad a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>retornará el primer Profesor que no pueda dar la clase o lanza una excepcion.</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            if (!(u is null))
            {
                foreach (Profesor item in u.Profesores)
                {
                    if (item != clase)
                    {
                        return item;
                    }
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Sobrecarga operador +.
        /// Al agregar una clase a un Universidad se genera y agrega una nueva Jornada,
        /// se asigna un Profesor y la lista de alumnos que la toman.
        /// </summary>
        /// <param name="u">Universidad a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>La universidad con la nueva jornada.</returns>
        public static Universidad operator +(Universidad u, EClases clase)
        {
            Jornada auxJornada = null;
            Profesor auxProfesor = null;
            if (!(u is null))
            {
                auxProfesor = (u == clase);
                auxJornada = new Jornada(clase, auxProfesor);
                foreach(Alumno item in u.alumnos)
                {
                    if(item == clase)
                    {
                        auxJornada += item;
                    }
                }
                u.Jornadas.Add(auxJornada);
            }
            return u;
        }

        /// <summary>
        /// Metodo de clase que serializa una universidad.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>True si puede serializar, sino lanza una excepcion.</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> aux = new Xml<Universidad>();
            try
            {
                aux.Guardar("Universidad.xml", uni);
            }
            catch(Exception e)
            { 
                throw new ArchivosException(e);
            }
            return true;
        }

        /// <summary>
        /// Metodo de clase Deserializa una universidad.
        /// </summary>
        /// <returns>Retorna una universidad, o lanza una excepcion.</returns>
        public static Universidad Leer()
        {
            Universidad retorno = null;
            Xml<Universidad> aux = new Xml<Universidad>();
            try
            {
                aux.Leer("Universidad.xml", out retorno);
            }
            catch(Exception e)
            { 
                throw new ArchivosException(e);
            }
            return retorno;
        }

        #region Tipos Anidados

        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        #endregion
    }
}
