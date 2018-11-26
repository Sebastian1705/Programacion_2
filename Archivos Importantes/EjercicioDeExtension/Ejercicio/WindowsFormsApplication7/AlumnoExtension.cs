using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication7
{
    public static class AlumnoExtension
    {
        public static bool Guardar(this Alumno al)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApplication7.Properties.Settings.MyDatabase_1ConnectionString"].ConnectionString);

            string sql = "insert into Alumno (id,Nombre) values (" + al.id + ",'" + al.Nombre + "')";
            SqlCommand cm = new SqlCommand(sql, cn);
            try{
                cn.Open();

                cm.ExecuteNonQuery();
                
            }
            catch(Exception e){
                return false;                           
            }
            finally{
                cn.Close();
            }
            return true;
        }

    }
}
