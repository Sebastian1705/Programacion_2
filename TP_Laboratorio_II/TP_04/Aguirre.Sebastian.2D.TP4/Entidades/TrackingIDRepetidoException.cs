using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Entidades
{
    public class TrackingIDRepetidoException : Exception
    {
        #region Methods

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="mensaje"></param>
        public TrackingIDRepetidoException(string mensaje)
            : this(mensaje, null)
        {

        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public TrackingIDRepetidoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }

        #endregion
    }
}
