using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Oficina
    {
        #region FIELDS

        private Persona.Departamentos departamento;
        private List<Empleado> empleados;
        private Jefe jefe;
        private short piso;
        
        #endregion

        #region PROPIEDADES

        //public string PisoDivision 
        //{
        //    get 
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        sb.AppendFormat("{0}ª{1}",Empleado.PisoDepartamento );
        //        sb.AppendLine("");


        //        return sb.ToString(); 
        //    }
        //}

        #endregion

        #region METODOS


        private Oficina()
        {
            empleados = new List<Empleado>();
        }

        public static explicit operator string(Oficina o)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empleado aux in o.empleados)
            {
                sb.AppendFormat("{0}", aux.ExponerDatos());
                sb.AppendLine("");
            }
            return sb.ToString();
        }

        public Oficina (short piso, Persona.Departamentos departamento, Jefe jefe)
        {
            this.piso = piso;
            this.departamento = departamento;
            this.jefe = jefe;
        }

        public static bool operator ==(Oficina o, Empleado e)
        {
            bool ans= false;

            foreach (Empleado aux in o.empleados)
            {
                if (object.Equals(aux, e))
                {
                    ans = true;
                }
            }

            return ans;
        }

        public static bool operator !=(Oficina o, Empleado e)
        {
            bool ans= false;

            if (!(o == e))
                ans = true;

            return ans;
        }

        public static Oficina operator +(Oficina o, Empleado e)
        {
            
            if (o == e)
            {
                return o;
            }

            o.empleados.Add(e);
            
            return o;
        }


        #endregion
    }
}
