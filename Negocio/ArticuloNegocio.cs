using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

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
                datos.setConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, C.Descripcion AS Categoria, M.Descripcion AS Marca, I.ImagenUrl AS Imagen FROM ARTICULOS A, IMAGENES I, CATEGORIAS C, MARCAS M WHERE I.IdArticulo = A.Id AND C.Id = A.IdCategoria AND M.Id = A.IdMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();

                    art.ID = (int)datos.Lector["Id"];
                    art.Codigo = (string)datos.Lector["Codigo"];
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["Descripcion"];
                    art.Precio = (decimal)datos.Lector["Precio"];
                    //Categoria
                    art.Categoria = new Categoria();
                    art.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    //Marca
                    art.Marca = new Marca();
                    art.Marca.Descripcion = (string)datos.Lector["Marca"];
                    //Imagen
                    art.Imagen = new Imagen();
                    art.Imagen.imgUrl = (string)datos.Lector["Imagen"];

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
    }
}
