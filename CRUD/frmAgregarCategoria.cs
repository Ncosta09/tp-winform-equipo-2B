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
    public partial class frmAgregarCategoria : Form
    {
        private List<Categoria> listaCategoria;
        public frmAgregarCategoria()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CrearCategoria crearCategoria = new CrearCategoria();

            try
            {
                categoria.Descripcion = txtNuevaCategoria.Text;
                crearCategoria.agregar(categoria);
                MessageBox.Show("Categoria Agregada con Exito!");
                cargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategoria = negocio.listar();
                dgvCategorias.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void txtNuevaMarca_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = !string.IsNullOrEmpty(txtNuevaCategoria.Text);
        }
    }

}
