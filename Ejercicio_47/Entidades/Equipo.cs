using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        #region Fields

        private string nombre;
        private DateTime fechaCreacion;

        #endregion

        #region Propieties

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }

        #endregion

        #region Methods

        public Equipo()
        {

        }

        public Equipo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Equipo(string nombre, DateTime fechaCreacion)
            : this(nombre)
        {
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool retorno = false;
            if(!(e1 is null) && !(e2 is null))
            {
                if(e1.Nombre == e2.Nombre && e1.FechaCreacion == e2.FechaCreacion)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            return String.Format($"{this.Nombre} fundado el {this.FechaCreacion.Date}");
        }

        #endregion
    }
}
