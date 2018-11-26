using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAlmacenable<T,V>
    {
        #region Methods

        bool Guardar(V elemento);

        T Leer(string path);

        #endregion
    }
}
