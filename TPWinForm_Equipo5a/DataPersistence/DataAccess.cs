using System.Data.SqlClient;
using System.Configuration;

namespace DataPersistence
{
    public class DataAccess
    {
        private SqlConnection conexionDB;

        public DataAccess()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MiCadenaConexion"].ConnectionString;
            conexionDB = new SqlConnection(connectionString);
        }
        
        public SqlConnection obtenerConexion()
        {
            return conexionDB;
        }

        public void abrirConexion()
        {
            if (conexionDB.State == System.Data.ConnectionState.Closed)
            {
                conexionDB.Open();
            }
        }

        public void cerrarConexion()
        {
            if (conexionDB.State == System.Data.ConnectionState.Open)
            {
                conexionDB.Close();
            }
        }
    }
}
