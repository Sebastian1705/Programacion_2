using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        #region Fields

        private ConsoleColor color;
        private static int valorHora;

        #endregion

        #region Methods

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valor)
            : this(patente, color)
        {
            
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ToString()}\tColor: {this.color}");
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
            return (obj is Automovil);
        }

        #endregion

    }
}
