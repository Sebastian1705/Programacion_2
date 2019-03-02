using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    /*Jugador:
    a. Todos los datos estadísticos del Jugador se inicializarán en 0 dentro del constructor privado.
    b. El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
    c. MostrarDatos retornará una cadena de string con todos los datos y estadística del Jugador.
    d. Dos jugadores serán iguales si tienen el mismo DNI.*/
    public class Jugador
    {
        #region Fields

        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        #endregion

        #region Methods

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            if(this.partidosJugados != 0)
                this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
                return true;
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} - Dni: {this.dni} - Jugados: {this.partidosJugados} - Goles: {this.totalGoles} - Promedio: {this.GetPromedioGoles()}");
            return sb.ToString();
        }

        #endregion
    }
}
