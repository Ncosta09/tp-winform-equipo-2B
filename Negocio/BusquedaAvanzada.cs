using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class BusquedaAvanzada
    {
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, C.Id AS CatId, C.Descripcion AS Categoria, M.Id AS MarId, M.Descripcion AS Marca, I.ImagenUrl AS Imagen FROM ARTICULOS A LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria LEFT JOIN MARCAS M ON M.Id = A.IdMarca WHERE ";
                switch (campo)
                {
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += "A.Nombre like '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "A.Nombre like '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "A.Nombre like '%" + filtro + "%'";
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Codigo":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += "A.Codigo like '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "A.Codigo like '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "A.Codigo like '%" + filtro + "%'";
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
                                consulta += "A.Precio > " + filtro;
                                break;

                            case "Menor a":
                                consulta += "A.Precio < " + filtro;
                                break;

                            case "Igual a":
                                consulta += "A.Precio = " + filtro;
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

                    articulo.ID = (int)datos.Lector["Id"];
                    articulo.Codigo = datos.Lector["Codigo"] is DBNull ? "Sin Codigo" : (string)datos.Lector["Codigo"];
                    articulo.Nombre = datos.Lector["Nombre"] is DBNull ? "Sin Nombre" : (string)datos.Lector["Nombre"];
                    articulo.Descripcion = datos.Lector["Descripcion"] is DBNull ? "Sin Descripcion" : (string)datos.Lector["Descripcion"];
                    articulo.Precio = datos.Lector["Precio"] is DBNull ? 0000 : (decimal)datos.Lector["Precio"];
                    //Categoria
                    articulo.Categoria = new Categoria();
                    //art.Categoria.Id = (int)datos.Lector["CatId"];
                    articulo.Categoria.Id = datos.Lector["CatId"] is DBNull ? 000 : (int)datos.Lector["CatId"];
                    articulo.Categoria.Descripcion = datos.Lector["Categoria"] is DBNull ? "Sin Categoria" : (string)datos.Lector["Categoria"];
                    //Marca
                    articulo.Marca = new Marca();
                    //art.Marca.Id = (int)datos.Lector["MarId"];
                    articulo.Marca.Id = datos.Lector["MarId"] is DBNull ? 000 : (int)datos.Lector["MarId"];
                    articulo.Marca.Descripcion = datos.Lector["Marca"] is DBNull ? "Sin Marca" : (string)datos.Lector["Marca"];
                    //Imagen
                    articulo.Imagen = new Imagen();
                    articulo.Imagen.imgUrl = datos.Lector["Imagen"] is DBNull ? "Sin Imagen" : (string)datos.Lector["Imagen"];

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
