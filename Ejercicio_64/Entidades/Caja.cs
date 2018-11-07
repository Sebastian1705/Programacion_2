using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Threading;

namespace Entidades
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach (string cliente in this.FilaClientes)
            {
                Console.WriteLine($"Nombre: {cliente}\t Caja: {Thread.CurrentThread.Name}");
                //Thread.Sleep(2000);
            }
        }
    }
}
