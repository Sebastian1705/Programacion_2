using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RobotSirviente : Robot
    {
        #region Methods

        public RobotSirviente()
            : base()
        {

        }

        public RobotSirviente(int energia, string origen)
            : base(energia, origen)
        {

        }

        public override bool CargarEnergia(int energia)
        {
            bool retorno = false;
            if(this.Energia == 0)
            {
                this.energia = energia;
                retorno = true;
            }
            return retorno;
        }

        public override string ServirHumanidad()
        {
            if(this.Energia == 0)
            {
                return String.Format($"Sin energia...");
            }
            this.energia = this.Energia - 1;
            return String.Format($"Haciendo masajes...");
        }

        #endregion
    }
}
