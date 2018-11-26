using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Campos

        private List<Alumno> alumnos;
        private Universidad.EClases clases;
        private Profesor instructor;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura y escritura.
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
        /// Propiedad de lectura y escritura.
        /// </summary>
        public Universidad.EClases Clases
        {
            get
            {
                return this.clases;
            }
            set
            {
                this.clases = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor por defecto.
        /// Inicia la lista lista de alumnos.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="clases">Clase de la jornada.</param>
        /// <param name="instructor">Profesor que dara la clase.</param>
        public Jornada(Universidad.EClases clases, Profesor instructor)
            : this()
        {
            this.Clases = clases;
            this.Instructor = instructor;
        }

        /// <summary>
        /// Metodo que mostrara los datos de la Jornada.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"CLASE DE {this.Clases} POR {this.Instructor.ToString()}");
            sb.AppendLine("ALUMNOS: ");
            foreach(Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("<-------------------------------->");
            return sb.ToString();
        }

        /// <summary>
        /// Metodo de clase que lee un archivo con datos de una jornada.
        /// </summary>
        /// <returns>Reorna un string con los datos, o lanza una excepcion en caso de error.</returns>
        public static string Leer()
        {
            Texto aux = new Texto();
            string datos = null;
            try
            {
                aux.Leer("Jornada.txt", out datos);
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
            return datos;
        }

        /// <summary>
        /// Metodo de clase que guarda la los datos de la Jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada">Jornada que se usara de referencia.</param>
        /// <returns>Retorna true si genera el archivo, caso contrario lanza una excepcion.</returns>
        public static bool Guardar(Jornada jornada)
        {
            if(!(jornada is null))
            {
                Texto texto = new Texto();
                try
                {
                    texto.Guardar("Jornada.txt", jornada.ToString());
                }
                catch(Exception e)
                {
                    throw new ArchivosException(e);
                }
            }
            return true; ;
        }

        /// <summary>
        /// Sobrecarga operador ==.
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j">Jornada a comprarar</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>True si el alumno participa, false caso contrario.</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;
            if(!(j is null) && !(a is null))
            {
                foreach(Alumno item in j.Alumnos)
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
        /// Una Jornada será distinta a un Alumno si el mismo no participa de la clase.
        /// </summary>
        /// <param name="j">Jornada a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Sobrecarga operardor +.
        /// Se agregara al alumno si no forma parte de la jornada.
        /// </summary>
        /// <param name="j">Jornada a comparar.</param>
        /// <param name="a">Alumno a comparar / agregar.</param>
        /// <returns>Retorna la jornada, haya podido o no agregar el alumno.</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }

        #endregion
    }
}
