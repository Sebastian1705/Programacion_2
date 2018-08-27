using System;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_08";
            string nombre, auxHorasTrabajadas, auxValorHora, auxAntiguedad, cantidadEmpleados;
            int cantidad, sumador = 0, importeBruto = 0, importeNeto=0, descuentos=0, valorHora, antiguedad = 0, horasTrabajadas;

            Console.Write("Ingrese la cantidad de empleados: ");
            cantidadEmpleados = Console.ReadLine();

            if(int.TryParse(cantidadEmpleados, out cantidad))
            {
                do
                {
                    Console.Write("Ingrese el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese el valor de la hora: ");
                    auxValorHora = Console.ReadLine();
                    Console.Write("Ingrese la antiguedad: ");
                    auxAntiguedad = Console.ReadLine();
                    Console.Write("Ingrese la cantidad de horas trabajadas: ");
                    auxHorasTrabajadas = Console.ReadLine();
                    sumador++;

                    if(int.TryParse(auxValorHora, out valorHora) && int.TryParse(auxAntiguedad, out antiguedad) && int.TryParse(auxHorasTrabajadas, out horasTrabajadas))
                    {
                        importeBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);
                        descuentos = importeBruto * 13 / 100;
                        importeNeto = importeBruto - descuentos;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Nombre: {0} - Atiguedad: {1} - Valor hora: ${2} - Importe bruto: ${3} - Descuentos: ${4} - Importe neto: ${5}", nombre,
                                                                                                                                                   antiguedad,
                                                                                                                                                   valorHora,
                                                                                                                                                   importeBruto,
                                                                                                                                                   descuentos,
                                                                                                                                                   importeNeto);
                    Console.WriteLine();
                } while (sumador < cantidad);

                Console.ReadKey();
            }


        }
    }
}
