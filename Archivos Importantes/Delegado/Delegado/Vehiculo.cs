using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegado
{

    public delegate int MiDelegado(string nombreMetodo, int numeroInvocacion);

    public class Vehiculo
    {
        public event MiDelegado miEvento;
        public MiDelegado deleg;

        public void mostrar(int cant)
        {
            if (cant > 3)
            {
        //        deleg.Invoke("Mostrar", cant);
                miEvento.Invoke("Mostrar", cant);
            }
        }

    }
}
