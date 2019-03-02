using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        #region Fields

        private List<Animal> animales;
        private int corredoresMax;

        #endregion

        #region Methods

        private Carrera()
        {
            this.animales = new List<Animal>();
        }

        public Carrera(int corredoresMax)
            : this()
        {
            this.corredoresMax = corredoresMax;
        }

        public string MostrarCarrera(Carrera c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de corredores: {c.corredoresMax}");
            for(int i = 0; i < c.animales.Count; i++)
            {
                if(c.animales[i] is Humano)
                {
                    sb.AppendLine(((Humano)c.animales[i]).MostrarHumano());
                }
                else if (c.animales[i] is Caballo)
                {
                    sb.AppendLine(((Caballo)c.animales[i]).MostarCaballo());
                }
                else if (c.animales[i] is Perro)
                {
                    sb.AppendLine(((Perro)c.animales[i]).MostarPerro());
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Carrera c, Animal a)
        {
            bool retorno = false;
            if(!(c is null) && !(a is null))
            {
                foreach (Animal item in c.animales)
                {
                    if (item == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            return !(c == a);
        }

        public static Carrera operator +(Carrera c, Animal a)
        {
            if(c != a && c.corredoresMax <= c.animales.Count)
            {
                c.animales.Add(a);
            }
            return c;
        }

        #endregion
    }
}
