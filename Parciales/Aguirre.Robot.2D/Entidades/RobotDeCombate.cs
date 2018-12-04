using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RobotDeCombate : Robot
    {
        #region Fields

        private int caballosDeFuerza;
        private bool lucho;

        #endregion

        #region Propieties

        public int CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
        }

        public bool Lucho
        {
            get
            {
                return this.lucho;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Constructor de instancia que no recibe parámetros y inicializa el atributo lucho en false;
        /// </summary>
        public RobotDeCombate()
            : base()
        {
            this.lucho = false;
        }

        /// <summary>
        /// Constructor de instancia que recibe energía y origen, y recibe los mismos parámetros. Pero este
        /// inicializa caballosDeFuerza en 10 y lucho en false;
        /// </summary>
        /// <param name="energia"></param>
        /// <param name="origen"></param>
        public RobotDeCombate(int energia, string origen)
            : this(energia, origen, 10)
        {

        }

        /// <summary>
        /// Constructor de instancia que agrega el parámetro caballosDeFuerza.
        /// </summary>
        /// <param name="energia"></param>
        /// <param name="origen"></param>
        /// <param name="caballosDeFuerza"></param>
        public RobotDeCombate(int energia, string origen, int caballosDeFuerza)
            : base(energia, origen)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        /// <summary>
        /// El método ServirHumanidad, en caso de que tenga energía, descontará en uno la misma, y retornará un
        /// mensaje "Robot De combate [codigo] - Disparando misiles..." caso contrario retornará "Robot De
        /// combate[codigo] - Sin energía".
        /// </summary>
        /// <returns></returns>
        public override string ServirHumanidad()
        {
            string retorno = "";
            if(this.Energia > 0)
            {
                this.energia -= 1;
                retorno =  string.Format($"Robot de combate {this.Codigo} - Disparando misiles...");
            }
            else
                retorno = string.Format($"Robot de combate {this.Codigo} - Sin energia");
            return retorno;
        }

        #endregion

    }
}
