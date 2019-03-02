using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Entidades
{
    [Serializable]
    public class Humano : Animal,IArchivos<Humano>
    {
        #region Fields

        Ocupacion ocupacion;

        #endregion

        #region Propieties

        public Ocupacion Oficio { get => ocupacion; set => ocupacion = value; }
     
        #endregion

        #region Methods

        public Humano()
            : base()
        { }

        public Humano(string nombre, DateTime nacimiento, Ocupacion ocupacion)
            : base(nombre, nacimiento)
        {
            this.Oficio = ocupacion;
        }

        protected override string ExponerDatos()
        {
            return string.Format($"{base.ExponerDatos()} OCUPACION: {this.Oficio}.");
        }

        public static bool operator ==(Humano a, Humano b)
        {
            if ((Animal)a == (Animal)b && a.Oficio == b.Oficio)
                return true;
            return false;
        }

        public static bool operator !=(Humano a, Humano b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return this.ExponerDatos();
        }

        public void Guardar(string path, Humano datos)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\" + path;
            FileStream fs = new FileStream(ruta, FileMode.Create); //Objeto que escribirá en binario.
            //Se indica ubicación del archivo binario y el modo.
            BinaryFormatter ser = new BinaryFormatter(); //Objeto que serializará.
            //Se crea el objeto serializador.
            ser.Serialize(fs, datos);
            //Serializa el objeto p en el archivo contenido en fs.
            fs.Close();
            //Se cierra el objeto fs.
        }

        public Humano Leer(string path)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\" + path;
            FileStream fs = new FileStream(ruta, FileMode.Open);
            //Se indica ubicación del archivo binario y el modo.
            BinaryFormatter ser = new BinaryFormatter();
            //Se crea el objeto deserializador.
            Humano aux = (Humano)ser.Deserialize(fs);
            //Deserializa el archivo contenido en fs, lo guarda en aux.
            fs.Close();
            //Se cierra el objeto fs.
            return aux;
        }

        public void LanzarEvento()
        {
            this.miEvento("Mensaje para mostrar");
        }

        #endregion

        #region Nested Types

        public enum Ocupacion
        {
            Infante, Estudiante, Profesional, Jubilado
        }

        #endregion

        #region Delagate

        public delegate void MiDelegado(string mensaje);

        #endregion

        #region Events

        public event MiDelegado miEvento;

        #endregion
    }
}