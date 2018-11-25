using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        #region Fields

        private string modelo;
        private static int valorHora;

        #endregion

        #region Methods


        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valor)
            : this(patente, modelo)
        {
            
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ToString()}\tModelo: {this.modelo}");
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
            return (obj is PickUp);
        }

        #endregion
    }
}
