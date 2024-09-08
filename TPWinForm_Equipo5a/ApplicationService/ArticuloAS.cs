using System;
using System.Collections.Generic;
using Model;
using DataPersistence;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ApplicationService
{
    public class ArticuloAS
    {

        /*public Articulo insertarArt(Articulo art)
        {
            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();

            query.configSqlQuery("INSERT INTO ARTICULOS (Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio),(@codArt, @descArt)";
            query.configSqlConexion(conexion.obtenerConexion());
            query.configSqlParams("@codArt", art.Codigo);
            //query.configSqlParams("@codArt", codFiltrado);

            conexion.abrirConexion();
            query.ejecutarSelect();
            conexion.cerrarConexion();



        }
        */

        public Articulo buscarArt(string codFiltrado)
        {

            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();

            List<Articulo> lista = new List<Articulo>();
            Articulo auxArt = new Articulo();
            SqlDataReader result;


            try
            {

                query.configSqlQuery("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS WHERE Codigo = @codArt");
                query.configSqlConexion(conexion.obtenerConexion());
                query.configSqlParams("@codArt", codFiltrado);

                conexion.abrirConexion();
                result = query.ejecutarSelect();



                while (result.Read())
                {
                    auxArt.Id = (int)result["Id"];
                    auxArt.Codigo = (string)result["Codigo"];
                    auxArt.Nombre = (string)result["Nombre"];
                    auxArt.Descripcion = (string)result["Descripcion"];
                    auxArt.IdMarca = (int)result["IdMarca"];
                    auxArt.IdCategoria = (int)result["IdCategoria"];
                    auxArt.Precio = (decimal)result["Precio"];


                    lista.Add(auxArt);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return auxArt;
        }

        public List<Articulo> listar()
        {
            List <Articulo> lista = new List<Articulo>();
            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();
            SqlDataReader result;
            

            try
            {

                query.configSqlQuery("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS");
                query.configSqlConexion(conexion.obtenerConexion());

                conexion.abrirConexion();
                result = query.ejecutarSelect();

                while (result.Read())
                {
                    Articulo auxArt = new Articulo();
                    auxArt.Id = (int)result["Id"];
                    auxArt.Codigo = (string)result["Codigo"];
                    auxArt.Nombre = (string)result["Nombre"];
                    auxArt.Descripcion = (string)result["Descripcion"];
                    auxArt.IdMarca = (int)result["IdMarca"];
                    auxArt.IdCategoria = (int)result["IdCategoria"];
                    auxArt.Precio = (decimal)result["Precio"];


                    lista.Add(auxArt);
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
