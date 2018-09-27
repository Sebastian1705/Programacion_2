using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jefe : Persona
    {
        #region Fields

        private DateTime fechaDeIngreso;

        #endregion

        #region Propieties

        public int Antiguedad
        {
            get
            {
                return (int)((System.DateTime.Now - this.fechaDeIngreso).TotalDays);
            }
        }

        #endregion

        #region Methods

        public Jefe(string nombre, string apellido, string documento)
            :base(nombre, apellido, documento)
        {

        }

        public Jefe(string nombre, string apellido, string documento, DateTime fechaDeIngreso)
            : base(nombre, apellido, documento)
        {
            this.fechaDeIngreso = fechaDeIngreso;
        }

        public override string ExponerDatos()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Antiguedad: {1} ", base.ExponerDatos(), this.Antiguedad);
            sb.AppendLine("");
            retorno = sb.ToString();
            return retorno;
        }

        protected override bool ValidarDocumentos(string doc)
        {
            bool retorno = false;
            if (doc.Length == 8)
                retorno = true;
            return retorno;
        }

        #endregion

    }
}
