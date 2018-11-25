using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Animal
    {
        #region Fields

        private Razas raza;
        private static int patas;

        #endregion

        #region Methods

        static Perro()
        {
            patas = 4;
        }

        public Perro(int velocidadMaxima)
            : base(patas, velocidadMaxima)
        {
            
        }

        public Perro(Razas raza, int velocidadMaxima)
            : this(velocidadMaxima)
        {
            this.raza = raza;
        }

        public string MostarPerro()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat($"{base.MostrarDAtos()}");
            sb.AppendLine($"Raza: {this.raza}");
            sb.AppendLine($"Cantidad de patas: {patas}");
            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            if (!(p1 is null) && !(p2 is null))
            {
                if (p1.raza == p2.raza && p1.VelocidadMaxima == p2.VelocidadMaxima)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Nested Types

        public enum Razas
        {
            Galgo, OvejeroAleman
        }

        #endregion
    }
}
