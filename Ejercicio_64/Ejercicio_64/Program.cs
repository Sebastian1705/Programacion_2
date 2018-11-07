using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Threading;

namespace Ejercicio_64
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja1);
            negocio.Clientes.Add("Juan");
            negocio.Clientes.Add("Pedro");
            negocio.Clientes.Add("David");
            negocio.Clientes.Add("Jose");
            negocio.Clientes.Add("Marcos");
            
            Thread asignar = new Thread(negocio.AsignarCajas);
            asignar.Start();
            
            Thread hiloCaja1 = new Thread(negocio.Caja1.AtenderClientes);
            hiloCaja1.Name = "Caja1";
            hiloCaja1.Start();
            /*
            Thread hiloCaja2 = new Thread(negocio.Caja2.AtenderClientes);
            hiloCaja2.Name = "Caja2";
            hiloCaja2.Start();
            */
            //Console.WriteLine(negocio.Clientes.Count);
            Console.ReadKey();
        }
    }
}
