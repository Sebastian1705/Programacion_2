using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro dune = new Libro();
            dune[0] = "primer pagina";
            dune[1] = "segunda pagina";

            Console.WriteLine(dune[0]);
            Console.WriteLine(dune[1]);

            Console.ReadKey();
        }
    }
}
