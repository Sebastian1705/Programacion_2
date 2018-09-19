using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Negocio
    {
        #region Fields

        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #endregion

        #region Propieties
        
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool x = this + Cliente;
            }
        }
        
        #endregion

        #region Methods

        private Negocio()
        {
            Queue<Cliente> clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
     
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach(Cliente cli in n.clientes)
            {
                if (cli == c)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if(!Object.ReferenceEquals(n,null))
            {
                n.caja.Atender(n.Cliente);
                retorno = true;
            }
            return retorno;
        }

        #endregion


    }
}
