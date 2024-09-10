using System;
using System.Data.SqlClient;

namespace DataPersistence
{
    public class DataManipulator
    {
        public SqlCommand sqlQuery { get; set; }



        public void configSqlQuery(string query)
        {
            sqlQuery = new SqlCommand();
            sqlQuery.CommandType = System.Data.CommandType.Text;
            sqlQuery.CommandText = query;
        }

        public void configSqlConexion(SqlConnection conexion)
        {
            if (sqlQuery == null)
            {
                sqlQuery = new SqlCommand();
            }

            sqlQuery.Connection = conexion;
        }

        public SqlDataReader ejecutarConsulta()
        {
            if (sqlQuery.Connection == null)
            {
                throw new InvalidOperationException("La conexión no ha sido configurada.");
            }

            SqlDataReader result = sqlQuery.ExecuteReader();
            return result;
        }

        public void ejecutarAccion()
        {
            if (sqlQuery.Connection == null)
            {
                throw new InvalidOperationException("La conexión no ha sido configurada.");
            }

            sqlQuery.ExecuteNonQuery();
             
        }

        public void configSqlParams(string nombre, object valor)
        {
            sqlQuery.Parameters.AddWithValue(nombre, valor);
        }
        // Ejecuta una acción(como INSERT, UPDATE, DELETE)
        public void ejecutarAccion()
        {
            using (SqlConnection conexion = new SqlConnection(/* aquí tu string de conexión */))
            {
                try
                {
                    sqlQuery.Connection = conexion;
                    conexion.Open();
                    sqlQuery.ExecuteNonQuery(); // Ejecuta el comando, sin esperar un resultado
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar la acción: " + ex.Message);
                }
            }
        }

    }
}
