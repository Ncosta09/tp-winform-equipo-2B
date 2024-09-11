using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Security.Cryptography.X509Certificates;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //Consulta a la DB ¬
                datos.setConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, C.Descripcion AS Categoria, M.Descripcion AS Marca, I.ImagenUrl AS Imagen FROM ARTICULOS A LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria LEFT JOIN MARCAS M ON M.Id = A.IdMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();

                    art.ID = (int)datos.Lector["Id"];
                    art.Codigo = datos.Lector["Codigo"] is DBNull ? "Sin Codigo" : (string)datos.Lector["Codigo"];
                    art.Nombre = datos.Lector["Nombre"] is DBNull ? "Sin Nombre" : (string)datos.Lector["Nombre"];
                    art.Descripcion = datos.Lector["Descripcion"] is DBNull ? "Sin Descripcion" : (string)datos.Lector["Descripcion"];
                    art.Precio = datos.Lector["Precio"] is DBNull ? 0000 : (decimal)datos.Lector["Precio"];
                    //Categoria
                    art.Categoria = new Categoria();
                    art.Categoria.Descripcion = datos.Lector["Categoria"] is DBNull ? "Sin Categoria" : (string)datos.Lector["Categoria"];
                    //Marca
                    art.Marca = new Marca();
                    art.Marca.Descripcion = datos.Lector["Marca"] is DBNull ? "Sin Marca" : (string)datos.Lector["Marca"];
                    //Imagen
                    art.Imagen = new Imagen();
                    art.Imagen.imgUrl = datos.Lector["Imagen"] is DBNull ? "Sin Imagen" : (string)datos.Lector["Imagen"];

                    lista.Add(art);
                }


                return lista;
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

            public List<Articulo> filtrar (string campo, string criterio, string filtro)
            {
                List<Articulo> lista = new List<Articulo>();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, I.ImagenUrl, A.Precio from ARTICULOS A, IMAGENES I, MARCAS M, CATEGORIAS C WHERE A.Id = I.IdArticulo AND A.IdMarca = M.Id AND A.IdCategoria = C.Id AND ";
                    switch (campo)
                    {
                        case "Nombre":
                            switch (criterio)
                            {
                                case "Empieza con":
                                    consulta += "Nombre like '" + filtro + "%'";
                                    break;

                                case "Termina con":
                                    consulta += "Nombre like '%" + filtro + "'";
                                    break;

                                case "Contiene":
                                    consulta += "Nombre like '%" + filtro + "%'";
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case "Codigo":
                            switch (criterio)
                            {
                                case "Empieza con":
                                    consulta += "Codigo like '" + filtro + "%'";
                                    break;

                                case "Termina con":
                                    consulta += "Codigo like '%" + filtro + "'";
                                    break;

                                case "Contiene":
                                    consulta += "Codigo like '%" + filtro + "%'";
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case "Descripción":
                            switch (criterio)
                            {
                                case "Empieza con":
                                    consulta += "A.Descripcion like '" + filtro + "%'";
                                    break;

                                case "Termina con":
                                    consulta += "A.Descripcion like '%" + filtro + "'";
                                    break;

                                case "Contiene":
                                    consulta += "A.Descripcion like '%" + filtro + "%'";
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case "Marca":
                            switch (criterio)
                            {
                                case "Empieza con":
                                    consulta += "M.Descripcion like '" + filtro + "%'";
                                    break;

                                case "Termina con":
                                    consulta += "M.Descripcion like '%" + filtro + "'";
                                    break;

                                case "Contiene":
                                    consulta += "M.Descripcion like '%" + filtro + "%'";
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case "Categoria":
                            switch (criterio)
                            {
                                case "Empieza con":
                                    consulta += "C.Descripcion like '" + filtro + "%'";
                                    break;

                                case "Termina con":
                                    consulta += "C.Descripcion like '%" + filtro + "'";
                                    break;

                                case "Contiene":
                                    consulta += "C.Descripcion like '%" + filtro + "%'";
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case "Precio":
                            switch (criterio)
                            {
                                case "Mayor a":
                                    consulta += "Precio > " + filtro;
                                    break;

                                case "Menor a":
                                    consulta += "Precio < " + filtro;
                                    break;

                                case "Igual a":
                                    consulta += "Precio = " + filtro;
                                    break;

                                default:
                                    break;
                            }
                            break;

                        default:
                            break;
                    }
                    datos.setConsulta(consulta);
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Articulo articulo = new Articulo();
                        articulo.Codigo = (string)datos.Lector["Codigo"];
                        articulo.Nombre = (string)datos.Lector["Nombre"];
                        articulo.Descripcion = (string)datos.Lector["Descripcion"];
                        articulo.Marca = new Marca();
                        articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                        articulo.Categoria = new Categoria();
                        articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                        articulo.Imagen = new Imagen();
                        articulo.Imagen.imgUrl = (string)datos.Lector["ImagenUrl"];
                        articulo.Precio = (decimal)datos.Lector["Precio"];

                        lista.Add(articulo);

                    }


                    return lista;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            }
        }
    

