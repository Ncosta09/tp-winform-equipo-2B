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
    public partial class frmModificar : Form
    {
        private Articulo articulo = null;
     
        public frmModificar(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
        }

        private void FormModificarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            try
            {
                CategoriaNegocio negocioCat = new CategoriaNegocio();
                cbxCategoria.DataSource = negocioCat.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.Refresh();

                MarcaNegocio negocioMarca = new MarcaNegocio();
                cbxMarca.DataSource = negocioMarca.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.Refresh();

                tbxCodigo.Text = articulo.Codigo;
                tbxNombre.Text = articulo.Nombre;
                tbxDescripcion.Text = articulo.Descripcion;
                Imagen imagen = new Imagen();
                tbxUrl.Text = imagen.imgUrl;// ver porque no quiere cargar
                CargarImagen(tbxUrl.Text);
                tbxPrecio.Text = articulo.Precio.ToString();
                cbxCategoria.SelectedValue = articulo.Categoria.Id;
                cbxMarca.SelectedValue = articulo.Marca.Id;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://cdn.icon-icons.com/icons2/3001/PNG/512/default_filetype_file_empty_document_icon_187718.png");
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            ImagenNegocio ImaNegocio = new ImagenNegocio();
            try
            {
                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
               // articulo.Imagen = (Imagen)int.Parse(tbxUrl.Text); VER CASTEO PARA QUE FUNCIONE
                articulo.Precio = int.Parse(tbxPrecio.Text);
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                artNegocio.modificar(articulo);
                //ImaNegocio.modificar(articulo);

                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
