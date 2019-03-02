using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";
            Sumador s = new Sumador();
            Sumador s2 = new Sumador(6);

            Console.WriteLine(s.Sumar(4, 6));//Muestra 10
            Console.WriteLine(s.Sumar("Hola", "Mundo"));//Muestra HOla Mundo
            Console.WriteLine((int)s);//Muestra 2
            Console.WriteLine();
            Console.WriteLine(s + s2);//Muestra 8
            Console.WriteLine();
            Console.WriteLine(s | s2);//Muestra false
            Console.ReadKey();
        }
    }
}
