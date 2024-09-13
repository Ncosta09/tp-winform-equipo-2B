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

        public void modificarImagen(Articulo idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setConsulta("UPDATE IMAGENES SET ImagenUrl = @Url WHERE IdArticulo = @idArticulo");
                datos.setParametro("@Url", idArticulo.Imagen.imgUrl);
                datos.setParametro("@idArticulo", idArticulo.ID);

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
