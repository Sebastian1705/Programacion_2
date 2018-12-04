using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Deberá heredar de Almacenador e implementar IAlmacenable.
    //Crear un constructor que reciba y asigne el/los atributos de la misma.
    //El método MostrarArchivos lanzará una excepción del tipo NotImplementedException.
    //El método Guardar deberá guardar un objeto de tipo archivo en un archivo de texto en la ubicación definida en el atributo pathArchivos.
    //El método Leer recibirá el nombre de un archivo y deberá retornar su contenido.
    //Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    public class ArchiveroFisico : Almacenador, IAlmacenable<string, Archivo>
    {
        #region Fields

        private string pathArchivos;

        #endregion

        #region Propieties

        public string PathArchivos
        {
            get
            {
                return this.pathArchivos;
            }
            set
            {
                this.pathArchivos = value;
            }
        }

        #endregion

        #region Methods

        public ArchiveroFisico(string path, int capacidad)
            : base(capacidad)
        {
            this.Capacidad = capacidad;
        }

        public override void MostrarArchivos()
        {
            throw new NotImplementedException();
        }

        public bool Guardar(Archivo elemento)
        {    
            StreamWriter sw = new StreamWriter(this.PathArchivos, File.Exists(this.PathArchivos));
            try
            {
                if(!(sw is null))
                {
                    sw.WriteLine(elemento.Contenido);
                    //sw.WriteLine(elemento.ToString());
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                sw.Close();
            }
            return true;
        }

        public string Leer(string path)
        {
            string retorno = null;
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                try
                {
                    retorno = sr.ReadToEnd();
                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    sr.Close();
                }
            }
            return retorno;
        }

        #endregion
    }
}
