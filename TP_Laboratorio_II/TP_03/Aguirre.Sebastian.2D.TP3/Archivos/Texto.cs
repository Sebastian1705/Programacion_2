using System;
using System.IO;


namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region Metodos

        public bool Guardar(string archivo, string datos)
        {
            StreamWriter file = null;
            bool retorno = true; //Devuelve true si no se produjeron excepciones.
            try
            {
                file = new StreamWriter(archivo, false);
                file.Write(datos);
            }
            catch (Exception)
            {
                retorno = false; //Devuelve false si se produjeron excepciones. 
            }
            finally
            {
                file.Close();
            }
            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            StreamReader file = null;
            bool retorno = true; //Devuelve true si no se produjeron excepciones.
            try
            {
                file = new StreamReader(archivo);
                datos = file.ReadToEnd();
            }
            catch (Exception)
            {
                datos = null;
                retorno = false; //Devuelve false si se produjeron excepciones. 
            }
            finally
            {
                file.Close();
            }
            return retorno;
        }

        #endregion
    }
}
