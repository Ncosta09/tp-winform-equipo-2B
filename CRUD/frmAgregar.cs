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

        private bool validarArticulo()
        {
            if(string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar un numero en el campo precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private bool validarModificar()
        {
            if (cbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una categoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una marca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void limpiarTextbox()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtUrl.Clear();
            lbImagenesAgregar.Items.Clear();
            if (cbCategoria.Items.Count > 0)
            {
                cbCategoria.SelectedIndex = 0;
            }

            if (cbMarca.Items.Count > 0)
            {
                cbMarca.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Articulo art = new Articulo();
            CrearArticuloNegocio artNegocio = new CrearArticuloNegocio();
            ModificarArticuloNegocio artMod = new ModificarArticuloNegocio();

            try
            {
                if (validarArticulo())
                {
                    return;
                }

                if (articulo == null) 
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = Decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                //articulo.Imagen = new Imagen { imgUrl = txtUrl.Text }; VER ESTO SI ESTA OK ??
                


                if (articulo.ID != 0)
                {
                    if (validarModificar())
                    {
                        return;
                    }
                    artMod.modificar(articulo);

                    // Modificar imágenes si el artículo existe
                    List<string> imagenesActuales = artMod.obtenerImagenesPorArticulo(articulo.ID);

                    // Eliminar imágenes que ya no están en la lista
                    foreach (string imagenUrl in imagenesActuales)
                    {
                        if (!imagenesUrls.Contains(imagenUrl))
                        {
                            artMod.eliminarImagen(imagenUrl);
                        }
                    }

                    // Agregar nuevas imágenes
                    foreach (string imagenUrl in imagenesUrls)
                    {
                        if (!imagenesActuales.Contains(imagenUrl))
                        {
                            artMod.modificarImagen(articulo.ID, imagenUrl);
                        }
                    }

                    MessageBox.Show("Articulo Modificado con Exito!");
                    this.Close();
                }
                else
                {
                    artNegocio.crear(articulo);
                    int idArticulo = artNegocio.obtenerUltimoId();
                    if (idArticulo > 0)
                    {
                        foreach (string imagenUrl in imagenesUrls)
                        {
                            artNegocio.agregarImagen(idArticulo, imagenUrl);
                        }
                    }

                    MessageBox.Show("Articulo Agregado con Exito!");
                    limpiarTextbox();
                }

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
            ModificarArticuloNegocio artMod = new ModificarArticuloNegocio();


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
                    //txtUrl.Text = articulo.Imagen.imgUrl;
                    //cargarImagen(articulo.Imagen.imgUrl);

                    // Aquí cargas las imágenes existentes
                    List<string> imagenesUrlsCargadas = artMod.obtenerImagenesPorArticulo(articulo.ID);

                    if (imagenesUrlsCargadas != null && imagenesUrlsCargadas.Count > 0)
                    {
                        imagenesUrls.Clear(); // Limpia la lista existente
                        lbImagenesAgregar.Items.Clear();
                        foreach (string imagenUrl in imagenesUrlsCargadas)
                        {
                            imagenesUrls.Add(imagenUrl);  // Añade a la lista interna
                            lbImagenesAgregar.Items.Add(imagenUrl);  // Añade al ListBox
                        }
                    }
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

        List<string> imagenesUrls = new List<string>();
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                if (!imagenesUrls.Contains(txtUrl.Text)) // Verifica si ya existe
                {
                    imagenesUrls.Add(txtUrl.Text);
                    lbImagenesAgregar.Items.Add(txtUrl.Text);  // lstImagenes es el ListBox que muestra las URLs
                }
                else
                {
                    MessageBox.Show("Esta imagen ya fue agregada.");
                }
                txtUrl.Clear();  // Limpiar el campo de texto
            }
        }

        private void lbImagenesAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbImagenesAgregar.SelectedIndex != -1)
            {
                string selectedImageUrl = lbImagenesAgregar.SelectedItem.ToString();
                cargarImagen(selectedImageUrl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbImagenesAgregar.SelectedIndex != -1)
            {
                // Obtener la URL seleccionada
                string selectedImageUrl = lbImagenesAgregar.SelectedItem.ToString();

                // Eliminar la URL de la lista de URLs
                imagenesUrls.Remove(selectedImageUrl);

                // Eliminar la URL del ListBox
                lbImagenesAgregar.Items.Remove(selectedImageUrl);

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una imagen para eliminar.");
            }
        }
    }
}
