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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS02; database = CATALOGO_P3_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, C.Descripcion AS Categoria, M.Descripcion AS Marca, I.ImagenUrl AS Imagen FROM ARTICULOS A, IMAGENES I, CATEGORIAS C, MARCAS M WHERE I.IdArticulo = A.Id AND C.Id = A.IdCategoria AND M.Id = A.IdMarca"; //consulta de seleccion de la DB
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Articulo art = new Articulo();

                    art.ID = (int)lector["Id"];
                    art.Codigo = (string)lector["Codigo"];
                    art.Nombre = (string)lector["Nombre"];
                    art.Descripcion = (string)lector["Descripcion"];
                    art.Precio = (decimal)lector["Precio"];
                    //Categoria
                    art.Categoria = new Categoria();
                    art.Categoria.Descripcion = (string)lector["Categoria"];
                    //Marca
                    art.Marca = new Marca();
                    art.Marca.Descripcion = (string)lector["Marca"];
                    //Imagen
                    art.Imagen = new Imagen();
                    art.Imagen.imgUrl = (string)lector["Imagen"];

                    lista.Add(art); 
                }

                conexion.Close();
                return lista;
            }
            catch(Exception ex) {
                
                throw(ex); 
            }

        }
    }
}
