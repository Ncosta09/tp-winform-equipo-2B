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
    public partial class frmAgregarMarca : Form
    {
        private List<Marca> listaMarca;
        public frmAgregarMarca()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            CrearCaracteristica crearMarca = new CrearCaracteristica();

            try
            {
                marca.Descripcion = txtNuevaMarca.Text;

                crearMarca.agregar(marca);
                MessageBox.Show("Marca Agregado con Exito!");
                cargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarca = negocio.listar();
                dgvMarcas.DataSource = listaMarca;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void txtNuevaMarca_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = !string.IsNullOrEmpty(txtNuevaMarca.Text);
        }

    }
}
