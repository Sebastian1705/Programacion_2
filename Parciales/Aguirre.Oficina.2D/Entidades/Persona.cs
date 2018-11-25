using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Fields

        private string apellido;
        private string nombre;
        private string documento;

        #endregion

        #region Propieties

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
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
                if (ValidarDocumentacion(value))
                    this.documento = value;
            }
        }

        #endregion

        #region Methods

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento; ;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Dni: {this.Documento}");
            return sb.ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc);

        #endregion
    }
}
