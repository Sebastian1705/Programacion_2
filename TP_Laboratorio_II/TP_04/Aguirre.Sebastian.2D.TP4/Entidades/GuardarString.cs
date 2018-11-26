 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardarString
    {
        /// <summary>
        /// Extension de metodo.
        /// Guarda archivo de texto en el escritorio.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo">Nombre del archivo.</param>
        /// <returns></returns>
        public static bool Guardar(this String texto, string archivo)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\" + archivo;
                StreamWriter sw = new StreamWriter(path, File.Exists(path));
                sw.WriteLine(texto);
                sw.Close();
            }
            catch (Exception e)
            {
                throw e;               
            }
            return true;
        }
    }
}
