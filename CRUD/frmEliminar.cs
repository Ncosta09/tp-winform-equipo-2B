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
    public partial class frmEliminar : Form
    {
        private List<Articulo> listaArticulo;
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.Imagen.imgUrl);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxImagenArticulo.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarArticuloNegocio negocio = new EliminarArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro que queres eliminarlo? ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarImagen(seleccionado.ID);
                    negocio.eliminarArticulo(seleccionado.Codigo);
                    cargar();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void filtroBuscar()
        {
            List<Articulo> listaFiltrada;

            if (tbxBuscar.Text != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(tbxBuscar.Text.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtroBuscar();
        }

        private void tbxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filtroBuscar();
                e.SuppressKeyPress = true;
            }
        }
    }
}