using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*d. Clase PasajeAvion:
    i. Mostrar agregará los datos propios.
    ii. La propiedad PrecioFinal retornará el precio aplicando un descuento del 10% para viajes con
    una escala, 20% con dos escalas y 30% con más de 2 escalas.*/
    public class PasajeAvion : Pasaje
    {
        #region Fields

        private int cantidadEscalas;

        #endregion

        #region Propieties

        public int CantidadEscalas
        {
            get => cantidadEscalas;
            set
            {
                this.cantidadEscalas = value;
            }
        }

        public override float PrecioFinal
        {
            get
            {
                return this.CalcularPrecio();
            }
        }

        #endregion

        #region Methods

        public PasajeAvion()
        {

        }

        public PasajeAvion(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha, int cantidadEscalas)
            : base(origen, destino, pasajero, precio, fecha)
        {
            this.CantidadEscalas = cantidadEscalas;
        }

        public override string Mostrar()
        {
            return string.Format($"{base.Mostrar()} - ESCALAS: {this.CantidadEscalas}");
        }

        public float CalcularPrecio()
        {
            float retorno = 0;
            if(this.CantidadEscalas == 1)
                retorno = this.precio - (this.precio * 0.1f);
            else if(this.CantidadEscalas == 2)
                retorno = this.precio - (this.precio * 0.2f);
            else
                retorno = this.precio - (this.precio * 0.3f);
            return retorno;
        }

        #endregion
    }
}
