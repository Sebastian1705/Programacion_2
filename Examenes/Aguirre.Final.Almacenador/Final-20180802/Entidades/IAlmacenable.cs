using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear la interfaz genérica IAlmacenable con los métodos bool Guardar(V elemento) y T Leer(string path)
    public interface IAlmacenable<T,V>
    {
        #region Methods

        bool Guardar(V elemento);

        T Leer(string path);

        #endregion
    }
}
