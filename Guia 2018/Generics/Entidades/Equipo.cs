using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*Generar la clase Equipo abstracta.
    1. Agregar un atributo nombre : string y otro fechaCreacion : datetime.
    2. Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
    3. El método Ficha retornará el nombre del equipo y su fecha de creación con el
    siguiente formato “[EQUIPO] fundado el [FECHA]”.*/
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
            set
            {
                this.nombre = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
            set
            {
                this.fechaCreacion = value;
            }
        }

        #endregion

        #region Methods

        public Equipo(string nombre, DateTime fecha)
        {
            this.Nombre = nombre;
            this.FechaCreacion = fecha;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.Nombre == e2.Nombre && e1.FechaCreacion == e2.FechaCreacion)
                return true;
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            return String.Format($"{this.Nombre} fundado el {this.FechaCreacion}");
        }

        #endregion
    }
}
