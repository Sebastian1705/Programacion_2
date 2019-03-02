using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Lapiz : IAcciones
    {
        #region Fields

        private float tamanioMina;

        #endregion

        #region Propieties

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        #endregion

        #region Methods

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }

        /// <summary>
        /// Escribir reducirá la mina en 0.1 por cada carácter escrito.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            float mina = this.UnidadesDeEscritura - (texto.Length * 0.1f);
            if (mina > 0)
                this.UnidadesDeEscritura = mina;
            else
                this.UnidadesDeEscritura = 0;
            EscrituraWrapper e = new EscrituraWrapper(texto, this.Color);
            return e;
        }

        /// <summary>
        /// Recargar lanzará NotImplementedException.
        /// </summary>
        /// <param name="unidades"></param>
        /// <returns></returns>
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format($"Lapiz - Tamanio Mina: {this.UnidadesDeEscritura} - Color: {this.Color}");
        }

        #endregion
    }
}
