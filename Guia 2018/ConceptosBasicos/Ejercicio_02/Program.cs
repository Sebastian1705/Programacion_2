using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        //  2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
        //  mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        //  Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            int aux, numero = 0;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out aux) && aux > 0)
                    numero = aux;
                else
                    Console.WriteLine("ERROR. ¡Reingresar número!");

            } while (numero == 0);
            Console.WriteLine($"{numero} al cuadrado es: {Math.Pow(numero, 2)}");
            Console.WriteLine($"{numero} al cubo es: {Math.Pow(numero, 3)}");
            Console.ReadKey();
        }
    }
}
