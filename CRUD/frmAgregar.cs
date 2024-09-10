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
                //art.Categoria = cbCategoria.SelectedIndex;
                //art.Marca = cbMarca.SelectedIndex;
                //art.Imagen = txtUrl.Text;

                artNegocio.crear(art);
                MessageBox.Show("Agregado con Exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
