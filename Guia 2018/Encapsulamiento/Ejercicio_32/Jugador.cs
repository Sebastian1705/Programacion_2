using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    /*a. Agregar propiedades de sólo lectura a los atributos partidosJugados, promedioGoles y
    totalGoles de Jugador, y de lectura/escritura a nombre y dni.
    b. Quitar el atributo promedioGoles de jugador. Calcular dicho promedio dentro de la
    propiedad de sólo lectura PromedioDeGoles.
    c. Quitar el método GetPromedioGoles, colocando dicha lógica a la respectiva propiedad.
    d. Realizar todos los cambios necesarios para que vuelva a funcionar como antes.*/
    public class Jugador
    {
        #region Fields

        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        #endregion

        #region Propieties

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                float aux = 0;
                if (this.partidosJugados != 0)
                    aux = (float)this.totalGoles / this.partidosJugados;
                return aux;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
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

        public int Dni
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

        #endregion

        #region Methods

        private Jugador()
        {
            this.partidosJugados = 0;
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
            sb.AppendLine($"Nombre: {this.Nombre} - Dni: {this.Dni} - Jugados: {this.PartidosJugados} - Goles: {this.TotalGoles} - Promedio: {this.PromedioGoles}");
            return sb.ToString();
        }

        #endregion
    }
}
