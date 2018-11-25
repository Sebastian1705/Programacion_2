using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class MGeneral : Medico
    {
        #region Methods

        public MGeneral(string nombre, string apellido)
            : base(nombre, apellido)
        {

        }

        protected override void Atender()
        {
            throw new NotImplementedException();
        }

        public void IniciarAtencio(Paciente p)
        {

        }

        #endregion
    }
}
