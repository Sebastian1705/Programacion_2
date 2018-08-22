using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int aux, i, j;
            Console.Write("Ingrese un numero: ");
            numero = Console.ReadLine();

            if (int.TryParse(numero, out aux))
            {
                for (j = 2; j <= aux; j++)
                {
                    for (i = 2; i < j; i++)
                    {
                       
                        if ((j % i) == 0)
                        {
                            break;
                        }
                    }

                    if (i == j)
                    {
                        Console.WriteLine("{0} es primo", j);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
