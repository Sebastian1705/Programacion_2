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

        public int CAballosDeFuerza
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

        public RobotDeCombate()
            : base()
        {
            this.lucho = false;
        }

        public RobotDeCombate(int energia, string origen)
            : this(energia, origen, 10)
        {

        }

        public RobotDeCombate(int energia, string origen, int caballosDeFuerza)
            : base(energia, origen)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public override string ServirHumanidad()
        {
            if(this.Energia > 1)
            {
                this.energia = this.Energia - 1;
                return String.Format($"Robot de combate {this.Codigo} disparando misiles...");
            }
            else
            {
                return String.Format($"Robot de combate {this.Codigo} - Sin energia");
            }
        }

        #endregion

    }
}
