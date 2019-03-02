using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entidades;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region Fields

        private static XmlSerializer serializer;
        private static XmlTextWriter writer;
        private static XmlTextReader reader;

        #endregion

        #region Methods
        
        public void Guardar(string archivo, T datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\" + archivo;
                writer = new XmlTextWriter(path, Encoding.ASCII);
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);   
            }
            catch(PatenteInvalidaException pE)
            {
                throw pE;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
            }
        }

        public void Leer(string archivo, out T datos)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\" + archivo;
                reader = new XmlTextReader(path);
                serializer = new XmlSerializer(typeof(T));
                datos = (T)serializer.Deserialize(reader);
            }
            catch (PatenteInvalidaException pE)
            {
                throw pE;
            }
            catch (Exception e)
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
