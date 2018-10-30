using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public abstract class Archivos
    {
        #region Methods

        protected virtual bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new FileNotFoundException();
            }
            return true;
        }

        #endregion
    }
}
