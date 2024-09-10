using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace CRUD
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            CrearArticuloNegocio artNegocio = new CrearArticuloNegocio();

            try
            {
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Precio = int.Parse(txtPrecio.Text);
                art.Imagen = new Imagen { imgUrl = txtUrl.Text }; //VER ESTO SI ESTA OK ??
                art.Categoria = (Categoria)cbCategoria.SelectedItem;
                art.Marca = (Marca)cbMarca.SelectedItem;

                artNegocio.crear(art);
                //artNegocio.agregarImagen(art);
                MessageBox.Show("Agregado con Exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            MarcaNegocio marNegocio = new MarcaNegocio();

            try
            {
                cbCategoria.DataSource = catNegocio.listar();
                cbMarca.DataSource = marNegocio.listar();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticuloPreview.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArticuloPreview.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }
    }
}
