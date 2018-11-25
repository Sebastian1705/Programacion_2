using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        #region Fields

        private short anio;
        private Divisiones division;

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

        #region Methods

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ExponerDatos()}");
            sb.AppendLine($"Anio division: {this.AnioDivision}");           
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = true;
            if (!(doc is null))
            {
                if (doc.Length == 9)
                {
                    for (int i = 0; i < doc.Length; i++)
                    {
                        // Valido posición de los guiones
                        if (i == 2 || i == 7)
                        {
                            if (doc[i] != '-')
                            {
                                retorno = false;
                            }
                        }
                        else
                        {
                            // Valido posición de los números
                            if (!char.IsNumber(doc[i]))
                            {
                                retorno = false;
                            }
                        }
                    }
                }
            }
            return retorno;
        }

        #endregion
    }
}
