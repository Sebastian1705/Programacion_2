using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class PrestamoDolar : Prestamo
    {
        #region Fields

        private PeriodicidadDePagos periodicidad;

        #endregion

        #region Propieties

        public float Interes
        {
            get
            {
                return this.CalcularIntereses();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        #endregion

        #region Methos

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = (nuevoVencimiento - this.Vencimiento).Days;
            if(dias > 0)
            {
                this.Vencimiento = nuevoVencimiento;
                this.monto += (dias * 2.5f);
            }  
        }

        private float CalcularIntereses()
        {
            float interes = 0;
            switch (this.Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    interes = this.Monto * 25 / 100;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    interes = this.Monto * 35 / 100;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    interes = this.Monto * 40 / 100;
                    break;
            }
            return interes;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.Mostrar()}\tPeriodicidad: {this.Periodicidad}\t\t\tIntereses: {this.Interes}");
            return sb.ToString();
        }

        #endregion
    }
}
