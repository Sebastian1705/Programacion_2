using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaSegundoParcial;

namespace Probador
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivos archivo = new Archivos();
            /*
            string texto = "***********************************************";
            archivo.GuardarArchivos(texto, "Seba");
            */
            archivo.LeerArchivo(@"C:\Users\Seba\Desktop\Seba.txt");

            Console.ReadKey();
        }
    }
}
