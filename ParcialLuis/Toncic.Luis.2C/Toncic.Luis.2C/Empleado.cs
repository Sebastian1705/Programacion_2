using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region FIELDS

        private Departamentos departamento;
        private short piso;

        #endregion

        #region PROPIEDADES

        public string PisoDepartamento
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}º{1}", this.piso, this.departamento);
                                
                return sb.ToString(); 

            }
        }

        #endregion

        #region METODOS 

        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento) 
            : base(nombre, apellido, documento)
        {
            this.piso = piso;
            this.departamento = departamento;
        }

        public override string ExponerDatos()
        {
            string ans = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Division: {1} ", base.ExponerDatos(), this.PisoDepartamento);
            sb.AppendLine("");

            return ans= sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool ans = false;

            if (doc.Equals("##-####-#"))
                ans= true;

            return ans;
        }

        #endregion
    }
}
