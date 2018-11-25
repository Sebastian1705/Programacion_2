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

        private short anio;
        private Divisiones division;
        private Profesor profesor;
        private List<Alumno> alumnos;

        #endregion

        #region Propieties

        public string AnioDivision
        {
            get
            {
                return String.Format($"{this.anio}º{this.division}");
            }
        }


        #endregion

        #region Mothods

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            if(!(c is null))
            {
                sb.AppendLine($"Curso {c.AnioDivision}");
                sb.AppendLine("");
                sb.AppendLine("Profesor:");
                sb.AppendLine("");
                sb.AppendLine($"{c.profesor.ExponerDatos()}");
                sb.AppendLine("");
                sb.AppendLine("Alumnos: ");
                sb.AppendLine("");
                foreach (Alumno item in c.alumnos)
                {
                    sb.AppendLine($"{item.ExponerDatos()}");
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;
            if(!(c is null) && !(a is null))
            {
                if(c.AnioDivision == a.AnioDivision)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

        #endregion


    }
}
