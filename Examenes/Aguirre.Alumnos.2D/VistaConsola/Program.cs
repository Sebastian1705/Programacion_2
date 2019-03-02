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
            // Genero un curso nuevo
            Curso curso = new Curso(2, Divisiones.A, new Profesor("Fede", "Dávila", "12345678", new DateTime(2015, 03, 20)));
            // Genero alumnos...
            Alumno a1 = new Alumno("Juan", "López", "22-3333-2", 2, Divisiones.A);
            //Console.WriteLine(a1.ExponerDatos());
            Alumno a2 = new Alumno("José", "Martínez", "23-3343-6", 2, Divisiones.B);
            //Console.WriteLine(a2.ExponerDatos());
            Alumno a3 = new Alumno("María", "Gutiérrez", "22-3333-2", 2, Divisiones.A);
            //Console.WriteLine(a3.ExponerDatos());
            Alumno a4 = new Alumno("Marta", "Rodríguez", "23-3343-6", 2, Divisiones.A);
            //Console.WriteLine(a4.ExponerDatos());
            Alumno a5 = new Alumno("Marta", "Rodríguez", "233343126", 2, Divisiones.A);
            //Console.WriteLine(a5.ExponerDatos());
            //... Y los agrego al curso
            curso += a1;
            curso += a2;
            curso += a3;
            curso += a4;
            curso += a5;
            // Imprimo los datos del curso
            Console.WriteLine((string)curso);
            Console.ReadKey();

        }
    }
}
