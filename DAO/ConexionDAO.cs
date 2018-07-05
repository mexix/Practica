using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace Lavanderia.DAO
{
    class ConexionDAO
    {
        public static MySqlConnection conex;
        private static string host = "localhost";
        private static string db = "prueba";
        private static string user = "root";
        private static string pass = "";
        private static string server = "server=" + host + "database=" + db + "uid=" + user + "pw=" + pass;



        
        

        public static MySqlConnection getconexion()
        {
      

            conex = new MySqlConnection(server);
            return conex;

        }

        public static MySqlDataAdapter getTabla(string Tabla)
        {
            MySqlConnection con = getconexion();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT*FROM" + Tabla, con);
            return da;

        }

        protected void Abrirconexion()
        {
            conex.Open();

        }

        protected void cerrarconexion()
        {
            conex.Close();
        }

        





    }
}
