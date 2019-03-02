using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_49";
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoDeCompetencia.f1);

            AutoF1 primerAuto = new AutoF1(1, "McLaren");
            AutoF1 segundoAuto = new AutoF1(1, "Ferrari");
            AutoF1 tercerAuto = new AutoF1(1, "Mercedes");
            AutoF1 cuartoAuto = new AutoF1(1, "Williams");
            AutoF1 quintoAuto = new AutoF1(1, "Renault");
            AutoF1 sextoAuto = new AutoF1(1, "Haas");
            MotoCross primerMoto = new MotoCross(1, "Kawasaki");

            try
            {
                Console.WriteLine(competencia + primerAuto);
                Console.WriteLine(competencia + segundoAuto);
                //Console.WriteLine(competencia + primerMoto);
                Console.WriteLine("---------------------------");
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine(competencia.Mostrar());

            Console.ReadKey();
        }
    }
}
