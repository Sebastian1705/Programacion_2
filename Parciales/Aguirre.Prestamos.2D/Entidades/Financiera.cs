using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Financiera
    {
        #region Fields

        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        #endregion

        #region Propieties

        public float InteresesEnDolares
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        #endregion

        #region Methods

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }

        public static bool operator ==(Financiera f, Prestamo p)
        {
            bool retorno = false;
            foreach(Prestamo item in f.ListaDePrestamos)
            {
                if(item == p)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Financiera f, Prestamo p)
        {
            return !(f == p);
        }

        public static Financiera operator +(Financiera f, Prestamo pNuevo)
        {
            if(f != pNuevo)
            {
                f.listaDePrestamos.Add(pNuevo);
            }
            return f;
        }

        public static explicit operator string(Financiera f)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {f.RazonSocial}");
            sb.AppendLine("Intereses:");
            sb.AppendFormat($"Totales: {f.InteresesTotales}\tPesos: {f.InteresesEnPesos}\tDolares: {f.InteresesEnDolares}\t");
            f.OrdenarPrestamos();
            foreach (Prestamo item in f.ListaDePrestamos)
            {
                sb.AppendLine(item.Mostrar());
            }
            sb.AppendLine("-----------------------------");
            return sb.ToString();
        }

        public static string Mostrar(Financiera f)
        {
            return (string)f;
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoDePrestamo)
        {
            float retorno = 0, acumPesos = 0, acumDolar = 0;
            foreach(Prestamo item in this.ListaDePrestamos)
            {
                if(item is PrestamoPesos)
                {
                    acumPesos += ((PrestamoPesos)item).Interes;
                }
                else if(item is PrestamoDolar)
                {
                    acumDolar += ((PrestamoDolar)item).Interes;
                }
            }
            switch(tipoDePrestamo)
            {
                case TipoDePrestamo.Dolares:
                    break;
                case TipoDePrestamo.Pesos:
                    break;
                case TipoDePrestamo.Todos:
                    break;
            }
            return retorno;
        }

        #endregion
    }
}
