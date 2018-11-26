using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;


namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Fields

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        #endregion

        #region Propieties

        /// <summary>
        /// Propiedad de lectura - escritura.
        /// </summary>
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura - escritura.
        /// </summary>
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura - escritura.
        /// </summary>
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="direccionEntrega">Direccion de entrega.</param>
        /// <param name="trackingID">Codigo de tracking.</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }

        /// <summary>
        /// Sobrecarga operador ==.
        /// Dos paquetes serán iguales siempre y cuando su Tracking ID sea el mismo.
        /// </summary>
        /// <param name="p1">Paquete a comparar.</param>
        /// <param name="p2">Paquete a comparar.</param>
        /// <returns>True si son iguales, false caso contrario.</returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;
            if (!(p1 is null) && !(p2 is null) && p1.trackingID == p2.trackingID) // p1.trackingID.Equals(p2.trackingID)
                retorno = true;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador !=.
        /// Dos paquetes serán distintos siempre y cuando su Tracking ID no sea el mismo.
        /// </summary>
        /// <param name="p1">Paquete a comparar.</param>
        /// <param name="p2">Paquete a comparar.</param>
        /// <returns>True si son distintos, false caso contrario.</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Muestra los datos del paquete recibido.
        /// </summary>
        /// <param name="elemento">Paquete reibido.</param>
        /// <returns>Retorna un string con la direccion de entrega y el numero de tracking.</returns>
        public string MostrarDatos(IMostrar<Paquete> elementos)
        {
            return String.Format($"{((Paquete)elementos).trackingID} para {((Paquete)elementos).direccionEntrega}");
        }

        /// <summary>
        /// Sobrecarga de metodo para exponer los datos del paquete.
        /// </summary>
        /// <returns>Retorna los datos del paquete.</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Coloca una demora de 10 segundos.
        /// Pasa al siguiente estado.
        /// Informa el estado a través de InformarEstado. 
        /// Repite las acciones hasta que el estado sea Entregado.
        /// Finalmente guardar los datos del paquete en la base de datos.
        /// </summary>
        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(4000);
                Estado = (Estado == EEstado.Ingresado) ? EEstado.EnViaje : EEstado.Entregado;
                InformaEstado(this, new EventArgs());

            } while (Estado != EEstado.Entregado);
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                throw e;              
            }
        }

        #endregion

        #region Nested Types

        /// <summary>
        /// Enumerado con estados posibles del paquete.
        /// </summary>
        public enum EEstado
        {
            Ingresado, EnViaje, Entregado
        }

        #endregion

        #region Events
       
        /// <summary>
        /// Evento del tipo DelegadoEstado.
        /// </summary>
        public event DelegadoEstado InformaEstado;

        #endregion

        #region Delegate

        /// <summary>
        /// Delegado del evento InformaEstado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void DelegadoEstado(object sender, EventArgs e);
        
        #endregion

    }
}
