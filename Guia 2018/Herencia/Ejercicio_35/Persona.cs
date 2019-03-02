using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Persona
    {
        #region Fields

        private long dni;
        private string nombre;

        #endregion

        #region Propieties

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

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

        #endregion

        #region Methods

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(string nombre, long dni)
            : this(nombre)
        {
            this.Dni = dni;
        }

        public string MostrarDatos()
        {
            return String.Format($"Nombre: {this.Nombre} - Dni: {this.Dni}");
        }

        #endregion
    }
}
