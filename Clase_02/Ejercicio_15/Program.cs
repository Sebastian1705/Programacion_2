using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";

            double num1 = 0, num2 = 0, resultado;
            string operador = "", respuesta = "s";

            do
            {
                Console.Write("Ingrese un numero: ");
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Ingrese otro numero: ");
                    if (double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.Write("Ingrese el operador (+ - * /): ");
                        operador = Console.ReadLine();
                    }
                }
                resultado = Calculadora.Calcular(num1, num2, operador);
                Console.WriteLine("Resultado: {0}", resultado);
                Console.Write("Continuar? (S/N): ");
                respuesta = Console.ReadLine();
                Console.Clear();
                
            } while (respuesta == "s");
            Console.ReadKey();
        }
    }
}
