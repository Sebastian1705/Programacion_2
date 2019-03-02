using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Fields

        private string descripcion;

        #endregion

        #region Propieties

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        #endregion

        #region Methods

        public Producto()
        {

        }

        public Producto(string descripcion)
            : this()
        {
            this.Descripcion = descripcion;
        }

        /// <summary>
        /// Mostrar en producto tendrá implementación y podrá ser sobrescrito en las clases hijas.
        /// Deberá retornar un string con el formato: DESCRIPCIÓN: {descripcio}.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return String.Format($"DESCRIPCIÓN: {this.Descripcion}");
        }

        /// <summary>
        /// El método Elaborar deberá guardar en la base de datos el producto y 
        /// disparar el evento InformarProductoTerminado informando el producto elaborado.
        /// </summary>
        public void Elaborar()
        {
            ProductoDAO.GuardarProducto(this);
            this.InformarProductoTerminado.Invoke(this, new EventArgs());
        }

        public abstract bool ValidarDimensiones();

        #endregion

        #region Delegate

        public delegate void ProductoTerminado(Object sender, EventArgs e);

        #endregion

        #region Events

        public event ProductoTerminado InformarProductoTerminado;

        #endregion
    }

    public enum Material
    {
        Plastico, Aluminio, Caucho
    }

}
