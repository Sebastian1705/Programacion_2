using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            double aux, cuadrado = 0, cubo = 0;

            Console.Write("Ingrese un numero: ");
            numero = Console.ReadLine();
            if (double.TryParse(numero, out aux))
            {
                if(aux > 0)
                {
                    cuadrado = Math.Pow(aux, 2);
                    cubo = Math.Pow(aux, 3);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero: {0}", aux);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cuadrado: {0}", cuadrado);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cubo: {0}", cubo);

            Console.ReadKey();
        }
    }
}
