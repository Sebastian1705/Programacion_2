using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        /*12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
        un mensaje "¿Continuar? (S/N)".
        En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
        opciones.
        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
        cualquier otro valor*/
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_12";
            int numero, sumador = 0;
            string respuesta;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    sumador += numero;
                }
                Console.WriteLine("¿Continuar? (S/N)");
                respuesta = Console.ReadLine();
            } while (ValidarRespuesta.ValidaS_N(Convert.ToChar(respuesta)));
            Console.Clear();
            Console.WriteLine(sumador);
            Console.ReadKey();
        }
    }
}
