using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T>
    {
        #region Methos

        void Guardar(string path, T datos);
        T Leer(string path);

        #endregion
    }
}
