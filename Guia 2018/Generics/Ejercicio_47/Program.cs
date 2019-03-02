using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_47
{
    /*b. Crear un proyecto del tipo Console:
    i. Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet.
    ii. Crear 3 equipos de cada tipo.
    iii. Agregar los equipos en tantos torneos como se pueda.
    iv. Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
    v. Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su
    respuesta por pantalla.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_47";

            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Fulbo");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Basquebol");

            EquipoFutbol river = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol racing = new EquipoFutbol("Racing", DateTime.Now);
            EquipoFutbol independiente = new EquipoFutbol("Independiente", DateTime.Now);

            EquipoBasquet chicago = new EquipoBasquet("Chicago", DateTime.Now);
            EquipoBasquet florida = new EquipoBasquet("Florida", DateTime.Now);
            EquipoBasquet newYersey = new EquipoBasquet("New Yersey", DateTime.Now);

            torneoFutbol += river;
            torneoFutbol += racing;
            torneoFutbol += independiente;
            torneoBasquet += chicago;
            torneoBasquet += newYersey;
            torneoBasquet += florida;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());
            try
            {
                Console.WriteLine(torneoFutbol.JugarPartido);
                Console.WriteLine(torneoFutbol.JugarPartido);
                Console.WriteLine(torneoFutbol.JugarPartido);
                Console.WriteLine("-------------------------");
                Console.WriteLine(torneoBasquet.JugarPartido);
                Console.WriteLine(torneoBasquet.JugarPartido);
                Console.WriteLine(torneoBasquet.JugarPartido);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }            

            Console.ReadKey();
        }
    }
}
