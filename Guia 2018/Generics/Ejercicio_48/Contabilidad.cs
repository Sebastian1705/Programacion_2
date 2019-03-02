using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    /*a. Crear un constructor que no reciba parámetros en Contabilidad para inicializar las listas.
    b. El constructor sin parámetros de Recibo asignará 0 como número de documento.
    c. Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
    d. El tipo U deberá tener una restricción que indique que deberá tener un constructor por
    defecto (sin argumentos).
    e. El operador + entre Contabilidad y T agregá un elemento a la lista egresos.
    f. El operador + entre Contabilidad y U agregá un elemento a la lista ingresos.
    g. Generar el código necesario para probar dichas clases.*/
    public class Contabilidad<T, U> where T : Documento where U : Documento, new()
    {
        #region Fields

        private List<T> egresos;
        private List<U> ingresos;

        #endregion

        #region Methods

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
            
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ingresos");
            foreach (U item in this.ingresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }
            sb.AppendLine("Egresos");
            foreach (T item in this.egresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }
            return sb.ToString();
        }

        #endregion
    }
}
