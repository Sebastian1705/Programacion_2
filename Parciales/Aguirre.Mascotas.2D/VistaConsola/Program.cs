using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Primer Parcial";
            //Creo grupo y mascotas
            Grupo g1 = new Grupo("Rio");
            Mascota m1 = new Perro("Moro", "Pitbull");
            Mascota m2 = new Perro("Julio", "Cruza",13,false);
            Mascota m3 = new Perro("Ramon", "Salchicha", 2, true);
            Mascota m4 = new Gato("Jose", "Angora");
            Mascota m5 = new Gato("Hernan", "Cruza");
            Mascota m6 = new Gato("Fer", "Siames");

            //las agrego al grupo
            g1 += m1; 
            g1 += m2;
            g1 += m3;
            g1 += m4;
            g1 += m5;
            g1 += m6;

            //imprimo datos
            Console.WriteLine((string)g1);

            Console.ReadKey();
        }
    }
}
