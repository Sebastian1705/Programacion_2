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

        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }

        public virtual string EstaAtendiendoA
        {
            get
            {
                return String.Format($"{this.pacienteActual.ToString()}");
            }
        }

        #endregion

        #region Methods

        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido)
            : base(nombre, apellido)
        {

        }

        protected abstract void Atender();


        /*protected Persona FinalizarAtencion()
       {
           Persona retorno = pacienteActual;
           pacienteActual = null;
           return retorno;
       }*/

        #endregion
    }
}
