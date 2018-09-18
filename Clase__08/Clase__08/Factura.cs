using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase__08
{
    public class Factura
    {
        private int numero;
        private DateTime fecha;
        private int moneda;
        public List<Producto> productos;

        public Factura()
        {

        }

        public Factura(int numero, int moneda, DateTime fecha)
        {
            this.numero = numero;
            this.moneda = moneda;
            this.fecha = fecha;
            this.productos = new List<Producto>();
        }

        public double GetTotal()
        {
            double total = 0;
            foreach(Producto item in this.productos)
            {
               
            }
            return total;
        }
    }
}
