using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        #region Fields

        private string nombre;
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;

        #endregion

        #region Methods

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidad;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                        return e;
                }
                e.jugadores.Add(j);
            }
            return e;
        }

        #endregion
    }
}
