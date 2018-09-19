using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class PuestoAtencion
    {
        #region Fields

        private static int numeroActual;
        private Puesto puesto;

        #endregion

        #region Propieties

        public int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }

        #endregion

        #region Methods
        
        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(2000);
            return true;
        }
        
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) 
        {
            this.puesto = puesto;
        }

        #endregion

        #region Types

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        #endregion
    }
}
