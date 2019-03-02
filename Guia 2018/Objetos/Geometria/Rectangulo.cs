using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        #region Fields

        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        #endregion

        #region Methods

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX(),vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(),vertice3.GetY());
        }

        public float Area()
        {
            return 0;
        }

        public float GetPerimetro()
        {
            return 0;
        }

        #endregion
    }
}
