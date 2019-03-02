using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_20";

            Dolar d = new Dolar(1);
            Real r = (Real)d;
            Pesos p = (Pesos)d;

            d += r;
            p += r;

            Console.WriteLine($"{d.GetCantidad()}");
            Console.WriteLine($"{p.GetCantidad()}");

            Console.ReadKey();
        }
    }
}
