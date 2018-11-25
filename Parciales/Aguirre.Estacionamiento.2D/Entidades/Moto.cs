using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Fields

        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        #endregion

        #region Methods

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada)
            : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas)
            : this(patente, cilindrada)
        {
            
        }

        public Moto(string patente, int cilindrada, short ruedas, int valor)
            : this(patente, cilindrada, ruedas)
        {
            
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ToString()}\tCilindrada: {this.cilindrada}\tRuedas: {this.ruedas}");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            double costo = ((DateTime.Now - this.ingreso).TotalHours * valorHora);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ImprimirTicket()}\tCosto: {costo}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Moto);
        }

        #endregion
    }
}
