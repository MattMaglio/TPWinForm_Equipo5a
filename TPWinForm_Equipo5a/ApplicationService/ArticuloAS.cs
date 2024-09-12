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
        public Articulo buscarArt(string codFiltrado)
        {

            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();

            List<Articulo> lista = new List<Articulo>();
            Articulo auxArt = new Articulo();
            SqlDataReader result;


            try
            {

                query.configSqlQuery("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion,m.Id AS 'Id Marca', m.Descripcion AS 'Marca',c.Id AS 'Id Categoria', c.Descripcion AS 'Categoria', a.Precio FROM ARTICULOS a LEFT JOIN MARCAS m ON m.Id = a.IdMarca LEFT JOIN CATEGORIAS c ON c.Id = a.IdCategoria WHERE Codigo = @codArt");
                query.configSqlConexion(conexion.obtenerConexion());
                query.configSqlParams("@codArt", codFiltrado);

                conexion.abrirConexion();
                result = query.ejecutarConsulta();



                while (result.Read())
                {
                    auxArt.Id = (int)result["Id"];
                    auxArt.Codigo = (string)result["Codigo"];
                    auxArt.Nombre = (string)result["Nombre"];
                    auxArt.Descripcion = (string)result["Descripcion"];
                    auxArt.Marca = new Marca();
                    if (!(result["Id Marca"] is DBNull))
                    {
                        auxArt.Marca.Id = (int)result["Id Marca"];
                        auxArt.Marca.Descripcion = (string)result["Marca"];
                    }
                    else
                    {
                        auxArt.Marca.Descripcion = "Sin marca";
                    }
                    auxArt.Categoria = new Categoria();
                    if (!(result["Id Categoria"] is DBNull))
                    {
                        auxArt.Categoria.Id = (int)result["Id Categoria"];
                        auxArt.Categoria.Descripcion = (string)result["Categoria"];
                    }
                    else
                    {
                        auxArt.Categoria.Descripcion = "Sin categoria";
                    }

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

                query.configSqlQuery("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion AS 'Marca', c.Descripcion AS 'Categoria', a.Precio FROM ARTICULOS a LEFT JOIN MARCAS m ON m.Id = a.IdMarca LEFT JOIN CATEGORIAS c ON c.Id = a.IdCategoria");
                query.configSqlConexion(conexion.obtenerConexion());

                conexion.abrirConexion();
                result = query.ejecutarConsulta();

                while (result.Read())
                {
                    Articulo auxArt = new Articulo();

                    auxArt.Id = (int)result["Id"];
                    auxArt.Codigo = (string)result["Codigo"];
                    auxArt.Nombre = (string)result["Nombre"];
                    auxArt.Descripcion = (string)result["Descripcion"];
                    auxArt.Marca = new Marca();
                    if (!(result.IsDBNull(result.GetOrdinal("Marca"))))
                    {
                        auxArt.Marca.Descripcion = (string)result["Marca"];
                    }
                    else 
                    {
                        auxArt.Marca.Descripcion = "Sin marca";
                    }
                    auxArt.Categoria = new Categoria();
                    if (!(result["Categoria"] is DBNull))
                    {
                        auxArt.Categoria.Descripcion = (string)result["Categoria"];
                    }
                    else
                    {
                        auxArt.Categoria.Descripcion = "Sin categoria";
                    }
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

        public List<Articulo> listarFrmListado()
        {
            List<Articulo> lista = new List<Articulo>();
            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();
            SqlDataReader result;


            try
            {

                query.configSqlQuery("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdMarca, a.IdCategoria, " +
                    "a.Precio, i.IdArticulo, i.ImagenUrl FROM ARTICULOS a JOIN IMAGENES i ON a.Id = i.IdArticulo");
                query.configSqlConexion(conexion.obtenerConexion());

                conexion.abrirConexion();
                result = query.ejecutarConsulta();

                while (result.Read())
                {
                    Articulo auxArt = new Articulo();

                    auxArt.Id = (int)result["Id"];
                    auxArt.Codigo = (string)result["Codigo"];
                    auxArt.Nombre = (string)result["Nombre"];
                    auxArt.Descripcion = (string)result["Descripcion"];
                    auxArt.Precio = (decimal)result["Precio"];

                    auxArt.Marca = new Marca();
                    auxArt.Marca.Id = (int)result["IdMarca"];

                    auxArt.Categoria = new Categoria();
                    auxArt.Categoria.Id = (int)result["IdCategoria"];

                    // traigo datos de la tabla imagenes
                    auxArt.Imagen = new Imagen();
                    if (!(result["IdArticulo"] is DBNull))
                    {
                        auxArt.Imagen.IdArticulo = (int)result["IdArticulo"];
                    }
                    if (!(result["ImagenUrl"] is DBNull))
                    {
                        auxArt.Imagen.ImagenUrl = (string)result["ImagenUrl"];
                    }



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

        public void actualizarArticulo(Articulo art)
        {
            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();

            List<Articulo> lista = new List<Articulo>();
            Articulo auxArt = new Articulo();

            try
            {

                query.configSqlQuery("UPDATE ARTICULOS SET Nombre = @nombre, Descripcion = @desc, IdCategoria = @idCat, IdMarca = @idMarca, Precio = @precio WHERE Codigo = @codArt");
                query.configSqlConexion(conexion.obtenerConexion());
                query.configSqlParams("@codArt", art.Codigo);
                query.configSqlParams("@nombre", art.Nombre);
                query.configSqlParams("@desc", art.Descripcion);
                query.configSqlParams("@idCat", art.Categoria.Id);
                query.configSqlParams("@idMarca", art.Marca.Id);
                query.configSqlParams("@precio", Convert.ToDecimal(art.Precio));

                conexion.abrirConexion();
                query.ejecutarAccion();
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

        public void borrarArticulo(Articulo art){

            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();

            try
            {

                query.configSqlQuery("DELETE FROM ARTICULOS WHERE Codigo = @codArt");
                query.configSqlConexion(conexion.obtenerConexion());
                query.configSqlParams("@codArt", art.Codigo);

                conexion.abrirConexion();
                query.ejecutarAccion();
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

        public void eliminar(int id)
        {
            DataAccess datos = new DataAccess();
            try
            {
                // Configura el comando para eliminar
                using (SqlCommand comando = new SqlCommand("DELETE FROM ARTICULOS WHERE Id = @id", datos.obtenerConexion()))
                {
                    // Agrega el parámetro al comando
                    comando.Parameters.AddWithValue("@id", id);

                    // Abre la conexión
                    datos.abrirConexion();

                    // Ejecuta el comando
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        //****************************************************************************************************************************
        public int agregarArt(Articulo art)
        {
            DataAccess conexion = new DataAccess();  // Gestiono la conexión a la base de datos
            DataManipulator query = new DataManipulator();  // Gestiono la ejecución de consultas

            try
            {
                // Configuro query de inserción y recuperación del ID insertado
                query.configSqlQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES(@codArt, @nombreArt, @descArt, @idMarca, @idCategoria, @precioArt); SELECT SCOPE_IDENTITY();");

                // Configuro conexión a DB
                query.configSqlConexion(conexion.obtenerConexion());

                // Abro la conexión
                conexion.abrirConexion();

                // Parámetros de la query
                query.configSqlParams("@codArt", art.Codigo);
                query.configSqlParams("@nombreArt", art.Nombre);
                query.configSqlParams("@descArt", art.Descripcion);
                query.configSqlParams("@idMarca", art.Marca.Id);
                query.configSqlParams("@idCategoria", art.Categoria.Id);
                query.configSqlParams("@precioArt", art.Precio);

                // Ejecutar la query y obtener el ID generado
                int idGenerado = Convert.ToInt32(query.ejecutarEscalar());

                return idGenerado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el artículo en la base de datos", ex);
            }
            finally
            {
                // Cierro la conexión
                conexion.cerrarConexion();
            }
        }



        //*************************************************************************************************************************

        /*public List<Articulo> listaFiltrada (string categoria, string marca)
        {
            List<Articulo> listaArtFiltrados = new List<Articulo>();
            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();
            SqlDataReader result;

            try
            {   //OBTENGO LA CONSULTA
               string queryConsulta = @"SELECT a.id, a.Nombre, c.Descripcion AS Categoria, m.Descripcion AS Marca FROM ARTICULOS a JOIN CATEGORIAS c ON a.Id = c.Id JOIN MARCAS m ON a.Id = m.Id WHERE 1=1";
               
                //filtros para cuando eliga categoria y/o mara agrege esa consulta adicional
                /*if (!string.IsNullOrEmpty(categoria))
                {
                    queryConsulta += " AND c.Descripcion = @Descripcion";
                }
                if (!string.IsNullOrEmpty(marca))
                {
                    queryConsulta += " AND m.Descripcion = @Descripcion";
                }*/
        /* if(!string.IsNullOrEmpty(categoria))
{
             queryConsulta += " AND a.IdCategoria = @IdCategoria"; // Filtrar por Id de la categoría
             //query.configSqlParametro("@IdCategoria", categoria);  // Asigna el valor del parámetro
         }
         if (!string.IsNullOrEmpty(marca))
         {
             queryConsulta += " AND a.IdMarca = @IdMarca"; // Filtrar por Id de la marca
             //query.configSqlParametro("@IdMarca", marca);  // Asigna el valor del parámetro
         }
         query.configSqlQuery(queryConsulta);
         query.configSqlConexion(conexion.obtenerConexion());


         conexion.abrirConexion();
         result = query.ejecutarConsulta();
         while (result.Read())
         {
             Articulo aux = new Articulo();

             aux.Id = (int)result["Id"];
             aux.Nombre = (string)result["Nombre"];
             aux.Marca.Descripcion = (string)result["Descripcion"];
             aux.Categoria.Descripcion = (string)result["Descripcion"];

             listaArtFiltrados.Add(aux);
         }
         return listaArtFiltrados;
     }
     catch (Exception ex)
     {

         throw ex;
     }
     finally
     {
         conexion.cerrarConexion();
     }
 }*/
        
        /*public List<Articulo> buscarArt(string categoria, string marca)
        {

            DataAccess conexion = new DataAccess();
            DataManipulator query = new DataManipulator();

            List<Articulo> lista = new List<Articulo>();
            Articulo auxArt = new Articulo();
            SqlDataReader result;


            try
            {
                /*if (categoria != null && marca != null)
                {

                }
                else if (marca != null)
                {

                }
                else
                {
                    categoria != null;
                }
                */
                /*
                switch 
                    case 1:
                    "SELECT a.Id FROM articulos a where marca = @marca";
                    query.configSqlParams("@Marca", marca);

                case 2:
                    "SELECT a.Id FROM articulos a where categoria = @categoria";
                    query.configSqlParams("@Categoria", categoria);

                case 3:
                    "SELECT a.Id FROM articulos a where marca = @marca and categoria = @categoria";
                    query.configSqlParams("@Marca", marca);
                    query.configSqlParams("@Categoria", categoria);

                break;
                
                query.configSqlQuery(queryConsulta);

                query.configSqlConexion(conexion.obtenerConexion());

                conexion.abrirConexion();
                result = query.ejecutarConsulta();



                while (result.Read())
                {
                    auxArt.Id = (int)result["Id"];
                    auxArt.Codigo = (string)result["Codigo"];
                    auxArt.Nombre = (string)result["Nombre"];
                    auxArt.Descripcion = (string)result["Descripcion"];
                    auxArt.Marca = new Marca();
                    if (!(result["Id Marca"] is DBNull))
                    {
                        auxArt.Marca.Id = (int)result["Id Marca"];
                        auxArt.Marca.Descripcion = (string)result["Marca"];
                    }
                    else
                    {
                        auxArt.Marca.Descripcion = "Sin marca";
                    }
                    auxArt.Categoria = new Categoria();
                    if (!(result["Id Categoria"] is DBNull))
                    {
                        auxArt.Categoria.Id = (int)result["Id Categoria"];
                        auxArt.Categoria.Descripcion = (string)result["Categoria"];
                    }
                    else
                    {
                        auxArt.Categoria.Descripcion = "Sin categoria";
                    }

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

            return lista;
        }*/
        
    }
}
