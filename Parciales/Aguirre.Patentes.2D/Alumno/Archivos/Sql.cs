using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        #region Fields

        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;

        #endregion

        #region Methods

        public Sql()
        {
            conexion = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = patentes-sp-2018; Integrated Security = True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                foreach(Patente item in datos)
                {
                    comando.CommandText = String.Format("INSERT INTO {0} (patente,tipo) VALUES('{1}','{2}')", tabla, item.CodigoPatente, item.TipoCodigo);
                    conexion.Open();
                    comando.ExecuteNonQuery();
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
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            string patente, tipo;
            datos = new Queue<Patente>();
            Patente p = null;
            try
            {
                comando.CommandText = String.Format("SELECT * FROM {0}",tabla);
                conexion.Open();
                reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    patente = reader.GetString(1);
                    tipo = reader.GetString(2);
                    //p = new Patente(patente, )
                    datos.Enqueue(p);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                reader.Close();
                conexion.Close();
            }
        }

        #endregion
    }
}
