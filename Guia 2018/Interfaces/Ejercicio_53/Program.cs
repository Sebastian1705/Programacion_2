using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_53";

            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Cartuchera1 cartuchera1 = new Cartuchera1();

            cartuchera1.Lista.Add(miLapiz);
            cartuchera1.Lista.Add(miBoligrafo);

            cartuchera1.ProbarElementos();

            Console.WriteLine(miLapiz);
            Console.WriteLine(miBoligrafo);


            Console.ReadKey();

        }
    }
}
