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
        private Articulo articulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articulo = articuloSeleccionado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Articulo art = new Articulo();
            CrearArticuloNegocio artNegocio = new CrearArticuloNegocio();
            ModificarArticuloNegocio artMod = new ModificarArticuloNegocio();

            try
            {
                if (articulo == null) 
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = Decimal.Parse(txtPrecio.Text);
                articulo.Imagen = new Imagen { imgUrl = txtUrl.Text }; //VER ESTO SI ESTA OK ??
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbMarca.SelectedItem;

                if (articulo.ID != 0)
                {
                    artMod.modificar(articulo);
                    artMod.modificarImagen(articulo);
                    MessageBox.Show("Articulo Modificado con Exito!");
                }
                else
                {
                    artNegocio.crear(articulo);
                    int idArticulo = artNegocio.obtenerUltimoId();
                    if (idArticulo > 0)
                    {
                        artNegocio.agregarImagen(idArticulo, articulo.Imagen.imgUrl);
                    }
                    MessageBox.Show("Articulo Agregado con Exito!");
                }

                this.Close();
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
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                cbMarca.DataSource = marNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtId.Text = articulo.ID.ToString();
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;   
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    txtUrl.Text = articulo.Imagen.imgUrl;
                    cargarImagen(articulo.Imagen.imgUrl);
                }
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
                e.Handled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
