using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        #region Fields

        private static StreamWriter writer;
        private static StreamReader reader;
        
        #endregion

        #region Methods

        public void Guardar(string archivo, Queue<Patente> datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\" + archivo;
                writer = new StreamWriter(path, File.Exists(path));
                foreach(Patente item in datos)
                {
                    writer.WriteLine(item.CodigoPatente);
                }
            }
            catch(PatenteInvalidaException pE)
            {
                throw pE;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\" + archivo;
                reader = new StreamReader(path);
                Patente p = null;
                datos = new Queue<Patente>();
                while (!reader.EndOfStream)
                {
                    p = PatenteStringExtension.ValidarPatente(reader.ReadLine());
                    datos.Enqueue(p);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                reader.Close();
            }
        }

        #endregion
    }
}
