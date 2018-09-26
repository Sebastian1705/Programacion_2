using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jefe : Persona
    {
        #region FIELDS

        private DateTime fechaIngreso;

        #endregion

        #region PROPIEDADES

        public int Antiguedad
        {
            get
            {
                int ans=0;
                int dias = int.Parse(DateTime.Now.Date.ToString("yyyyMMddHHmmss"));
                int ingreso = int.Parse(this.fechaIngreso.ToString("yyyyMMddHHmmss"));
                
                return ans= dias - ingreso; 
            }
        }

        #endregion

        #region METODOS 

        public override string ExponerDatos()
        {
            string ans = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Antiguedad: {1} ", base.ExponerDatos(), this.Antiguedad);
            sb.AppendLine("");

            return ans = sb.ToString();
        }

        public Jefe(string nombre, string apellido, string documento) 
            : base (nombre, apellido, documento)
        {

        }

        public Jefe(string nombre, string apellido, string documento, DateTime fechaingreso) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaingreso;
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool ans = false;

            if (doc.Length > 8)
                ans = true;
            
            return ans;
        }

        #endregion
    }
}
