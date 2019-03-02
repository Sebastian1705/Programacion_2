using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        #region Fields

        protected int cantidadPatas;
        protected static Random distanciaRecorrida;
        protected int velocidadMaxima;

        #endregion

        #region Propieties

        public int CantidadPatas
        {
            get
            {
                return this.cantidadPatas;
            }
            set
            {
                if (value != 2 || value != 4)
                    this.cantidadPatas = 4;
                else
                    this.cantidadPatas = value;
            }
        }

        public int DistanciaRecorrida
        {
            get
            {
                return distanciaRecorrida.Next(10,this.VelocidadMaxima);
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this.velocidadMaxima;
            }
            set
            {
                if (value < 0 || value > 60)
                    this.velocidadMaxima = 60;
                else
                    this.velocidadMaxima = value;
            }
        }

        #endregion

        #region Methods

        static Animal()
        {
            distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima)
        {
            this.VelocidadMaxima = velocidadMaxima;
            this.CantidadPatas = cantidadPatas;
        }

        public string MostrarDAtos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de patas: {this.CantidadPatas}");
            sb.AppendLine($"Velecidad maxima: {this.VelocidadMaxima}");
            sb.AppendLine($"Distancia recorrida: {this.DistanciaRecorrida}");
            return sb.ToString();
        }

        #endregion
    }
}
