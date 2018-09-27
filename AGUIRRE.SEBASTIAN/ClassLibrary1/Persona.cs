using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Departamentos
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

        public string Apellido
        {
            get
            {
                return this.apellido;
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
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Apellido: {0}  Nombre: {1}  Documento: {2}", this.Apellido, this.Nombre, this.Documento);
            sb.AppendLine("");
            retorno = sb.ToString();
            return retorno;
        }

        protected abstract bool ValidarDocumentos(string doc);

        #endregion

    }
}
