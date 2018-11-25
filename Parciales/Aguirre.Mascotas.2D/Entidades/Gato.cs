using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region Methods

        public Gato(string nombre, string raza)
            :base(nombre, raza)
        {

        }

        protected override string Ficha()
        {
            return String.Format($"{base.DatosCompletos()}");
        }

        public static bool operator ==(Gato j1, Gato j2)
        {
            bool retorno = false;
            if (!(j1 is null) && !(j2 is null))
            {
                if (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Gato j1, Gato j2)
        {
            return !(j1 == j2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Gato)
            {
                retorno = this == ((Gato)obj);
            }
            return retorno;
        }

        #endregion
    }
}
