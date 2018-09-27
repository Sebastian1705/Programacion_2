using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Fields

        private Departamentos departamento;
        private short piso;

        #endregion

        #region Propieties

        public string PisoDepartamento
        {
            get
            {
                return String.Format("{0}º{1}", this.piso.ToString(), this.departamento.ToString());
            }
        }

        #endregion

        #region Methods

        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento)
            :base(nombre, apellido, documento)
        {
            this.piso = piso;
            this.departamento = departamento;
        }

        public override string ExponerDatos()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Piso: {1} Departamento: {2}", base.ExponerDatos(), this.piso, this.departamento);
            sb.AppendLine("");
            retorno = sb.ToString();
            return retorno;
        }

        protected override bool ValidarDocumentos(string doc)
        {
            bool retorno = false;
            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
                retorno = true;
            return retorno;
        }

        #endregion

    }
}
