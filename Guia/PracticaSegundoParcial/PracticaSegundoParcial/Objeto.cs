using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSegundoParcial
{
    [Serializable]
    public class Objeto
    {
        private int dato;

        public int Dato
        {
            get
            {
                return this.dato;
            }
            set
            {
                this.dato = value;

            }
        }

        public Objeto(int dato)
        {
            this.Dato = dato;

        }

    }
}
