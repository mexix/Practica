using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lavanderia
{
    class Conexion
    {
        static MySqlConnection conex;
        static string cadenaconex;
        
        public static MySqlConnection conexion()
        {
            cadenaconex = "server= localhost; Database=escuela; uid=root; pwd=";
            conex = new MySqlConnection(cadenaconex);
            return conex;

        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void CerrarConexion()
        {
            conex.Close();
        }




    }
}
