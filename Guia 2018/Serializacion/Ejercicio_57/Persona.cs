using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    /*a. Crear una clase Persona con dos atributos privados del tipo string, nombre y apellido.
    i. Agregarle un constructor que reciba ambos parámetros.
    ii. Crear un método estático llamado Guardar que reciba una persona y la serialice en
    un archivo.
    iii. Crear un método estático Leer que deserialice un archivo y retorne una Persona.
    iv. Sobrecargar el método ToString para mostrar los datos de la persona.*/
    class Persona
    {
        #region Fields

        private string nombre;
        private string apellido;

        #endregion

        #region Propieties

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        #endregion

        #region Methods

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public static void Guardar(Persona p)
        {

        }

        public static Persona Leer(string path)
        {
            Persona p = new Persona();

            return p;
        }



        #endregion
    }
}
