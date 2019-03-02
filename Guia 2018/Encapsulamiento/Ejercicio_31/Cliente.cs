using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
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

        public Cliente(int numero, string nombre)
            : this(numero)
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1.Numero == c2.Numero)
                return true;
            return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}
