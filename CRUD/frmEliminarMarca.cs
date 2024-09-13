using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmEliminarMarca : Form
    {
        private List<Marca> listaMarca;

        public frmEliminarMarca()
        {
            InitializeComponent();
        }
        private void frmEliminarMarca_Load(object sender, EventArgs e)
        {
            actualizarMarcas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMarcaNegocio negocio = new EliminarMarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro que queres eliminarlo? ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(seleccionado.Id);
                    actualizarMarcas();
                    
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void actualizarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarca = negocio.listar();
                dgvMarcas.DataSource = listaMarca;

                if (dgvMarcas.Rows.Count > 0)
                {
                    
                    dgvMarcas.Rows[0].Selected = true;
                   
                    tbxEliminarMarca.Text = dgvMarcas.Rows[0].Cells[1].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMarcas_Click(object sender, EventArgs e)
        {
            int fila = dgvMarcas.CurrentRow.Index;
            tbxEliminarMarca.Text = dgvMarcas.Rows[fila].Cells[1].Value.ToString();
        }
    }
}
