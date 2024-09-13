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
    public partial class frmVerDetalle : Form
    {
        private Articulo articulo;
        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            try
            {
                tbxCodigo.Text = articulo.Codigo;
                tbxNombre.Text = articulo.Nombre;
                tbxDescripcion.Text = articulo.Descripcion;
                tbxPrecio.Text = articulo.Precio.ToString();
                CargarImagen(articulo.Imagen.imgUrl);
                tbxCategoria.Text= articulo.Categoria.Descripcion.ToString();
                tbxMarca.Text= articulo.Marca.Descripcion.ToString();
                tbxCodigo.ReadOnly = true;
                tbxNombre.ReadOnly = true;
                tbxDescripcion.ReadOnly = true;
                tbxPrecio.ReadOnly = true;
                tbxCategoria.ReadOnly = true;
                tbxMarca.ReadOnly = true;

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


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
