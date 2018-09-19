using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Cliente
    {
        #region Fields

        private string nombre;
        private int numero;

        #endregion

        #region Propieties

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        #endregion

        #region Methods

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre) : this(numero) 
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if (!Object.ReferenceEquals(c1, null) && !Object.ReferenceEquals(c2, null))
            {
                if (c1.numero == c2.numero)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }


        #endregion
    }
}
