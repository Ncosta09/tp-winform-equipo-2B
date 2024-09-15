using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ModificarArticuloNegocio
    {
        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("UPDATE ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdCategoria = @idCategoria, IdMarca = @idMarca WHERE Id = @idArticulo");
                datos.setParametro("@Codigo", modificar.Codigo);
                datos.setParametro("@Nombre", modificar.Nombre);
                datos.setParametro("@Descripcion", modificar.Descripcion);
                datos.setParametro("@Precio", modificar.Precio);
                datos.setParametro("@idCategoria", modificar.Categoria.Id);
                datos.setParametro("@idMarca", modificar.Marca.Id);
                datos.setParametro("@idArticulo", modificar.ID);

                datos.ejecutarAccion();
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

        public void modificarImagen(int idArticulo, string imagenUrl)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                datos.setParametro("@idArticulo", idArticulo);
                datos.setParametro("@imagenUrl", imagenUrl);

                datos.ejecutarAccion();
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
        public List<string> obtenerImagenesPorArticulo(int idArticulo)
        {
            List<string> imagenes = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setParametro("@idArticulo", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    imagenes.Add(datos.Lector["ImagenUrl"].ToString());
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

            return imagenes;
        }

        public void eliminarImagen(string imagenUrl)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("DELETE FROM IMAGENES WHERE ImagenUrl LIKE @imagenUrl");
                //datos.setParametro("@idArticulo", idArticulo); //IdArticulo = @idArticulo AND
                datos.setParametro("@imagenUrl", imagenUrl);
                datos.ejecutarAccion();
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
