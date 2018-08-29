using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_14";
            double cuadrado, triangulo, circulo;

            cuadrado = CalcuoDeArea.CalcularCuadrado(4);
            triangulo = CalcuoDeArea.CalcularTriangulo(5, 5);
            circulo = CalcuoDeArea.CalcularCirculo(6);

            Console.WriteLine("Cuadrado: {0} - Triangulo: {1} - Circulo: {2}", cuadrado, triangulo, circulo);
            Console.ReadKey();
            
        }
    }
}
