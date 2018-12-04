using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        #region Fields

        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;

        #endregion

        #region Propieties

        /// <summary>
        /// La propiedad AtenderA será de sólo escritura, asignando el valor al atributo pacienteActual.
        /// </summary>
        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }

        /// <summary>
        /// La propiedad EstaAtendiendoA será de sólo lectura y virtual, retornando los datos del pacienteActual.
        /// </summary>
        public virtual string EstaAtendiendoA
        {
            get
            {
                return this.pacienteActual.ToString();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// El constructor de clase instanciará a tiempoAleatorio. El atributo tendrá visibilidad de protegido.
        /// </summary>
        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido)
            : base(nombre, apellido)
        {

        }

        /// <summary>
        /// Atender será protegido y abstracto.
        /// </summary>
        protected abstract void Atender();

        /// <summary>
        /// El método FinalizarAtencion lanzará el evento AtencionFinalizada y luego asignará null al paciente actual
        /// </summary>
        protected void FinalizarAtencion()
        {
            this.AtencionFinalizada.Invoke(this.pacienteActual, this);
            this.pacienteActual = null;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        #endregion

        #region Delegate

        public delegate void FinAtencionPaciente(Paciente p, Medico m);

        #endregion

        #region Events

        public event FinAtencionPaciente AtencionFinalizada;

        #endregion
    }
}
