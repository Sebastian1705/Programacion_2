using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_27";

            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> fila = new Queue<int>();
            Random r = new Random();

            //Agrego numeros a las listas
            for(int i=0; i<20; i++)
            {
                int numero = r.Next(-100, 100);
                if (numero != 0)
                {
                    lista.Add(numero);
                    fila.Enqueue(numero);
                    pila.Push(numero);
                }
                else
                    i--;
            }
            //Muestro lista
            Console.WriteLine("Lista\n");
            foreach(int n in lista)
            {
                Console.Write(n + " ");
            }
            //Muestro Fila
            Console.WriteLine("\n\nFila\n");
            foreach (int n in fila)
            {
                Console.Write(n + " ");
            }
            //Muestro pila
            Console.WriteLine("\n\nPila\n");
            foreach (int n in pila)
            {
                Console.Write(n + " ");
            }



            Console.ReadKey();
        }
    }
}
