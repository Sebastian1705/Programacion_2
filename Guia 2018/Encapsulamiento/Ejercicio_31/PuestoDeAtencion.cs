using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    public class PuestoDeAtencion
    {
        #region Fields

        private static int numeroActual;
        private Puesto puesto;

        #endregion

        #region Propieties

        /// <summary>
        /// NumeroActual es una propiedad estática, encargada de incrementar en 1 al atributo
        /// numeroActual y luego retornarlo.
        /// </summary>
        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// numeroActual es estático y privado. Se inicializará en el constructor de clase con valor 0.
        /// </summary>
        static PuestoDeAtencion()
        {
            numeroActual = 0;
        }

        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        /// <summary>
        /// El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará
        /// un tiempo de atención mediante el método de clase Sleep de la clase Thread(perteneciente
        /// al espacio de nombre System.Threading) y retornará true para indicar el final de la atención.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool Atender(Cliente c)
        {
            Thread.Sleep(1000);
            return true;
        }

        #endregion

        #region Nested Types

        public enum Puesto
        {
            Caja1, Caja2
        }
        
        #endregion
    }
}
