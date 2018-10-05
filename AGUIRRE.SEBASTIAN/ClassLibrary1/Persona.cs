using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Divisiones
    {
        A, B, C, D, E
    }

    public abstract class Persona
    {
        #region Fields

        private string nombre;
        private string apellido;
        private string documento;

        #endregion

        #region Propieties

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (ValidarDocumentos(value))
                    this.documento = value;
            }
        }

        #endregion

        #region Methods

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat("Nombre: {0}\tApellido: {1}\tDocumento: {2}\t", this.Nombre, this.Apellido, this.Documento);

            sb.AppendLine("");
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Documento: " + this.Documento);
            sb.AppendLine("---------------------------------");

            return sb.ToString();
        }
        
        protected abstract bool ValidarDocumentos(string doc);

        #endregion

    }
}
