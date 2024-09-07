using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmVerTodos : Form
    {
        private List<Articulo> listaArticulo;
        public frmVerTodos()
        {
            InitializeComponent();
        }

        private void frmVerTodos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["Imagen"].Visible = false;
            //dgvArticulos.Columns["Id"].Visible = false;
            pbArticulo.Load(listaArticulo[0].Imagen.imgUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccion.Imagen.imgUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }
    }
}
