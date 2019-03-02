using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;
using System.IO;

namespace Archivos
{
    /*2. Crear una nueva biblioteca de clases llamada Archivos con las siguientes clases:
    a. La clase Xml será utilizada para serializar y deserializar un objeto dado.*/
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string destino, T datos)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\" + destino;
            XmlSerializer ser = new XmlSerializer(typeof(T)); //Objeto que serializará.
            //Se indica el tipo de objeto ha serializar.
            XmlTextWriter writer = new XmlTextWriter(path,Encoding.ASCII); //Objeto que escribirá en XML.
            //Se indica ubicación del archivo XML y su codificación.     
            try
            {
                ser.Serialize(writer, datos);
                //Serializa el objeto datos en el archivo contenido en writer.
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
                //Se cierra el objeto writer
            }
        }

        public T Leer(string origen)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\" + origen;
            XmlTextReader reader = new XmlTextReader(path); //Objeto que leerá XML.
            //Se indica ubicación del archivo XML.
            XmlSerializer ser = new XmlSerializer(typeof(T)); //Objeto que Deserializará.
            //Se indica el tipo de objeto ha serializar.
            T aux;
            try
            {
                aux = (T)ser.Deserialize(reader);
                //Deserializa el archivo contenido en reader, lo guarda en aux.
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                reader.Close();
            }            
            return aux;
        }
    }
}
