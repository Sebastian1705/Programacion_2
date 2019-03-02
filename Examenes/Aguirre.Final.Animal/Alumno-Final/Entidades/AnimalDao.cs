using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Entidades
{
    public class AnimalDao : IArchivos<List<Animal>>
    {
        #region Fields
        
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader reader;

        #endregion

        #region Methods

        public AnimalDao()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=final-20181213;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Guardar(string path, List<Animal> datos)
        {
            try
            {
                conexion.Open();
                foreach (Animal item in datos)
                {
                    string sql = String.Format("INSERT INTO " + path + " (nombre) VALUES('{0}');", item.Nombre);
                    comando.CommandText = sql;                 
                    comando.ExecuteNonQuery();
                }               
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Animal> Leer(string path)
        {
            List<Animal> animales = new List<Animal>();
            try
            {
                string nombre;
                string sql = string.Format("SELECT nombre FROM {0}", path);         
                comando.CommandText = sql;
                conexion.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    nombre = reader.GetString(0);
                    Animal aux = new Humano(nombre, DateTime.Now.AddYears(-20), Humano.Ocupacion.Estudiante);
                    animales.Add(aux);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return animales;
        }

        #endregion
    }
}
