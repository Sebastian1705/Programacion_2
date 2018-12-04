using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class DiscoElectronico : Almacenador, IAlmacenable<List<Archivo>, Archivo>
    {
        #region Fields

        private List<Archivo> archivosGuardados;

        #endregion

        #region Propieties

        #endregion

        public List<Archivo> ArchivosGuardados
        {
            get
            {
                return this.archivosGuardados;
            }
            set
            {
                this.archivosGuardados = value;
            }
        }

        #region Methods
    
        private DiscoElectronico(int capacidad)
            : base(capacidad)
        {
            this.ArchivosGuardados = new List<Archivo>();
        }

        /// <summary>
        /// El método MostrarArchivos por el momento sólo deberá recorrer la lista de archivos y por cada uno simular un retardo de 5 segundos.
        /// </summary>
        public override void MostrarArchivos()
        {
            for (int i = 0; i < this.ArchivosGuardados.Count; i++)
                Thread.Sleep(5000); 
        }

        /// <summary>
        /// El método Leer recibirá el nombre de la tabla a consultar. Deberá leer y retornar todos los archivos de la base de datos.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<Archivo> Leer(string path)
        {
            List<Archivo> retorno = null;

            return retorno;
        }

        /// <summary>
        /// El método Guardar deberá insertar un archivo en la base de datos.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Guardar(Archivo a)
        {
            return true;
        }

        /// <summary>
        /// Sobrecargar el operador + para agregar un archivo a la lista siempre y cuando no supere la capacidad,
        /// caso contrario lanzará una excepción con el mensaje "El disco está lleno!".
        /// </summary>
        public static DiscoElectronico operator +(DiscoElectronico d, Archivo a)
        {
            return d;
        }

        #endregion
    }
}
