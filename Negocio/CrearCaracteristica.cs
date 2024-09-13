using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class CrearCaracteristica
    {

        public void agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //Consulta a la DB ¬
                datos.setConsulta("INSERT INTO MARCAS(Descripcion) VALUES (@Descripcion)");

                datos.setParametro("@Descripcion", nuevo.Descripcion);

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
