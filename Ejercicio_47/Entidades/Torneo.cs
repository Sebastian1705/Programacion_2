using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        #region Fields

        private List<T> equipos;
        private string nombre;

        #endregion

        #region Propieties

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                return this.CalcularPartido(this.equipos[r.Next(0, this.equipos.Count)], this.equipos[r.Next(0, this.equipos.Count)]);
            }
        }

        #endregion

        #region Methods

        public Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;
            if(!(torneo is null) && !(equipo is null))
            {
                foreach(T item in torneo.equipos)
                {
                    if(item == equipo)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random r = new Random();
            string retorno = null;
            if(!(e1 is null) && !(e2 is null))
            {
                retorno = String.Format($"{e1.Nombre} {r.Next(0,3)} – {r.Next(0, 5)} {e2.Nombre}");
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.Nombre}");
            foreach(T item in this.equipos)
            {
                sb.AppendLine($"{item.Ficha()}");
            }
            return sb.ToString();
        }

        #endregion
    }
}
