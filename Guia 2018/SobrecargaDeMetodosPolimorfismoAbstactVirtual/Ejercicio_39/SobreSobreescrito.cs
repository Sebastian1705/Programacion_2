using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    public class SobreSobreescrito : Sobreescrito
    {
        #region Methods

        public SobreSobreescrito()
            : base()
        {

        }

        public override string MiMetodo()
        {
            return this.MiAtributo;
        }

        #endregion
    }
}
