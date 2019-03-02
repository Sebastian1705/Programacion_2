using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        /*26. Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
        cero de forma aleatoria utilizando la clase Random.
        a. Mostrar el vector tal como fue ingresado
        b. Luego mostrar los positivos ordenados en forma decreciente.
        c. Por último, mostrar los negativos ordenados en forma creciente*/
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_26";

            int[] numeros = new int[20];
            int i;
            Random r = new Random();

            for(i = 0; i<20; i++)
            {
                numeros[i] = r.Next(-100, 100);
                if (numeros[i] == 0)
                    i--;
            }

            Console.WriteLine("NUMEROS RANDOM\n");   
            for (i =0; i<20; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("\n\nPOSITIVOS ORDENADOS\n");
            Array.Sort(numeros);
            Array.Reverse(numeros);
            foreach (int n in numeros)
            {
                if(n > 0)
                    Console.Write(n + " ");
            }

            Console.WriteLine("\n\nNEGATIVOS ORDENADOS\n");
            Array.Sort(numeros);
            foreach (int n in numeros)
            {
                if (n < 0)
                    Console.Write(n + " ");
            }

            Console.ReadKey();
        }
    }
}
