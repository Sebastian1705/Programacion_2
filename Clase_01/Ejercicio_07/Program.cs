using System;
using System.Globalization;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";
            DateTime localDate = DateTime.Now;
            DateTime fechaNacimiento;
            TimeSpan diasVividos;
            string fecha;
            int cantidadDias;
            Console.Write("Ingrese fecha de nacimiento: ");
            fecha = Console.ReadLine();
            DateTime.TryParse(fecha, out fechaNacimiento);
            diasVividos = localDate - fechaNacimiento;
            cantidadDias = diasVividos.Days;

            Console.WriteLine("La fecha de nacimiento es: {0}", fechaNacimiento);
            Console.WriteLine("La fecha actual es: {0}", localDate);
            Console.WriteLine("La cantidad de dias vividos es: {0}", cantidadDias);

            Console.ReadKey();
        }
    }
}
