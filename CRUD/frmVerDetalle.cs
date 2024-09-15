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
                tbxCodigo.Enabled = false;
                tbxNombre.Enabled = false;
                tbxDescripcion.Enabled = false;
                tbxPrecio.Enabled = false;
                tbxCategoria.Enabled = false;
                tbxMarca.Enabled = false;
                tbxCodigo.BackColor = Color.White;
                tbxCodigo.ForeColor = Color.Black;
                tbxNombre.BackColor = Color.White;
                tbxNombre.ForeColor = Color.Black;
                tbxDescripcion.BackColor = Color.White;
                tbxDescripcion.ForeColor = Color.Black;
                tbxPrecio.BackColor = Color.White;
                tbxPrecio.ForeColor = Color.Black;
                tbxCategoria.BackColor = Color.White;
                tbxCategoria.ForeColor = Color.Black;
                tbxMarca.BackColor = Color.White;
                tbxMarca.ForeColor = Color.Black;

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
                pbxArticulo.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
