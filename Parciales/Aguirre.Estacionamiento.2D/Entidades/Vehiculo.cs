using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region Fields

        private string patente;
        protected DateTime ingreso;

        #endregion

        #region Propieties
        
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        #endregion

        #region Fields

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.Patente == v2.Patente && v1.GetType() == v2.GetType())
                    retorno =  true;
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.ToString()}\tIngreso: {this.ingreso.ToString()}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return String.Format($"Patente: {Patente}");
        }

        private bool ValidarPatente(string aux)
        {
            // Valido tamaño
            if (aux.Length == 6)
                return true;
            return false;
        }

        #endregion
    }
}
