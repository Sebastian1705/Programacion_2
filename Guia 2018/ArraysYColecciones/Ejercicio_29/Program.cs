using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_29";

            Equipo equipo = new Equipo(5, "Mi equipo");
            Jugador seba = new Jugador(35000428, "Seba");
            Jugador mica = new Jugador(37200785, "Mica");
            Jugador nico = new Jugador(12345678, "Nico", 10, 15);

            equipo += seba;
            equipo += mica;
            equipo += nico;

            Console.WriteLine(seba.MostrarDatos());
            Console.WriteLine(mica.MostrarDatos());
            Console.WriteLine(nico.MostrarDatos());

            Console.ReadKey();
        }
    }
}
