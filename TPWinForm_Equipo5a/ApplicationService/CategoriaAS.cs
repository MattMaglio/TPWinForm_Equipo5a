using DataPersistence;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService
{
    public class CategoriaAS
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();
            SqlDataReader result;

            try
            {

                query.configSqlQuery("SELECT Id, Descripcion FROM CATEGORIAS");
                query.configSqlConexion(conexion.obtenerConexion());

                conexion.abrirConexion();
                result = query.ejecutarConsulta();

                while (result.Read())
                {
                    Categoria auxCat = new Categoria();
                    auxCat.Id = (int)result["Id"];
                    auxCat.Descripcion = (string)result["Descripcion"];

                    lista.Add(auxCat);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }
    }
}
