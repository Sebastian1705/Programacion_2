using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        #region Methods

        void Guardar(string archivo, T datos);
        void Leer(string archivo, out T datos);

        #endregion
    }
}
