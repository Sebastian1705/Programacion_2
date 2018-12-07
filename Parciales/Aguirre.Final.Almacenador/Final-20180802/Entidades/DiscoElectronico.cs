using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;

namespace Entidades
{
    public class DiscoElectronico : Almacenador, IAlmacenable<List<Archivo>, Archivo>
    {
        #region Fields

        private List<Archivo> archivosGuardados;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;

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
            string nombre, contenido;
            try
            {
                conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=final-20180802;Integrated Security=True");
                comando = new SqlCommand(string.Format("SELECT * FROM '{0}'", path));
                conexion.Open();
                reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    nombre = reader.GetString(1);
                    contenido = reader.GetString(2);
                    Archivo a = new Archivo(nombre, contenido);
                    
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return this.ArchivosGuardados;
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
            if (d.ArchivosGuardados.Count < d.Capacidad)
                d.ArchivosGuardados.Add(a);
            else
                throw new Exception("El disco está lleno!");
            return d;
        }

        #endregion
    }
}
