﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CrearArticuloNegocio
    {
        public void crear(Articulo nuevo)
        {
			AccesoDatos datos = new AccesoDatos();

			try
			{
                //Consulta a la DB ¬
                datos.setConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @idCategoria, @idMarca)");
                datos.setParametro("@Codigo", nuevo.Codigo);
                datos.setParametro("@Nombre", nuevo.Nombre);
                datos.setParametro("@Descripcion", nuevo.Descripcion);
                datos.setParametro("@Precio", nuevo.Precio);
                datos.setParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setParametro("@idMarca", nuevo.Marca.Id);

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

        public void agregarImagen(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT TOP 1 Id FROM ARTICULOS ORDER BY Id DESC");
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int idArticulo = (int)datos.Lector["Id"];

                    datos.setConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                    datos.setParametro("@idArticulo", idArticulo);
                    datos.setParametro("@imagenUrl", art.Imagen.imgUrl);

                    datos.ejecutarAccion();
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
    }
}
