using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";
            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            
            if(azul.Pintar(30,out dibujo));
                Console.WriteLine(dibujo);
            if(rojo.Pintar(50, out dibujo))
                Console.WriteLine(dibujo);

            Console.ReadKey();
        }
    }
}
