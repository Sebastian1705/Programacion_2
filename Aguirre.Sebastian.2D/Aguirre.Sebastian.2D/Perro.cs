using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aguirre.Sebastian._2D
{
    class Perro : Mascota
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

        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.esAlfa = esAlfa;
            this.edad = edad;
        }



        #endregion
    }
}
