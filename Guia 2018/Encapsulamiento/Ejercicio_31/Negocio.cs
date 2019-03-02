using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    /*Negocio:

    h.i. El operador ~(Negocio) : bool generará una atención del próximo cliente en la cola,
    utilizando la propiedad Cliente y el método Atender de PuestoAtencion. Retornará True si
    pudo realizar la operación completa.
    j. */
    public class Negocio
    {
        #region Fields

        private PuestoDeAtencion caja;
        private string nombre;
        private Queue<Cliente> clientes;

        #endregion

        #region Propieties

        /// <summary>
        ///  La propiedad Cliente retornará el próximo cliente en la cola de atención en el get. El set
        /// deberá controlar que el Cliente no figure ya en la cola de atención, caso contrario lo agregará.
        /// </summary>
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                
            }
        }

        /// <summary>
        /// Agregar la propiedad ClientesPendientes que retorne la cantidad de clientes esperando a ser atendidos.
        /// </summary>
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// El constructor privado inicializará la colección y el puesto de atención como Caja1.
        /// </summary>
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoDeAtencion(PuestoDeAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// El operador == retornará true si el cliente se encuentra en la colección.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente item in n.clientes)
            {
                if (item == c)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        /// <summary>
        /// El operador + será el único capaz de agregar un Cliente a la cola de atención. Sólo se
        /// agregará un Cliente si este no forma ya parte de la lista.Rehutilizar el == de Cliente.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
                return false;
            n.clientes.Enqueue(c);
            return true;
        }

        /// <summary>
        /// El operador ~(Negocio) : bool generará una atención del próximo cliente en la cola,
        /// utilizando la propiedad Cliente y el método Atender de PuestoAtencion.Retornará True si
        /// pudo realizar la operación completa.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool operator ~(Negocio n)
        {
            return true;
        }

        #endregion
    }
}
