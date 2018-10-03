using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region Fields

        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        #endregion

        #region Propieties

        public string AnioDivision
        {
            get
            {
                return String.Format("{0}º{1}", this.anio, this.division);
            }
        }

        #endregion

        #region Methods

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            :this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Año/Division: {0}\tProfesor: {1}\n", c.AnioDivision, c.profesor.Apellido);
            foreach (Alumno alumno in c.alumnos)
            {
                sb.AppendLine(alumno.ExponerDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;
            if(!Object.ReferenceEquals(c, null) && !Object.ReferenceEquals(a, null) && c.AnioDivision == a.AnioDivision)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

        #endregion

  }
}
