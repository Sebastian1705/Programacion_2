using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*c. Clase Pasaje
    i. Sólo final: ​La propiedad PrecioFinal no tendrá implementación dentro de Pasaje.
    ii. Mostrar tendrá implementación y podrá ser sobrescrito en las clases hijas. Deberá mostrar
    todos los datos de la clase donde se lo implemente.
    iii. Sólo final: ​Sobrecargar el operador == entre 2 pasajes los cuales serán iguales sólo si tienen
    el mismo origen, destino, dni del pasajero y fecha.*/
    public abstract class Pasaje
    {
        #region Fields

        public Pasajero pasajero;
        public string origen;
        public string destino;
        public float precio;
        public DateTime fecha;

        #endregion

        #region Propieties

        public Pasajero PasajeroProp
        {
            get
            {
                return this.pasajero;
            }
            set
            {
                this.pasajero = value;
            }
        }

        public string Origen
        {
            get
            {
                return this.origen;
            }
            set
            {
                this.origen = value;
            }
        }

        public string Destino
        {
            get
            {
                return this.destino;
            }
            set
            {
                this.destino = value;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public abstract float PrecioFinal { get; }

        #endregion

        #region Methods

        public Pasaje()
        {

        }

        public Pasaje(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha)
        {
            this.Origen = origen;
            this.Destino = destino;
            this.PasajeroProp = pasajero;
            this.Precio = precio;
            this.Fecha = fecha;
        }

        public virtual string Mostrar()
        {
            return string.Format(   $"ORIGEN: {this.Origen} - DESTINO: {this.Destino} - PASAJERO: {this.PasajeroProp} - " +
                                    $"PRECIO: {this.Precio} - FECHA: {this.Fecha}");
        }

        public static bool operator ==(Pasaje a, Pasaje b)
        {
            if (a.Origen == b.Origen && a.Destino == b.Destino && a.Fecha == b.Fecha && a.PasajeroProp.Dni == b.PasajeroProp.Dni)
                return true;
            return false;
        }

        public static bool operator !=(Pasaje a, Pasaje b)
        {
            return !(a == b);
        }

        #endregion

    }
}
