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
        /// <summary>
        /// Tiene un constructor de instancia que no recibe parámetros
        /// </summary>
        public RobotSirviente()
            : base()
        {

        }

        /// <summary>
        /// Tiene un constructor de instancia que recibe energía y origen.
        /// </summary>
        /// <param name="energia"></param>
        /// <param name="origen"></param>
        public RobotSirviente(int energia, string origen)
            : base(energia, origen)
        {

        }

        /// <summary>
        /// Método público CargarEnergia (que sobrescriba el método de robot) que recibirá una cantidad de
        /// energía y sólo cargará energía si la misma está en cero.
        /// </summary>
        /// <param name="energia"></param>
        /// <returns></returns>
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

        /// <summary>
        /// ServirHumanidad, en caso de tener energía, descontará en uno la misma, retornará un mensaje con el
        /// código y el mensaje "Haciendo masajes..."; caso contrario el código y "Sin energía..." .
        /// </summary>
        /// <returns></returns>
        public override string ServirHumanidad()
        {
            string retorno = "";
            if(this.Energia > 0)
            {
                this.energia -= 1;
                retorno = string.Format($"{this.Codigo} Haciendo masajes...");
            }
            else
                retorno = string.Format($"{this.Codigo} Sin energía...");
            return retorno;
        }

        #endregion
    }
}
