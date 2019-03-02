using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    /*
    i. Crear una nueva base de datos con el nombre final-20180712 y crear la tabla Productos
    ejecutando el archivo .sql provisto.
    ii. Tener en cuenta:
    Al insertar un “ProductoA” los campos correspondientes a un “ProductoB” quedarán en null
    y viceversa.
    En el campo “tipo” insertar “A” para instancias de ProductoA y “B” para instancias de
    “ProductoB”
     * */
    public static class ProductoDAO
    {
        #region Fields

        private static string cadenaDeConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        #endregion

        #region Methods

        static ProductoDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(@cadenaDeConexion);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Producto> ObtenerProdustos()
        {
            List<Producto> l = new List<Producto>();

            return l;
        }

        public static bool GuardarProducto(Producto p)
        {
            bool retorno = false;
            if(!(p is null))
            {
                try
                {
                    conexion.Open();
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    conexion.Close();
                }
                retorno = true;
            }
            return retorno;
        }

        #endregion
    }
}
