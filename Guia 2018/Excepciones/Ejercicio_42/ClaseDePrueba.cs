using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class ClaseDePrueba
    {

        #region Methods

        public ClaseDePrueba()
        {
            try
            {
                MetodoDeClase();
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        public ClaseDePrueba(int a)
            : this()
        {
            try
            {
                MetodoDeClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("2do Constructor de Instancia Exception", e);
            }
        }

        public static void MetodoDeClase()
        {
            try
            {
                int aux = 0;
                int res = 10 / aux;
            } 
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        #endregion

    }
}
