using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Generar la clase Torneo con un tipo genérico.
    //1. Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
    public class Torneo<T> where T : Equipo
    {
        #region Fields

        private List<T> equipos;
        private string nombre;

        #endregion

        //2. Tendrá un atributo equipos : List<T> y otro nombre : string.
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

        public List<T> Equipos
        {
            get
            {
                return this.equipos;
            }
            set
            {
                this.equipos = value;
            }
        }

        /// <summary>
        /// 7. La propiedad pública JugarPartido tomará dos equipos de la lista al azar y
        /// calculará el resultado del partido a través del método CalcularPartido.
        /// </summary>
        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                return this.CalcularPartido(this.Equipos[r.Next(0, this.Equipos.Count)], this.Equipos[r.Next(0, this.Equipos.Count)]);
            }
        }

        #endregion

        #region Methods

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre)
            : this()
        {
            this.Nombre = nombre;
        }

        /// <summary>
        /// 3. Sobrecargar el operador == para que controle si un equipo ya está inscripto al
        /// torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach(T item in torneo.Equipos)
            {
                if (item == equipo)
                    return true;
            }
            return false;
        }

        public static bool operator!=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        ///  5. El método Mostrar retornará los datos del torneo y de los equipos
        /// participantes.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.Nombre}");
            sb.AppendLine();
            foreach(T item in this.Equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }

        /// <summary>
        ///  4. Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando
        ///  este no se encuentre ya en el torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
                torneo.Equipos.Add(equipo);
            return torneo;
        }

        /// <summary>
        /// 6. El método privado CalcularPartido(T, T): string recibirá dos elementos del tipo
        /// T, que deberán ser del tipo Equipo o sus herencias, y calculará utilizando
        /// Random un resultado del partido.Retornará el resultado con el siguiente
        /// formato: “[EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]”, siendo
        /// EQUIPOX el nombre del equipo y RESULTADOX la cantidad de goles/puntos.
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        private string CalcularPartido(T a, T b)
        {
            Random r = new Random();
            int resultado1, resultado2;
            if (a is EquipoFutbol && b is EquipoFutbol)
            {
                resultado1 = r.Next(10);
                resultado2 = r.Next(10);
            }
            else
            {
                resultado1 = r.Next(100);
                resultado2 = r.Next(100);
            }
            return String.Format($"{a.Nombre} {resultado1} - {resultado2} {b.Nombre}");
        }

        #endregion
    }
}
