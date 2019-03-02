using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class DirectorTecnico : Persona
    {
        #region Fields

        private DateTime fechaNacimiento;

        #endregion

        #region Propieties

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }  
            set
            {
                this.fechaNacimiento = value;
            }
        }

        #endregion

        #region Methods

        private DirectorTecnico(string nombre)
            : base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (d1.Nombre == d2.Nombre && d1.FechaNacimiento == d2.FechaNacimiento)
                return true;
            return false;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }

        public new string MostrarDatos()
        {
           return String.Format($"Nombre: {base.Nombre} - Fecha de Nac: {this.FechaNacimiento}");
        }

        #endregion
    }
}
