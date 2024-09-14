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
    public partial class frmEliminarCategoria : Form
    {
        private List<Categoria> listaCategoria;
        public frmEliminarCategoria()
        {
            InitializeComponent();
        }
        private void frmEliminarCategoria_Load(object sender, EventArgs e)
        {
            tbxEliminarCategoria.Enabled = false;
            tbxEliminarCategoria.BackColor = Color.White;
            tbxEliminarCategoria.ForeColor = Color.Black;
            actualizarCategorias();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            EliminarCategoriaNegocio negocio = new EliminarCategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro que queres eliminarlo? ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminarCategoria(seleccionado.Id);
                    actualizarCategorias();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void actualizarCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategoria = negocio.listar();
                dgvCategorias.DataSource = listaCategoria;

                if (dgvCategorias.Rows.Count > 0)
                {

                    dgvCategorias.Rows[0].Selected = true;

                    tbxEliminarCategoria.Text = dgvCategorias.Rows[0].Cells[1].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategorias_Click(object sender, EventArgs e)
        {
            int fila = dgvCategorias.CurrentRow.Index;
            tbxEliminarCategoria.Text = dgvCategorias.Rows[fila].Cells[1].Value.ToString();
        }
    }
}
