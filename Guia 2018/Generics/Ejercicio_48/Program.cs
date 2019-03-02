using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_48";
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Factura f = new Factura(5);
            Factura f2 = new Factura(10);
            Recibo r = new Recibo();
            Recibo r2 = new Recibo(15);

            c += f;
            c += f2;
            c += r;
            c += r2;

            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
