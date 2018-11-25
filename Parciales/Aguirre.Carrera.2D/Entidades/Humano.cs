using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano : Animal
    {
        #region Fields

        private string nombre;
        private string apellido;
        private static int piernas;

        #endregion

        #region Methods

        static Humano()
        {
            piernas = 2;
        }

        public Humano(int velocidadMaxima)
            : base(piernas, velocidadMaxima)
        {

        }

        public Humano(string nombre, string apellido, int velocidadMaxima)
            : this(velocidadMaxima)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string MostrarHumano()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat($"{base.MostrarDAtos()}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Cantidad de piernas: {piernas}");
            return sb.ToString();
        }

        public static bool operator ==(Humano h1, Humano h2)
        {
            bool retorno = false;
            if(!(h1 is null) && !(h2 is null))
            {
                if(h1.nombre == h2.nombre && h1.apellido == h2.apellido)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return !(h1 == h2);
        }

        #endregion
    }
}
