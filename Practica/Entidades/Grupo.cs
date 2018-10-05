using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Fields

        private List<Mascota> manada;
        private string nombre;
        TipoManada tipo;

        #endregion

        #region Propieties
        /*
        public int MyProperty
        {
            get;
            {

            }
            set;
            {

            }
        }

        public int MyProperty
        {
            get;
            {

            }
            set;
            {

            }
        }
       
        public int MyProperty
        {
            get;
            {

            }
            set;
            {

            }
        }
         */
        #endregion

        #region Methods

        private Grupo()
        {
            this.manada = new List<Mascota>();
            this.tipo = TipoManada.Unica;
        }

        public Grupo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            :this(nombre)
        {
            this.tipo = tipo;
        }


        #endregion

        #region Nested Types



        #endregion
    }
}
