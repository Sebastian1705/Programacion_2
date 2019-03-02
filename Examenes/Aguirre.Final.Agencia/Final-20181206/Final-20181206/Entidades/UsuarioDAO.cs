using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
    public class UsuarioDAO
    {
        #region Fields

        private string cadenaDeConexion;
        private SqlCommand comando;
        private SqlConnection conexion;

        #endregion

        #region Methods

        public UsuarioDAO()
        {
            cadenaDeConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=final-20180802;Integrated Security=True";
            conexion = new SqlConnection(cadenaDeConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public bool Guardar(Usuario u)
        {
            try
            {
                comando.CommandText = String.Format("INSERT INTO dbo.Usuarios (nombre,clave) VALUES('{0}','{1}');", u.Nombre, u.Clave); 
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

        public Usuario Leer(string usuario, string clave)
        {
            Usuario aux = null;
            try
            {
                comando.CommandText = String.Format($"SELECT * FROM dbo.Usuarios");
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nombre"].ToString() == usuario && reader["clave"].ToString() == clave)
                        aux = new Usuario(usuario, clave);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return aux;
        }
        
        #endregion
    }
}
