using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extras;

namespace Entidades
{
    [Serializable]
    public abstract class Animal
    {
        #region Fields

        private string nombre;
        private DateTime nacimiento;

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

        public DateTime Nacimiento
        {
            get
            {
                return this.nacimiento;
            }
            set
            {
                if (value.MiMetodoDeExtencion())
                    this.nacimiento = value;
                else
                    throw new FechaNacimientoInvalidaException();
            }
        }

        #endregion

        #region Methods

        public Animal()
        {
            this.Nacimiento = DateTime.Now;
        }

        public Animal(string nombre)
            : this()
        {
            this.Nombre = nombre;
        }

        public Animal(string nombre, DateTime nacimiento)
        {
            this.Nombre = nombre;
            this.Nacimiento = nacimiento;
        }

        public static explicit operator string(Animal a)
        {
            return String.Format($"NOMBRE: {a.Nombre} - NACIMIENTO: {a.Nacimiento}");
        }

        protected virtual string ExponerDatos()
        {
            return (string)this;
        }

        public static bool operator ==(Animal a, Animal b)
        {
            if(a.Nombre == b.Nombre && a.Nacimiento == b.Nacimiento)
                return true;
            return false;
        }

        public static bool operator !=(Animal a, Animal b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return this.ExponerDatos();
        }

        #endregion
    }
}
