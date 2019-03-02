using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializar<T,V> : IGuardar<T,V>
    {
        #region Methods

        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            V retorno = (V)Convert.ChangeType("Objeto Leído", typeof(V));
            return retorno;
        }

        #endregion
    }
}
