using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        #region Fields

        private int x;
        private int y;

        #endregion

        #region Methods

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetY()
        {
            return this.y;
        }
        public int GetX()
        {
            return this.x;
        }
        #endregion
    }
}
