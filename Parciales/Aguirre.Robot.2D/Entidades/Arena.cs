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

        public static Arena operator +(Arena arena, Robot robot)
        {
            if(!(arena is null) && !(robot is null))
            {
                if(arena != robot)
                {
                    if(robot is RobotDeCombate)
                    {
                        arena.robotsDeCombate.Add((RobotDeCombate)robot);
                    }
                    else if(robot is RobotSirviente)
                    {
                        arena.robotsSirvientes.Add((RobotSirviente)robot);
                    }
                }
            }
            return arena;
        }

        public static Arena operator -(Arena arena, Robot robot)
        {
            if (!(arena is null) && !(robot is null))
            {
                if (arena == robot)
                {
                    if (robot is RobotDeCombate)
                    {
                        arena.robotsDeCombate.Remove((RobotDeCombate)robot);
                    }
                    else if (robot is RobotSirviente)
                    {
                        arena.robotsSirvientes.Remove((RobotSirviente)robot);
                    }
                }
            }
            return arena;
        }

        public static implicit operator string(Arena arena)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Arena: {arena.nombre}");
            sb.AppendLine("Robots de combate:");
            foreach(RobotDeCombate item in arena.robotsDeCombate)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Robots de sirvientes:");
            foreach (RobotDeCombate item in arena.robotsDeCombate)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string Combate(RobotDeCombate combatiente)
        {
            StringBuilder sb = new StringBuilder();

            if(!(combatiente is null) && combatiente.Energia > 0)
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
                sb.AppendLine(auxiliar.ServirHumanidad());
                sb.AppendLine(combatiente.ServirHumanidad());
                if (auxiliar.CAballosDeFuerza == combatiente.CAballosDeFuerza)
                    sb.AppendLine("Hubo un empate");
                else if(auxiliar.CAballosDeFuerza > combatiente.CAballosDeFuerza)
                    sb.AppendLine($"Ganadaor Robot: {auxiliar.ToString()}");
                else
                    sb.AppendLine($"Ganadaor Robot: {combatiente.ToString()}");
            }
            else
            {
                sb.AppendLine("No se encontro oponente");
            }
            return sb.ToString();
        }

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

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Arena: {this.nombre}");
            sb.AppendLine("Robots de combate:");
            foreach (RobotDeCombate item in this.robotsDeCombate)
            {
                sb.AppendLine(item.ServirHumanidad());
            }
            sb.AppendLine("Robots de sirvientes:");
            foreach (RobotDeCombate item in this.robotsDeCombate)
            {
                sb.AppendLine(item.ServirHumanidad());
            }
            return sb.ToString();
        }
    }
}
