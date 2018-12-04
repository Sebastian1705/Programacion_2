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

        /// <summary>
        /// Constructor de clase que cargará los atributos estáticos de capacidadEnergía en 50 y contador en 0.
        /// </summary>
        static Robot()
        {
            capacidadEnergia = 50;
            contador = 0;
        }

        /// <summary>
        /// Constructor de instancia sin parámetros que cargará origen como "Coreano", energía en 10 y
        /// aumentará en 1 al contador y le asignará dicho valor al atributo codigo. (El código es único e irrepetible para cada robot).
        /// </summary>
        protected Robot()
        {
            this.origen = "Coreano";
            this.energia = 10;
            contador += 1;
            codigo = contador;
        }

        /// <summary>
        /// Constructor de instancia que recibirá dos parámetros: energía y origen.
        /// </summary>
        /// <param name="energia"></param>
        /// <param name="origen"></param>
        public Robot(int energia, string origen)
        {
            this.energia = energia;
            this.origen = origen;
        }

        /// <summary>
        /// Método público virtual CargarEnergia que recibirá una cantidad de energía y validará que sea mayor a
        /// cero y menor a la capacidadEnergia y lo asignará.Si puede asignarlo, retornará true.
        /// </summary>
        /// <param name="energia"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método abstracto ServirHumanidad que no recibe parámetros y retorna un booleano.
        /// </summary>
        /// <returns></returns>
        public abstract string ServirHumanidad();

        /// <summary>
        /// Sobrecarga del operador == comparará dos robots por el atributo codigo. 
        /// </summary>
        /// <param name="robot1"></param>
        /// <param name="robot2"></param>
        /// <returns></returns>
        public static bool operator ==(Robot robot1, Robot robot2)
        {
            bool retorno = false;
            if(!(robot1 is null) && !(robot2 is null) && robot1.Codigo == robot2.Codigo)
                retorno = true;
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
