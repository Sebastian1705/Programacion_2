using System;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine((new Metro(5) + new Centimetro(800)).valor);
            Console.ReadKey();
        }
    }
}
