using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros = 5;
            int i, aux, max = 0, min = 0, promedio = 0;
            string numero;

            for (i = 0; i < cantidadNumeros; i++)
            {
                Console.Write("Ingrese un número: ");
                numero = Console.ReadLine();
                if (int.TryParse(numero, out aux))
                {
                    if (i == 0)
                    {
                        max = aux;
                        min = aux;
                        promedio = aux;
                    }
                    else
                    {
                        if (aux > max)
                        {
                            max = aux;
                        }
                        if (aux < min)
                        {
                            min = aux;
                        }
                        promedio = (promedio + aux);
                    }
                }
                else
                {
                    i--;
                }
            }
            promedio = promedio / cantidadNumeros;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Máximo : {0}", max);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Mínimo : {0}", min);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Promedio: {0:#.##}", promedio);

            Console.ReadKey();
        }
    }
}
