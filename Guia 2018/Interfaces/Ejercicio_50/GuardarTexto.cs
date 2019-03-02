using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {
        #region Methods

        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            V retorno = (V)Convert.ChangeType("Texto Leido", typeof(V));
            return retorno;
        }

        #endregion
    }
}
