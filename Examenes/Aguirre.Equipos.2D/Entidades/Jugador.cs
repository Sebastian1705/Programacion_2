using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Campos

        private float altura;
        private float peso;
        private Posicion posicion;

        #endregion

        #region Propiedades

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        #endregion

        #region Metodos

        public Jugador(string nombre, string apellido, int edad, int dni,  float peso, float altura, Posicion posicion)
            :base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
            sb.AppendLine($"Peso: {this.Peso}");
            sb.AppendLine($"Atura: {this.Altura}");
            sb.AppendLine($"Posicion: {this.Posicion}");
            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            double imc = (this.Peso / (Math.Pow(this.Altura, 2)));
            if(imc >= 18 && imc <= 25)
            {
                retorno = true;
            }
            return retorno;
        }

        public override bool ValidarAptitud()
        {
            if(this.ValidarEstadoFisico() && this.Edad <= 40)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
