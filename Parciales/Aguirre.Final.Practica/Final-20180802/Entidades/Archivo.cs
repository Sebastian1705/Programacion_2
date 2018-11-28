using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Sobreescribir el método ToString para mostrar los valores de sus atributos.Utilizar String.Format.
    //Agregar el operador explicit para retornar el contenido del archivo.
    public class Archivo
    {
        #region Fields

        public string nombre;
        public string contenido;

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

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        #endregion

        #region Methods

        public Archivo(string nombre, string contenido)
        {
            this.Nombre = nombre;
            this.Contenido = contenido;
        }

        public override string ToString()
        {
            return string.Format($"Nombre: {this.Nombre} - Contenido: {this.Contenido}");
        }

        public static explicit operator string(Archivo a)
        {
            return a.ToString();
        }

        #endregion
    }
}
