using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        #region Fields

        private List<Producto> productos;

        #endregion

        #region Propieties

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }

        #endregion

        #region Methods

        public Pedido()
        {
            this.Productos = new List<Producto>();
        }

        /// <summary>
        /// FabricarPedido recorrerá la lista de productos, por cada uno
        /// simular un retardo de 1 segundo y luego elaborar el producto
        /// </summary>
        public void FabricarPedido()
        {
            foreach(Producto item in this.Productos)
            {
                System.Threading.Thread.Sleep(1000);
                item.Elaborar();
            }
        }

        /// <summary>
        /// listar y retornar
        /// un string con los datos de todos los productos incluidos en el pedido.
        /// </summary>
        /// <param name="unPedido"></param>
        public static implicit operator string(Pedido unPedido)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Producto item in unPedido.Productos)
            {
                sb.AppendLine($"{item.Mostrar()}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// El operador + agregara un producto al pedido teniendo en cuenta que cada pedido puede
        /// contener un máximo de 5 productos. (Sólo primer parcial y final: Adicionalmente validar las
        /// dimensiones del producto antes de agregarlo al pedido).
        /// </summary>
        /// <param name="unPedido"></param>
        /// <param name="unProducto"></param>
        /// <returns></returns>
        public static Pedido operator +(Pedido unPedido, Producto unProducto)
        {
            if(!(unProducto is null) && unPedido.Productos.Count < 6)
            {
                if(unProducto.ValidarDimensiones())
                    unPedido.Productos.Add(unProducto);
            }
            return unPedido;
        }

        #endregion
    }
}
