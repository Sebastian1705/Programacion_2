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
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if(this.EsAlfa)
            {
                sb.AppendFormat($"{base.DatosCompletos()}, es alfa de la manada, edad {this.Edad}");
            }
            else
            {
                sb.AppendFormat($"{base.DatosCompletos()} edad {this.Edad}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            bool retorno = false;
            if (!(j1 is null) && !(j2 is null))
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
            int retorno = -1;
            if(perro is null)
            {
                retorno =  perro.Edad;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Perro)
            {
                retorno = this == ((Perro)obj);
            }
            return retorno;
        }

        #endregion
    }
}
