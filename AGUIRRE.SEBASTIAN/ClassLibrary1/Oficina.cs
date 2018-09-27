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

        private Departamentos departamento;
        private List<Empleado> empleados;
        private Jefe jefe;
        private short piso;

        #endregion

        #region Propieties

        public string PisoDivision
        {
            get;
        }

        #endregion

        #region Methods

        private Oficina()
        {
            empleados = new List<Empleado>();
        }

        public Oficina(short piso, Departamentos departamento, Jefe jefe)
            : this()
        {
            this.piso = piso;
            this.departamento = departamento;
            this.jefe = jefe;
        }

        public static bool operator ==(Oficina o, Empleado e)
        {
            bool retorno = false;
            
            
            return retorno;
        }

        public static bool operator !=(Oficina o, Empleado e)
        {
            return !(o == e);
        }

        #endregion

    }
}
