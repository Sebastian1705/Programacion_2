using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase__08
{
    public class Producto
    {
        private int identificador;
        private string nombre;
        private double precio;
        private double iva;
      

        public Producto()
        {
            
        }    
        public Producto(int identificador, string nombre, double precio)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.precio = precio;
            this.iva = precio * 0.21;
        }
    
    }
}
