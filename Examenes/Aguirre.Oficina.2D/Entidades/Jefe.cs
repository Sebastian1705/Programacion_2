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

        private DateTime fechaIngreso;

        #endregion

        #region Propieties

        public int Antiguedad
        {
            get
            {
                return ((DateTime.Now - fechaIngreso).Days);
            }
        }

        #endregion

        #region Methods

        public Jefe(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {

        }

        public Jefe(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ExponerDatos()}");
            sb.AppendLine($"Fecha de ingreso: {this.fechaIngreso}");
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = true;
            if (!(doc is null))
            {
                if (doc.Length == 8)
                {
                    for (int i = 0; i < doc.Length; i++)
                    {
                        if (!char.IsNumber(doc[i]))
                        {
                            retorno = false;
                        }
                    }
                }
            }
            return retorno;
        }

        #endregion
    }
}
