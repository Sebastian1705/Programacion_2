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
    public class Dao : IArchivos<Votacion>
    {
        #region Fields

        SqlConnection conexion;
        SqlCommand comando;

        #endregion

        #region Methods

        public Dao()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=votacion-sp-2018; Integrated Security=True");
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public bool Guardar(string rutaArchivo, Votacion votacion)
        {
            try
            {
                string alumno = "Sebastian Aguirre";
                string consulta = string.Format("INSERT INTO Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES ('{0}',{1},{2},{3},'{4}')",
                                                votacion.NombreLey, votacion.ContadorAfirmativo, votacion.ContadorNegativo, votacion.ContadorAbstencion, alumno);
                conexion.Open();
                comando.CommandText = consulta;
                comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
