using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Fulbol 5");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Triplete");

            EquipoBasquet e1 = new EquipoBasquet("Independiente", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("Velez", DateTime.Now);
            EquipoBasquet e3 = new EquipoBasquet("Banfield", DateTime.Now);

            EquipoFutbol f1 = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol f2 = new EquipoFutbol("Boca", DateTime.Now);
            EquipoFutbol f3 = new EquipoFutbol("Racing", DateTime.Now);

            Console.WriteLine(torneoBasquet.Mostrar());
            torneoBasquet += e1;
            torneoBasquet += e2;
            torneoBasquet += e3;
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("");
            Console.WriteLine(torneoFutbol.Mostrar());
            torneoFutbol += f1;
            torneoFutbol += f2;
            torneoFutbol += f3;
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine("");
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine("");
            Console.WriteLine(torneoFutbol.JugarPartido);


            Console.ReadKey();

        }
    }
}
