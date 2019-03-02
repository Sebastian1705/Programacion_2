using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Prestamo
    {
        #region Fields

        protected float monto;
        protected DateTime vencimiento;

        #endregion

        #region Propieties

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
               if(DateTime.Today < value.Date)
               {
                    this.vencimiento = value;
               }
               else
               {
                    this.vencimiento = DateTime.Now;
               }
            }
        }

        #endregion

        #region Methods

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return (p1.Vencimiento.CompareTo(p2.Vencimiento));
        }

        public abstract void ExtenderPlazo(DateTime vencimiento);
        
        public virtual string Mostrar()
        {
            return String.Format($"Monto: {this.Monto}\tVencimiento: {this.Vencimiento}");
        }

        #endregion
    }
}
