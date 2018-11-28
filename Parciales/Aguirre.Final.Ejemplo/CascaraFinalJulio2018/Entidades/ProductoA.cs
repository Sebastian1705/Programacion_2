using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class ProductoA : Producto
    {
        #region Fields

        private short diametro;
        private Material material;

        #endregion

        #region Propiedades

        public short Diametro
        {
            get
            {
                return this.diametro;
            }
        }

        public Material Material
        {
            get
            {
                return this.material;
            }
            set
            {
                if(this.ValidarMaterial(value))
                    this.material = value;
            }
        }

        #endregion

        #region Methods

        public ProductoA()
        {

        }

        public ProductoA(string descripcion, short diametro, Material material)
            : base(descripcion)
        {
            this.diametro = diametro;
            this.Material = material;
        }

        /// <summary>
        /// Mostrar agregará los datos propios retornando un string con el siguiente formato:
        /// DESCRIPCIÓN: {descripcion}, Tipo: {A}, DIÁMETRO: {diameto}, MATERIAL: {material}
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            return String.Format($"{base.Mostrar()}, TIPO: A, DIAMETRO: {this.Diametro}, MATERIAL: {this.Material}");
        }

        /// <summary>
        /// ValidarDimensiones retornará true si el diámetro del producto es
        /// un valor "par" y se encuentra en el rango de los 30 y 50 cm.
        /// </summary>
        /// <returns></returns>
        public override bool ValidarDimensiones()
        {
            bool retorno = false;
            if (this.Diametro % 2 == 0 && this.Diametro > 29 && this.Diametro < 51)
                retorno = true;
            return retorno;
        }

        /// <summary>
        /// ValidarMaterial será utilizado en el set de la propiedad
        /// Material.Retornará true si el diámetro del producto no supera los 10cm para el caso de
        /// aluminio, 15cm para el caso de caucho y cualquier medida para plástico.Caso contrario
        /// lanzará una excepción del tipo MaterialException con el mensaje "No se puede fabricar una
        /// pieza de { material }  y diámetro de {diámetro }   centímetros."
        /// </summary>
        /// <param name="unMaterial"></param>
        /// <returns></returns>
        public bool ValidarMaterial(Material unMaterial)
        {
            bool retorno = false;
            switch(unMaterial)
            {
                case Material.Aluminio:
                    if (this.Diametro < 11)
                        retorno = true;
                    break;
                case Material.Caucho:
                    if (this.Diametro < 16)
                        retorno = true;
                    break;
                case Material.Plastico:
                    retorno = true;
                    break;
                default:
                    throw new MaterialException($"No se puede fabricar una pieza de {unMaterial} y diámetro de {this.Diametro} centímetros.");
            }
            return retorno;
        }

        #endregion
    }
}
