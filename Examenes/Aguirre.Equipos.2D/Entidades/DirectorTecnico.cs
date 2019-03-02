using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region Campos

        private int aniosExperiencia;

        #endregion

        #region Propiedades

        public int Aniosxperiencia
        {
            get
            {
                return this.aniosExperiencia;
            }
            set
            {
                this.aniosExperiencia = value;
            }
        }

        #endregion

        #region Metodos

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int experiencia)
            : base(nombre, apellido, edad, dni)
        {
            this.Aniosxperiencia = experiencia;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Anios de Experiencia: {this.Aniosxperiencia}");
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            if(this.Edad <= 65 && this.Aniosxperiencia >= 2)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
