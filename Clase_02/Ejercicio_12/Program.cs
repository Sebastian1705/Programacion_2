using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_12";

            int sumador = 0, aux;
            char respuesta;

            do
            {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out aux))
                {
                    sumador += aux;
                }

                Console.Write("Continuar? (S/N): ");
                char.TryParse(Console.ReadLine(), out respuesta);
                
            } while (ValidarRespuesta.ValidaS_N(respuesta) == true);
            Console.Clear();
            Console.WriteLine("Total: {0}", sumador);
            Console.ReadKey();
        }
    }
}
