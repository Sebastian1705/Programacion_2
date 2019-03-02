using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        //  1. Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
        //  valor máximo, el valor mínimo y el promedio.
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int numero, max = 0, min = 0, sumador = 0; ;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(),out numero))
                {
                    if(i == 0)
                    {
                        max = numero;
                        min = numero;
                    }
                    if (numero > max)
                        max = numero;
                    else if (numero < min)
                        min = numero;
                    sumador += numero;
                }
            }
            Console.WriteLine($"El maximo es: {max}");
            Console.WriteLine($"El minimo es: {min}");
            Console.WriteLine($"El promedio es: {sumador / 5}");
            Console.ReadKey();
        }
    }
}
