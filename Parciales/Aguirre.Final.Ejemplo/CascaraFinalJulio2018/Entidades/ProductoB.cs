using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB : Producto
    {
        #region Fields

        private short alto;
        private short ancho;
        private short largo;

        #endregion

        #region Propieties

        public short Alto
        {
            get
            {
                return this.alto;
            }
        }

        public short Ancho
        {
            get
            {
                return this.ancho;
            }
        }

        public short Largo
        {
            get
            {
                return this.largo;
            }
        }

        #endregion

        #region Methods

        public ProductoB()
            : base()
        {

        }

        public ProductoB(string descripcion, short largo, short alto, short ancho)
            : base(descripcion)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.alto = alto;
        }

        /// <summary>
        /// Mostrar retornará una cadena con todos los datos del producto incluyendo el volumen.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            return String.Format($"{base.Mostrar()} Tipo: B, ANCHO: {this.Ancho}, ALTO: {this.Alto}, LARGO: {this.Largo}, VOLUMEN: {this.CalcularVolumen()}.");
        }

        /// <summary>
        /// ValidarDimensiones retornará true si la suma del largo, ancho y
        /// alto no supera los 100 cm.
        /// </summary>
        /// <returns></returns>
        public override bool ValidarDimensiones()
        {
            bool retorno = false;
            if ((this.Ancho + this.Largo + this.Alto) < 101)
                retorno = true;
            return retorno;
        }

        /// <summary>
        /// CalcularVolumen retornará el volumen obtenido de la multiplicación entre el alto, largo y
        /// ancho.
        /// </summary>
        private int CalcularVolumen()
        {
            return (this.Alto * this.Ancho * this.Largo);
        }

        /// <summary>
        /// Sobrecargar el operador explicit donde se retornará el volumen del
        /// producto.
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator int(ProductoB p)
        {
            return p.CalcularVolumen();
        }

        #endregion
    }
}
