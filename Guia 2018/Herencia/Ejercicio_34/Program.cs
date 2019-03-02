using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre moto = new Moto(2, 0, Colores.Azul, 600);
            VehiculoTerrestre auto = new Automovil(4, 4, Colores.Gris, 5, 4);
            VehiculoTerrestre camion = new Camion(8, 3, Colores.Rojo, 6, 15000);

            Console.WriteLine($"{moto.Color} - {camion.Color} - {auto.Color}");
            Console.ReadKey();
        }
    }
}
