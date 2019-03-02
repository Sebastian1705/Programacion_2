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

        /// <summary>
        /// ultimoTurnoDado será de clase y privado. Se inicializará en el constructor, también de clase, con el valor 0.
        /// </summary>
        static Paciente()
        {
            ultimoTurnoDado = 0;
        }

        /// <summary>
        /// El constructor Paciente(string, string) incrementará el valor de ultimoTurnoDado en 1 y se lo asignará al turno.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Paciente(string nombre, string apellido)
            : base(nombre, apellido)
        {
            this.turno = ultimoTurnoDado + 1;
        }

        /// <summary>
        /// El constructor Paciente(string, string, int) asignará los valores a cada atributo, modificando también
        /// ultimoTurnoDado por el valor recibido.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="turno"></param>
        public Paciente(string nombre, string apellido, int turno)
            : this(nombre, apellido)
        {
            ultimoTurnoDado = turno;
        }

        /// <summary>
        /// ToString() retornará los datos del paciente con el siguiente formato "Turno Nº{0}: {2}, {1}", siendo
        /// los valores número de turno, apellido y nombre respectivamente.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format($"TurnoNº: {this.turno} {this.apellido}, {this.nombre}");
        }

        #endregion
    }
}
