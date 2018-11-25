using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        #region Fields

        private string nombre;
        private static int patas;

        #endregion

        #region Methods

        static Caballo()
        {
            patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima)
            : base(patas, velocidadMaxima)
        {
            this.nombre = nombre;
        }

        public string MostarCaballo()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat($"{base.MostrarDAtos()}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Cantidad de patas: {patas}");
            return sb.ToString();
        }

        public static bool operator ==(Caballo c1, Caballo c2)
        {
            bool retorno = false;
            if(!(c1 is null) && !(c2 is null))
            {
                if(c1.nombre == c2.nombre)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}
