using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        #region Fields

        private int turno;
        private static int ultimoTurnoDado;

        #endregion

        #region Propieties

        public int Turno
        {
            get
            {
                return this.turno;
            }
        }

        #endregion

        #region Methods

        static Paciente()
        {
            ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido)
            : base(nombre, apellido)
        {
            this.turno = ultimoTurnoDado + 1;
        }

        public Paciente(string nombre, string apellido, int turno)
            : this(nombre, apellido)
        {
            ultimoTurnoDado = turno;
        }

        public override string ToString()
        {
            return String.Format($"TurnoNº: {this.turno} {this.apellido}, {this.nombre}");
        }

        #endregion
    }
}
