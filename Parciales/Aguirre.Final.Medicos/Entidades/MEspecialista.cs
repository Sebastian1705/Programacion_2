using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        #region Fields

        private Especialidad especialidad;

        #endregion

        #region Methods

        public MEspecialista(string nombre, string apellido, Especialidad especialidad)
           : base(nombre, apellido)
        {
            this.especialidad = especialidad;
        }

        /// <summary>
        /// El método Atender hará un Sleep de un tiempo aleatorio (de entre 5000 y 10000 para MEspecialista y
        /// de entre 1500 y 2200 para MGeneral). Luego avisará que finalizó la atención.
        /// </summary>
        protected override void Atender()
        {
            Thread.Sleep(tiempoAleatorio.Next(5000, 10000));
            this.FinalizarAtencion();
        }

        /// <summary>
        /// El método IniciarAtencion será el encargado de crear y lanzar un hilo dónde se ejecutará el método Atender.
        /// </summary>
        public void IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread t = new Thread(this.Atender);
            t.Start();
        }

        #endregion

        #region Nested Types

        public enum Especialidad
        {
            Traumatologo, Odontologo
        }

        #endregion
    }
}
