using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Campos

        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// Valida el Nombre antes de asignarlo.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// Valida el Apellido antes de asignarlo.
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// Valida el Dni antes de asignarlo.
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value);
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura
        /// Valida el DNI antes de asignarlo.
        /// </summary>
        public string StringToDni
        {   
            set
            {
               this.dni = this.ValidarDni(this.nacionalidad, value);
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">string con el nombre de persona instanciada</param>
        /// <param name="apellido">string con el apellido de persona instanciada</param>
        /// <param name="nacionalidad">Enumerado Argentino / Extranjero </param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">string con el nombre de persona instanciada</param>
        /// <param name="apellido">string con el apellido de persona instanciada</param>
        /// <param name="dni">int con el dni de persona instanciada</param>
        /// <param name="nacionalidad">Enumerado Argentino / Extranjero </param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">string con el nombre de persona instanciada</param>
        /// <param name="apellido">string con el apellido de persona instanciada</param>
        /// <param name="dni">string con el dni de persona instanciada</param>
        /// <param name="nacionalidad">Enumerado Argentino / Extranjero </param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)   
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDni = dni; 
        }

        /// <summary>
        /// Sobrecarga del metodo ToString().
        /// Muestra en una cadena los datos de una persona.
        /// </summary>
        /// <returns>string con datos de perona (NOMBRE COMPLETO, NACIONALIDAD)</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLETO: {this.Apellido}, {this.Nombre}");
            sb.AppendLine($"NACIONALIDAD: {this.Nacionalidad}");
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que valida que el documente sea acorde a la nacionalidad.
        /// Argntino entre 1 y 89999999.
        /// Entranjero entre 90000000 y 99999999.
        /// </summary>
        /// <param name="nacionalidad">Enumerado (Argentino - Extranjero)</param>
        /// <param name="dato">int con el dni a validar</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if(dato < 1 || dato > 99999999) // Fuera de rango
            {
                throw new DniInvalidoException("Dni fuera de rango.");
            }
            switch(nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato > 89999999)
                        throw new NacionalidadInvalidaException("La nacionalidad no coincide con el numero de DNI.");
                    break;
                case ENacionalidad.Extranjero:
                    if (dato <= 89999999)
                        throw new NacionalidadInvalidaException("La nacionalidad no coincide con el numero de DNI.");
                    break;
            }
            return dato;
        }

        /// <summary>
        /// Valida que el dni pasado como string contenga solo caracteres numericos.
        /// Si falla, lanza la excepcion DniInvalidoException().
        /// Luego llama al Metodo que valida de acuerdo a la nacionalidad.
        /// </summary>
        /// <param name="nacionalidad">Enumerado (Argentino - Extranjero)</param>
        /// <param name="dato">string con el dni a validar</param>
        /// <returns>Llama al metodo que valida el rango</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            bool aux = true;
            if (!(dato is null))
            {
                for (int i = 0; i < dato.Length; i++)
                {
                    if (dato[i] < '0' || dato[i] > '9')
                    {
                        aux = false;
                        break;
                    }
                }
                if (aux)
                {
                    Int32.TryParse(dato, out retorno);
                }
                else
                    throw new DniInvalidoException("El dni contiene caracteres invalidos.");
            } 
            return this.ValidarDni(nacionalidad, retorno);
        }

        /// <summary>
        /// Metodo que valida que el dato pasado como parametro
        /// contenga solamente letras.
        /// </summary>
        /// <param name="dato">string a validar</param>
        /// <returns>dato validado / null en caso contrario</returns>
        private string ValidarNombreApellido(string dato)
        {
            string retorno = null;
            bool aux = true;
            if(!(dato is null))
            {
                /*for(int i = 0; i < dato.Length; i++)
                {
                    if((dato[i] < 'a' || dato[i] > 'z') && (dato[i] < 'A' || dato[i] > 'Z') )
                    {
                        aux = false;
                        break;
                    }
                }*/
                foreach(char item in dato)
                {
                    if(!char.IsLetter(item))
                    {
                        aux = false;
                        break;
                    }
                }
                if (aux)
                    retorno = dato;
            }
            return retorno;
        }

        #endregion

        #region Tipos Anidados

        public enum ENacionalidad
        {
            Argentino, Extranjero
        }

        #endregion
    }
}
