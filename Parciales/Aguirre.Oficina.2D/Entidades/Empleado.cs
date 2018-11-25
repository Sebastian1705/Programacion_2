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

        private short piso;
        private Departamentos departamento;

        #endregion

        #region Propieties

        public string PisoDepartamento
        {
            get
            {
                return String.Format($"{this.piso}º{this.departamento}");
            }
        }

        #endregion

        #region Methods

        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento)
            : base(nombre, apellido, documento)
        {
            this.piso = piso;
            this.departamento = departamento;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ExponerDatos()}");
            sb.AppendLine($"Piso Departamento: {this.PisoDepartamento}");
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = true;
            if (!(doc is null))
            {
                if (doc.Length == 9)
                {
                    for (int i = 0; i < doc.Length; i++)
                    {
                        // Valido posición de los guiones
                        if (i == 2 || i == 7)
                        {
                            if (doc[i] != '-')
                            {
                                retorno = false;
                            }
                        }
                        else
                        {
                            // Valido posición de los números
                            if (!char.IsNumber(doc[i]))
                            {
                                retorno = false;
                            }
                        }
                    }
                }
            }
            return retorno;
        }

        #endregion
    }
}
