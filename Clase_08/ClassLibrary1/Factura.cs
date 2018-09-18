using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneda;

namespace ClassLibrary1
{
    class Factura
    {
        private TipoFactura tipo;
        private int numero;
        private DateTime fecha;
        private TipoCambio moneda;
        public List<Producto> productos;

        public Factura()
        {

        }

        public Factura(TipoFactura tipo, DateTime fecha, int numero,TipoCambio moneda)
        {
            this.tipo = tipo;
            this.fecha = fecha;
            this.numero = numero;
            this.moneda = moneda;
            this.productos = new List<Producto>();
        }

        public enum TipoFactura
        {
            A,
            B,
            C
        }

        public enum TipoCambio
        {
            Dolar,
            Peso          
        }

        public TipoFactura Tipo
        {
            set
            {
                this.tipo = value;
            }
            get
            {
                return this.tipo;
            }
        }

        public int Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }

        public DateTime Fecha
        {
            set
            {
                this.fecha = value;
            }
            get
            {
                return this.fecha;
            }
        }

        public TipoCambio Moneda
        { 
            set
            {
                this.moneda = value;
            }
            get
            {
                return this.moneda;
            }
        }
        
        public Producto this[int i]
        {
            get
            {
                Producto salida = null;
                foreach(Producto item in this.productos)
                {
                    if(item.Identificador == i)
                    {
                        salida = item;
                    }
                }
                return salida;
            }
            set
            {
                bool encontro = false;
                foreach(Producto item in this.productos)
                {
                    if(item.Identificador == i)
                    {
                        item.Cantidad += value.Cantidad;
                        encontro = true;
                    }
                }
                if (!encontro)
                {
                    this.productos.Add(value);
                }
            }
        }
        
    }
}
