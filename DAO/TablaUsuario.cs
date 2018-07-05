using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lavanderia.DAO
{
    class TablaUsuario:ConexionDAO
    {


        public static void insertar(Usuario u)
        {
            MySqlConnection conectar = ConexionDAO.getconexion();
            String consulta = "Query";//ejemplo: INSERT INTO Usuario (nombre, apaterno, amaterno, edad)
            //VALUES (.....)
            MySqlCommand comando = new MySqlCommand(consulta, conectar);
            MySqlDataReader resultado;
            conectar.Open();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro almacenado");
            conectar.Close();

        }

        public static void Actualizar(Usuario u)
        {
            MySqlConnection conectar = ConexionDAO.getconexion();
            String consulta = "Query";//ejemplo: update Usuario (nombre, apaterno, amaterno, edad)
            //VALUES (.....)
            MySqlCommand comando = new MySqlCommand(consulta, conectar);
            MySqlDataReader resultado;
            conectar.Open();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro almacenado");
            conectar.Close();

        }













        //static private DataSet CreateCommandAndUpdate(
        //  string connectionString,
        //  string queryString)
        // {
        //     DataSet dataSet = new DataSet();

        //     using (OleDbConnection connection =
        //                new OleDbConnection(connectionString))
        //     {
        //         connection.Open();
        //         OleDbDataAdapter adapter =
        //             new OleDbDataAdapter();
        //         adapter.SelectCommand =
        //             new OleDbCommand(queryString, connection);
        //         OleDbCommandBuilder builder =
        //             new OleDbCommandBuilder(adapter);

        //         adapter.Fill(dataSet);

        //         // Code to modify data in the DataSet here.

        //         // Without the OleDbCommandBuilder, this line would fail.
        //         adapter.UpdateCommand = builder.GetUpdateCommand();
        //         adapter.Update(dataSet);
        //     }
        //     return dataSet;
        // }
    }







        }



    

