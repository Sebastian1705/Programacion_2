using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        #region Fields

        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        private string nombre;

        #endregion

        #region Methods

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible)
            : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;
            if(!(e is null) && !(v is null))
            {
                foreach(Vehiculo item in e.vehiculos)
                {
                    if(item == v)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if(!(e == v) && v.Patente != null && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if(e == v)
            {
                return v.ImprimirTicket();
            }
            else
            {
                return "El vehiculo no es parte del estacionamiento";
            }
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {e.nombre}\tEspacio: {e.espacioDisponible}\n");
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }
            return sb.ToString();
        }

        #endregion
    }
}
