using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Fields

        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        #endregion

        #region Propieties

        public TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }

        #endregion

        #region Methods

        static Grupo()
        {
            tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();     
        }

        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            Tipo = tipo;
        }

        public static bool operator ==(Grupo e, Mascota j)
        {
            bool retorno = false;
            if (!(e is null) && !(j is null))
            {
                foreach (Mascota item in e.manada)
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

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if(e != j)
            {
                e.manada.Add(j);
            }
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if(e == j)
            {
                e.manada.Remove(j);
            }
            return e;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            if (!(e is null))
            {
                sb.AppendLine($"**{e.nombre} {tipo}**");
                sb.AppendLine("Integrantes:");
                foreach(Mascota item in e.manada)
                {
                    sb.AppendLine($"{item.ToString()}");
                }
            }
            return sb.ToString();
        }

        #endregion

        #region Nested Types

        public enum TipoManada
        {
            Unica, Mixta
        }

        #endregion
    }
}
