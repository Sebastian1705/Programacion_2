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

        void Guardar(string destino, T datos);

        T Leer(string origen);

        #endregion
    }
}
