using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        #region Fields

        private static SqlConnection _conexion;
        private static SqlCommand _comando;

        #endregion

        #region Methods

        /// <summary>
        /// Crea el objeto SQLCONECTION.
        /// Crea el objeto SQL COMMAND.
        /// Indica el tipo de comando y establece coneccion.
        /// </summary>
        static PaqueteDAO()
        {
            PaqueteDAO._conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True");
            PaqueteDAO._comando = new SqlCommand();
            PaqueteDAO._comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO._comando.Connection = PaqueteDAO._conexion;
        }

        /// <summary>
        /// Carga campos en la base de datos.
        /// </summary>
        /// <param name="p">Paquete in insertar en la base de datos.</param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            try
            {
                string alumno = "Aguirre Sebastián Nicolás";
                string sql = String.Format("INSERT INTO Paquetes (direccionEntrega,trackingID,alumno) VALUES('{0}','{1}','{2}');",  p.DireccionEntrega,
                                                                                                                                    p.TrackingID,
                                                                                                                                    alumno);
                PaqueteDAO._comando.CommandText = sql;
                PaqueteDAO._conexion.Open();
                PaqueteDAO._comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                PaqueteDAO._conexion.Close();
            }
            return true;
        }

        #endregion
    }
}
