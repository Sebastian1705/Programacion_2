using System;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";

            Boligrafo azul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50,ConsoleColor.Red);

            azul.SetColor(ConsoleColor.Blue);
            rojo.SetColor(ConsoleColor.Red);

            
            
        }
    }
}
