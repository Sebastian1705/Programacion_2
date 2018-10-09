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
            StringBuilder sb = new StringBuilder();          
            sb.AppendFormat("{0} {1}", this.Nombre, this.Raza);
            return sb.ToString();
        }

        public static bool operator ==(Gato j1, Gato j2)
        {
            bool retorno = false;
            if (!Object.ReferenceEquals(j1, null) && !Object.ReferenceEquals(j2, null))
            {
                if (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType()) ? true : false;
        }

        public static bool operator !=(Gato j1, Gato j2)
        {
            return !(j1 == j2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        #endregion
    }
}
