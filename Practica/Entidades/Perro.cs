using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        #region Fields

        private int edad;
        private bool esAlfa;

        #endregion

        #region Propieties
        
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }
        
        #endregion

        #region Methods

        public Perro(string nombre, string raza)
            :base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
          : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if(this.EsAlfa == true)
            {
                sb.AppendFormat("{0} {1}, alfa de la manada, edad {3}", this.Nombre,
                                                                        this.Raza,
                                                                        this.Edad);
            }
            else
            {
                sb.AppendFormat("{0} Cruza edad {1}", this.Nombre, this.Edad);
            }
            return sb.ToString();
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            bool retorno = false;
            if (!Object.ReferenceEquals(j1, null) && !Object.ReferenceEquals(j2, null))
            {
                if (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.Edad == j2.Edad)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType()) ? true : false;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion
    }
}
