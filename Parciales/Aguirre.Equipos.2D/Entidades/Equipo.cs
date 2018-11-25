using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Campos

        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        #endregion

        #region Propiedades

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }
        
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Metodos

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) 
            : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de equipo: {e.Nombre}");
            if(e.directorTecnico is null)
            {
                sb.AppendLine("Sin director tecnico asignado");
            }
            else
            {
                sb.AppendLine($"Director tecnico: {e.directorTecnico.Nombre}"); 
            }
            sb.AppendLine("");
            sb.AppendLine("Jugadores:");
            sb.AppendLine("");
            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine($"{item.Mostrar()}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            if(!(e is null) && !(j is null))
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j && e.jugadores.Count <= cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            int arquero = 0, defensor = 0, delantero = 0, central = 0;
            if(!(e is null) && e.jugadores.Count == cantidadMaximaJugadores && !(e.directorTecnico is null))
            {
                foreach(Jugador item in e.jugadores)
                {
                    if (item.Posicion == Posicion.Arquero)
                        arquero++;
                    else if (item.Posicion == Posicion.Defensor)
                        defensor++;
                    else if (item.Posicion == Posicion.Central)
                        central++;
                    else if (item.Posicion == Posicion.Delantero)
                        delantero++;
                }
                if(arquero == 1 && defensor != 0 && central !=0 && delantero != 0)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion
    }
}
