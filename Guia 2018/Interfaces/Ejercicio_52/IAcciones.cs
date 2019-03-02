using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public interface IAcciones
    {
        #region Propieties

        ConsoleColor Color { get; set; }
        float UnidadesDeEscritura { get; set; }

        #endregion

        #region Methods

        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidades);

        #endregion
    }
}
