using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio_06";

            int añoIngresado;
            bool esBisiesto = false;
            Console.Write("Ingrese un año: ");
            if (int.TryParse(Console.ReadLine(), out añoIngresado))
            {
                if((añoIngresado % 4) == 0)
                {
                    esBisiesto = true;
                    if ((añoIngresado % 100) == 0 && (añoIngresado % 400) != 0)
                    {
                        esBisiesto = false;
                    }
                }
            }
            if (esBisiesto == true)
            {
                Console.WriteLine("El año {0} es bisiesto", añoIngresado);
            }
            else
            {
                Console.WriteLine("El año {0} no es bisiesto", añoIngresado);
            }
            Console.ReadKey();
        }
    }
}
