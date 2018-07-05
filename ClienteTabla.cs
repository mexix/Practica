using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Lavanderia
{
    class ClienteTabla:Conexion
    {
        string instruccion;
        public DataTable VistaTabla()
        {
            instruccion = "select * from alumno";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;

        }

       
           public bool insertar(string matricula, string nombre_a, string apaterno, string amaterno, string grado_a, string sexo)
        {
            
            SqlCommand com = new SqlCommand(string.Format("insert into alumno values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", new string[] { matricula, nombre_a, apaterno, amaterno, grado_a, sexo }));
            int filasafectadas = com.ExecuteNonQuery();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Eliminar(string nombre_a)
        {

            SqlCommand com = new SqlCommand(string.Format("delate from alumno where NOMBRE_A = {0}", nombre_a ));
            int filasafectadas = com.ExecuteNonQuery();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string nombre_a, string apaterno, string amaterno, string grado_a)
        {

            SqlCommand com = new SqlCommand(string.Format("update alumno  set apaterno = '{0}', amaterno ='{1}', grado_a = '{2}' where Nombre = {3}",new string[] { apaterno, amaterno, grado_a, nombre_a }));
            int filasafectadas = com.ExecuteNonQuery();
            if (filasafectadas > 0) return true;
            else return false;
        }




        /*public static MySqlDataReader consulta (string c)
        {

        }*/

       
    }
}
