using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Oficina
    {
        #region Fields

        private short piso;
        private Departamentos departamento;
        private Jefe jefe;
        private List<Empleado> empleados;

        #endregion

        #region Propieties

        public string PisoDepartamento
        {
            get
            {
                return String.Format($"{this.piso}º{this.departamento}");
            }
        }


        #endregion

        #region Mothods

        private Oficina()
        {
            this.empleados = new List<Empleado>();
        }

        public Oficina(short anio, Departamentos division, Jefe profesor)
            : this()
        {
            this.piso = anio;
            this.departamento = division;
            this.jefe = profesor;
        }

        public static explicit operator string(Oficina c)
        {
            StringBuilder sb = new StringBuilder();
            if (!(c is null))
            {
                sb.AppendLine($"Oficina {c.PisoDepartamento}");
                sb.AppendLine("");
                sb.AppendLine("Jefe:");
                sb.AppendLine("");
                sb.AppendLine($"{c.jefe.ExponerDatos()}");
                sb.AppendLine("");
                sb.AppendLine("Empleados: ");
                sb.AppendLine("");
                foreach (Empleado item in c.empleados)
                {
                    sb.AppendLine($"{item.ExponerDatos()}");
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Oficina c, Empleado a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                if (c.PisoDepartamento == a.PisoDepartamento)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Oficina c, Empleado a)
        {
            return !(c == a);
        }

        public static Oficina operator +(Oficina c, Empleado a)
        {
            if (c == a)
            {
                c.empleados.Add(a);
            }
            return c;
        }

        #endregion
    }
}
