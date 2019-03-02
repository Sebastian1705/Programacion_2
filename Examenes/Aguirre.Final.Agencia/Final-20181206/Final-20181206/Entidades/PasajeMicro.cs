using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*e. Clase PasajeMicro:
    i. Mostrar agregará los datos propios.
    ii. La propiedad PrecioFinal retornará el precio aplicando un aumento del 10% para tipo de
    servicio SemiCama y 20% para Ejecutivo.*/
    public class PasajeMicro : Pasaje
    {
        #region Fields

        private Servicio tipoServicio;

        #endregion

        #region Propieties

        public Servicio TipoServicio
        {
            get => tipoServicio;
            set
            {
                this.tipoServicio = value;
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

        public PasajeMicro()
        {

        }

        public PasajeMicro(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha, Servicio tipo)
            : base(origen, destino, pasajero, precio, fecha)
        {
            this.tipoServicio = tipo;
        }

        public override string Mostrar()
        {
            return string.Format($"{base.Mostrar()} - SERVICIO: {this.TipoServicio}");
        }

        public float CalcularPrecio()
        {
            float retorno = 0;
            switch(this.TipoServicio)
            {
                case Servicio.Semicama:
                    retorno = this.precio + this.Precio *0.1f;
                    break;
                case Servicio.Ejecutivo:
                    retorno = this.precio + this.Precio * 0.2f;
                    break;
                default:
                    retorno = this.precio;
                    break;
            }
            return retorno;
        }

        #endregion
    }
}
