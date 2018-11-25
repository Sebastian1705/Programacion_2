using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoPesos : Prestamo
    {
        #region Fields

        private float porcentajeInteres;

        #endregion

        #region Propieties

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        #endregion

        #region Methods

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
            : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }

        private float CalcularInteres()
        {
            return (this.Monto + (this.Monto * this.porcentajeInteres / 100));
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = (nuevoVencimiento - this.Vencimiento).Days;
            if (dias > 0)
            {
                this.Vencimiento = nuevoVencimiento;
                this.porcentajeInteres += (dias * 0.25f);
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.Mostrar()}\tPorcentaje: {this.porcentajeInteres}\t\t\tInteres: {this.Interes}");
            return sb.ToString();
        }

        #endregion
    }
}
