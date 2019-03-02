using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", 21, "Bernal", Provincial.Franja.Franja_1);
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(l2, Provincial.Franja.Franja_3);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c += l1;
                c += l2;
                c += l2;
                c += l3;
                c += l4;
            }
            catch(CentralitaException e)
            {
                Console.WriteLine("Error en la clase: " + e.NombreClase);
                Console.WriteLine("Error en el metodo: " + e.NombreMetodo);
                Console.WriteLine(e.Message);
            }
            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
        }
    }
}
