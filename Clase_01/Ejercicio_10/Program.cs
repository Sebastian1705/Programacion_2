using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_10";
           
            int numeroIngresado;
            string auxNumero, imprimir = "*";
            Console.Write("Ingrese la cantidad de pisos de la piramide: ");
            auxNumero = Console.ReadLine();

            if (int.TryParse(auxNumero, out numeroIngresado))
            {
                for (int i = 0; i < numeroIngresado; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(imprimir);
                    // Console.WriteLine();
                    imprimir += "**";
                }
            }
            Console.ReadKey();
        }
    }
}
