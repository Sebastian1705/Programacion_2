using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticaSegundoParcial
{
    public class Archivos
    {
        public bool LeerArchivo(string archivo)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(archivo);
                while(!sr.EndOfStream)
                {
                    string datosLeidos = sr.ReadLine();
                    Console.WriteLine(datosLeidos);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return true;
        }

        public bool GuardarArchivos(string texto, string archivo)
        {
            StreamWriter sw = null;
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\" + archivo;
                sw = new StreamWriter(path, File.Exists(path));
                sw.WriteLine(texto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (!(sw is null))
                {
                    sw.Close();
                    Console.WriteLine("Se guardo el archivo");
                }
            }
            return true;
        }
    }
}
