using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo : IAcciones
    {
        #region Fields

        private ConsoleColor colorTinta;
        private float tinta;

        #endregion

        #region Propieties

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        /// <summary>
        /// UnidadesDeEscritura retonará tinta
        /// </summary>
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        #endregion

        #region Methods

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }

        /// <summary>
        /// Escribir reducirá la tinta en 0.3 por cada carácter escrito.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public EscrituraWrapper Escribir(string texto)
        {
            float tinta = this.UnidadesDeEscritura - (texto.Length * 0.3f);
            if (tinta > 0)
                this.UnidadesDeEscritura = tinta;
            else
                this.UnidadesDeEscritura = 0;
            EscrituraWrapper e = new EscrituraWrapper(texto, this.Color);
            return e;
        }

        /// <summary>
        /// Recargar incrementará tinta en tantas unidades como se agreguen.
        /// </summary>
        /// <param name="unidades"></param>
        /// <returns></returns>
        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        /// <summary>
        /// el método ToString retornará un texto informando que es (Lapiz o
        /// Boligrafo), color de escritura y nivel de tinta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format($"Boligrafo - Nivel de tinta: {this.UnidadesDeEscritura} - Color: {this.Color}");
        }

        #endregion
    }
}
