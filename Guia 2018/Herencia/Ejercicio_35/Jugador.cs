using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador : Persona
    {
        #region Fields

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
            set
            {
                this.partidosJugados = value;
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
            set
            {
                this.totalGoles = value;
            }
        }

        #endregion

        #region Methods

        private Jugador(long dni, string nombre)
            : base(nombre, dni)
        {

        }

        public Jugador(long dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.TotalGoles = totalGoles;
            this.PartidosJugados = totalPartidos;
        }
        
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.Dni == j2.Dni)
                return true;
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {base.Nombre} - Dni: {base.Dni} - Jugados: {this.PartidosJugados} - Goles: {this.TotalGoles} - Promedio: {this.PromedioGoles}");
            return sb.ToString();
        }
        
        #endregion
    }
}
