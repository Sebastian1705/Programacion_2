using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Pez : Animal, IArchivos<Pez>
    {
        #region Fields

        PrincipalAlimento alimentacion;

        #endregion

        #region Propieties

        public PrincipalAlimento Alimentacion { get => alimentacion; set => alimentacion = value; }
 
        #endregion

        #region Methods

        public Pez()
            : base()
        { }

        public Pez(string nombre, PrincipalAlimento alimentacion)
            : base(nombre)
        {
            this.Alimentacion = alimentacion;
        }

        protected override string ExponerDatos()
        {
            return string.Format($"{base.ExponerDatos()} ALIMENTACION: {this.Alimentacion}.");
        }

        public static bool operator ==(Pez a, Pez b)
        {
            if ((Animal)a == (Animal)b && a.Alimentacion == b.Alimentacion)
                return true;
            return false;
        }

        public static bool operator !=(Pez a, Pez b)
        {
            return !(a == b);
        }

        public void Guardar(string path, Pez datos)
        {     
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\" + path;
            XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.ASCII); //Objeto que escribirá en XML.
            //Se indica ubicación del archivo XML y su codificación.
            XmlSerializer ser = new XmlSerializer(typeof(Pez)); //Objeto que serializará.
            //Se indica el tipo de objeto ha serializar.
            ser.Serialize(writer, datos);
            //Serializa el objeto datos en el archivo contenido en writer.
            writer.Close();
            //Se cierra el objeto writer
        }

        public Pez Leer(string path)
        {      
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\" + path;
            XmlTextReader reader = new XmlTextReader(ruta); //Objeto que leerá XML.
            //Se indica ubicación del archivo XML.
            XmlSerializer ser = new XmlSerializer(typeof(Pez)); //Objeto que Deserializará.
            //Se indica el tipo de objeto ha serializar.
            Pez aux = (Pez)ser.Deserialize(reader);
            //Deserializa el archivo contenido en reader, lo guarda en aux.
            reader.Close();
            return aux;
        }

        #endregion

        #region Nested Types

        public enum PrincipalAlimento
        {
            Carne, Plancton, Otra
        }

        #endregion
    }
}
