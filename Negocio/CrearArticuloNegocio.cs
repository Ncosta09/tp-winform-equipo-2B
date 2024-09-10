using Dominio;
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
				datos.setConsulta("insrt into Articulos...");
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
