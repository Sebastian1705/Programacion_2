using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
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
            set
            {
                this.nombre = value;
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
                this.documento = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
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

        public string ExponerDatos()
        {
            string retorno = "";
            return retorno;
        }

        #endregion

    }
}
