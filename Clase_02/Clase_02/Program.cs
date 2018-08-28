using System;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            MiPrimerClase objetoDePrueba = new MiPrimerClase();
            MiPrimerClase objetoDePrueba2 = new MiPrimerClase();

            objetoDePrueba.valor = 2;
            Console.WriteLine(objetoDePrueba.valor);

            Console.WriteLine(objetoDePrueba2.valor);
            MiPrimerClase.valorEstatico = 1;

            Console.WriteLine();
            Automovil.MostrarCantidadRuedas();

            Automovil objetoAuto = new Automovil();

            objetoAuto.Acelerar(10);
            Console.WriteLine(objetoAuto.velocidadActual);
           
            Console.ReadKey();
        }
    }
}
