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
                return String.Format("{0}º{1}", this.anio, this.division);
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
            sb.AppendFormat("{0}\tAnio / Division: {1}\t", base.ExponerDatos(),this.AnioDivision);
            return sb.ToString();
        }

        protected override bool ValidarDocumentos(string doc)
        {
          bool retorno = false;
          if(doc.Length == 8 && doc[2] == '-' && doc[7] == '-')
          {
            retorno = true;
          }
          return retorno;
        }

        #endregion

  }
}
