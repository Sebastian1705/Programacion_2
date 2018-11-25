using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Campos

        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        #endregion

        #region Propiedades

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

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        #endregion

        #region Metodos

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Dni: {this.Dni}");
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();

        #endregion
    }
}
