using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextWriter writer = null;
            bool retorno = true; //Devuelve true si no se produjeron excepciones.
            try
            {
                writer = new XmlTextWriter(archivo, null);
                ser.Serialize(writer, datos);
            }
            catch (Exception)
            {
                retorno = false; //Devuelve false si se produjeron excepciones. 
            }
            finally
            {
                writer.Close();
            }
            return retorno;
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextReader reader = null;
            bool retorno = true; //Devuelve true si no se produjeron excepciones.            

            try
            {
                reader = new XmlTextReader(archivo);
                datos = (T)ser.Deserialize(reader);
            }
            catch (Exception)
            {
                datos = default(T); //Como no se pudo leer, carga con el valor nulo por defecto para el tipo de dato.
                retorno = false; //Devuelve false si se produjeron excepciones. 
            }
            finally
            {
                reader.Close();
            }
            return retorno;
        }
    }
}
