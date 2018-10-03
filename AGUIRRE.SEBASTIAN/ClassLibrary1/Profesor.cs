using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        #region Fields

        private DateTime fechaDeIngreso;

        #endregion

        #region Propieties

        public int Antiguedad
        {
            get
            {
                return (DateTime.Now - fechaDeIngreso).Days;
            }
        }
        #endregion

        #region Methods

        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaDeIngreso)
      : base(nombre, apellido, documento)
        {
          this.fechaDeIngreso = fechaDeIngreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\tAntiguedad: {1}", base.ExponerDatos(), this.Antiguedad);
            return sb.ToString();
        }

        protected override bool ValidarDocumentos(string doc)
            {
              bool retorno = false;
              if (doc.Length == 8)
              {
                  retorno = true;
              }
              return retorno;
            }

        #endregion
    }
}
