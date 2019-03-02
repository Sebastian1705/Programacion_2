using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arena
    {
        public int espacioDisponible;
        public string nombre;
        public List<RobotDeCombate> robotsDeCombate;
        public List<RobotSirviente> robotsSirvientes;

        private Arena()
        {
            this.robotsDeCombate = new List<RobotDeCombate>();
            this.robotsSirvientes = new List<RobotSirviente>();
        }

        public Arena(string nombre, int espacioDisponible)
            : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        /// <summary>
        /// El operador == recibe una Arena y un Robot, retorna true si la Arena contiene al robot en alguna de sus
        /// dos lisas.
        /// </summary>
        /// <param name="arena"></param>
        /// <param name="robot"></param>
        /// <returns></returns>
        public static bool operator ==(Arena arena, Robot robot)
        {
            bool retorno = false;
            if (!(arena is null) && !(robot is null))
            {
                foreach (Robot item in arena.robotsDeCombate)
                {
                    if (item == robot)
                    {
                        retorno = true;
                        break;
                    }
                }
                foreach (Robot item in arena.robotsSirvientes)
                {
                    if (item == robot)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Arena arena, Robot robot)
        {
            return !(arena == robot);
        }

        /// <summary>
        /// El operador + recibe una Arena y un Robot y agrega al Robot (Combate o Sirviente) en la lista que
        /// corresponda(Sirviente o Combate) en caso de que no se encuentre en su lista.
        /// </summary>
        /// <param name="arena"></param>
        /// <param name="robot"></param>
        /// <returns></returns>
        public static Arena operator +(Arena arena, Robot robot)
        {
            if(!(arena is null) && !(robot is null))
            {
                if(arena != robot && robot is RobotDeCombate)
                    arena.robotsDeCombate.Add((RobotDeCombate)robot);
                else if(arena != robot && robot is RobotSirviente)
                    arena.robotsSirvientes.Add((RobotSirviente)robot);
            }
            return arena;
        }

        /// <summary>
        /// El operador - recibe una Arena y un Robot y retira al Robot en caso de que se encuentre en alguna de las
        /// dos listas.
        /// </summary>
        /// <param name="arena"></param>
        /// <param name="robot"></param>
        /// <returns></returns>
        public static Arena operator -(Arena arena, Robot robot)
        {
            if (!(arena is null) && !(robot is null))
            {
                if (arena == robot && robot is RobotDeCombate)
                    arena.robotsDeCombate.Remove((RobotDeCombate)robot);
                else if (arena == robot && robot is RobotSirviente)
                    arena.robotsSirvientes.Remove((RobotSirviente)robot);
            }
            return arena;
        }

        /// <summary>
        /// implicit retorna un string con el nombre de la Arena y una lista de Robots de combates y otra de robots
        /// sirvientes.
        /// </summary>
        /// <param name="arena"></param>
        public static implicit operator string(Arena arena)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Arena: {arena.nombre}");
            sb.AppendLine("Robots de combate:");
            foreach(RobotDeCombate item in arena.robotsDeCombate)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Robots sirvientes:");
            foreach (RobotSirviente item in arena.robotsSirvientes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Combate en caso de que no sea null y que tenga energía:
        /// busca el primer robotDeCombate de la lista(con energía) para combatir con el mismo.
        /// Ambos usan el método ServirHumanidad, armando un string con la información de ambos y
        /// declarando como ganador al que tiene más caballos de fuerza.
        /// En caso de que sean iguales, debe retornar la información de ambos y declarar un empate.
        /// Si no pudieron combatir debe retornar “No se encontró oponente”.
        /// </summary>
        /// <param name="combatiente"></param>
        /// <returns></returns>
        public string Combate(RobotDeCombate combatiente)
        {
            StringBuilder sb = new StringBuilder();
            if (!(combatiente is null) && combatiente.Energia > 0)
            {
                RobotDeCombate auxiliar = null;
                foreach(RobotDeCombate item in this.robotsDeCombate)
                {
                    if(item.Energia > 0)
                    {
                        auxiliar = item;
                        break;
                    }
                }
                if (!(auxiliar is null))
                {
                    sb.AppendLine(auxiliar.ServirHumanidad());
                    sb.AppendLine(combatiente.ServirHumanidad());
                    if (auxiliar.CaballosDeFuerza == combatiente.CaballosDeFuerza)
                        sb.AppendLine("Hubo un empate");
                    else if (auxiliar.CaballosDeFuerza > combatiente.CaballosDeFuerza)
                        sb.AppendLine($"Ganadaor Robot: {auxiliar.ToString()}");
                    else
                        sb.AppendLine($"Ganadaor Robot: {combatiente.ToString()}");
                }
                else
                    sb.AppendLine("No se encontró oponente");
            }
            return sb.ToString();
        }

        /// <summary>
        /// ServirEspectadores buscará el primer robotSirviente que tenga energía y utilizará el método
        /// ServirHumanidad.Sino retornará un vacio(“”).
        /// </summary>
        /// <returns></returns>
        public string ServirEspectadores()
        {
            string retorno = "";
            foreach(RobotSirviente item in this.robotsSirvientes)
            {
                if(item.Energia > 0)
                {
                    retorno = item.ServirHumanidad();
                    break;
                }
            }
            return retorno; ;
        }

        /// <summary>
        /// ToString() retorna un string con el nombre de la Arena y una lista de Robots de combates y otra de
        /// robots sirvientes, mostrando la información de su método ServirHumanidad().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Arena: {this.nombre}");
            sb.AppendLine("Robots de combate:");
            foreach (RobotDeCombate item in this.robotsDeCombate)
            {
                sb.AppendLine(item.ServirHumanidad());
            }
            sb.AppendLine("Robots sirvientes:");
            foreach (RobotSirviente item in this.robotsSirvientes)
            {
                sb.AppendLine(item.ServirHumanidad());
            }
            return sb.ToString();
        }
    }
}
