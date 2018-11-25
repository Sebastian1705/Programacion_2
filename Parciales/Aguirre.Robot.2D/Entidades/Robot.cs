using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Robot
    {
        #region Fields

        protected static int capacidadEnergia;
        private int codigo;
        private static int contador;
        protected int energia;
        protected string origen;

        #endregion

        #region Propieties

        public static int CapacidadEnergia
        {
            get
            {
                return capacidadEnergia;
            }
        }

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        public int Energia
        {
            get
            {
                return this.energia;
            }
        }

        #endregion

        #region Methods

        static Robot()
        {
            capacidadEnergia = 50;
            contador = 0;
        }

        protected Robot()
        {
            this.origen = "coreano";
            this.energia = 10;
            contador += 1;
            codigo = contador;
        }

        public Robot(int energia, string origen)
        {
            this.energia = energia;
            this.origen = origen;
        }

        public virtual bool CargarEnergia(int energia)
        {
            bool retorno = false;
            if(energia > 0 && energia < CapacidadEnergia)
            {
                this.energia = energia;
                retorno = true;
            }
            return retorno;
        }

        public abstract string ServirHumanidad();

        public static bool operator ==(Robot robot1, Robot robot2)
        {
            bool retorno = false;
            if(!(robot1 is null) &&!(robot2 is null))
            {
                if(robot1.Codigo == robot2.Codigo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Robot robot1, Robot robot2)
        {
            return !(robot1 == robot2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad: {CapacidadEnergia}");
            sb.AppendLine($"Codigo: {this.Codigo}");
            sb.AppendLine($"Contador: {contador}");
            sb.AppendLine($"Energia: {this.Energia}");
            sb.AppendLine($"Origen: {this.origen}");
            return sb.ToString();
        }

        #endregion
    }
}
