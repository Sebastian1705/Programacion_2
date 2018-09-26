using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public enum Departamentos
        {
            A,
            B,
            C,
            D,
            E
        }

        #region FIELDS

        private string apellido;
        private string documento;
        private string nombre;

        #endregion

        #region PROPIEDADES

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Documento
        {
            set { this.documento = value; }

            get
            {
                string ans = "Documento Invalido";
                if (ValidarDocumentacion(documento))
                    ans = this.documento;
                return ans;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        #endregion

        #region METODOS

        public virtual string ExponerDatos()
        {
            string ans = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Apellido: {0}  Nombre: {1}  Documento: {2}", this.Apellido, this.Nombre, this.Documento);
            sb.AppendLine("");
            
            return ans= sb.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        protected abstract bool ValidarDocumentacion(string doc);
        


#endregion

    }
}
