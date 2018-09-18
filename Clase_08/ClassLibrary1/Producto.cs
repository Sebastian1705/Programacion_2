using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneda;

namespace ClassLibrary1
{
    public class Producto
    {
        private int identificador;
        private string nombre;
        private double precio;
        private double iva;
        private int cantidad = 1;

        public Producto(int identificador, string nombre, double precio)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.iva = precio;
        }

        public int Identificador
        {
            set
            {
                this.identificador = value;
            }
            get
            {
                return this.identificador;
            }
        }

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public double Precio
        {
            set
            {
                this.precio = value * .21;
            }
            get
            {
                return this.precio;
            }
        }

        public int Cantidad
        {
            set
            {
                this.cantidad = value;
            }
            get
            {
                return this.cantidad;
            }
        }
    }
}
