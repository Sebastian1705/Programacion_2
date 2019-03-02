using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        /*11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
        Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
        posea la siguiente firma: bool Validar(int valor, int min, int max):
        a. valor: dato a validar
        b. min y max: rango en el cual deberá estar la variable valor.
        Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
        Nota: Utilizar variables escalares, NO utilizar vectores.*/
        static void Main(string[] args)
        {
            int numero, max = 0, min = 0, acum = 0;
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    if (Validacion.Validar(numero, -100, 100))
                    {
                        acum += numero;
                        if (i == 0)
                        {
                            min = numero;
                            max = numero;
                        }
                        else
                        {
                            if (numero < min)
                                min = numero;
                            else if (numero > max)
                                max = numero;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Numero incorrecto! Ingreselo nuevamente!");
                        i--;
                    }
                }
            }
            Console.WriteLine($"El maximo es: {max} el minimo es: {min} El promedio es: {acum / 5}");
            Console.ReadKey();
        }
    }
}
