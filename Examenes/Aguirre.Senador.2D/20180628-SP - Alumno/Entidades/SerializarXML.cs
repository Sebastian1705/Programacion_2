using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    { 
        public T Leer(string rutaArchivo)
        {
            XmlReader reader = null; //Objeto que leerá XML.
            XmlSerializer ser; //Objeto que Deserializará.
            T objeto;
            try
            {
                //Se indica ubicación del archivo XML.
                reader = new XmlTextReader(rutaArchivo);
                //Se indica el tipo de objeto ha serializar.
                ser = new XmlSerializer(typeof(T));
                //Deserializa el archivo contenido en reader, lo guarda en objeto.
                objeto = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e.Message, e);
            }
            finally
            {
                //Se cierra el objeto reader.
                if (!(reader is null))
                    reader.Close();
            }
            return objeto;
        }
        
        public bool Guardar(string rutaArchivo, T objeto)
        {
            XmlTextWriter writer = null;  //Objeto que escribirá en XML.
            XmlSerializer ser; //Objeto que serializará.
            try
            {
                //Se indica ubicación del archivo XML y su codificación.
                writer = new XmlTextWriter(rutaArchivo, Encoding.ASCII);
                //Se indica el tipo de objeto ha serializar.
                ser = new XmlSerializer(typeof(T));
                //Serializa el objeto p en el archivo contenido en writer.
                ser.Serialize(writer, objeto);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e.Message, e);
            }
            finally
            {
                //Se cierra el objeto writer
                if(!(writer is null)) 
                    writer.Close();
            }
            return true;
        }
    }
}
