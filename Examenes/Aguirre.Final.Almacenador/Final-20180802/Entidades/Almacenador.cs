using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   //Crear un constructor que reciba y asigne el/los atributos de la misma.
   //La clase debe ser abstracta.
   //Crear un método abstracto llamado MostrarArchivos que retorne void.
    public abstract class Almacenador
    {
        #region Fields

        private int capacidad;

        #endregion

        #region Propieties

        public int Capacidad
        {
            get
            {
                return this.capacidad;
            }
            set
            {
                this.capacidad = value;
            }
        }

        #endregion

        #region Methods

        public Almacenador(int capacidad)
        {
            this.Capacidad = capacidad;
        }

        public abstract void MostrarArchivos();

        #endregion
    }
}
