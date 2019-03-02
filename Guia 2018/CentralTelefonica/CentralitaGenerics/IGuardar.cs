using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaGenerics
{
    public interface IGuardar<T>
    {
        #region Propieties

        string RutaDeArchivo { get; set; }

        #endregion

        #region Methods

        bool Guardar();
        T Leer();

        #endregion
    }
}
