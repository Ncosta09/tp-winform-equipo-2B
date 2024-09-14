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
    public partial class frmVerTodos : Form
    {
        private List<Articulo> listaArticulo;

        public frmVerTodos()
        {
            InitializeComponent();
        }

        private void frmVerTodos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["Imagen"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Visible = false; 
                dgvArticulos.Columns["Categoria"].Visible = false;
                dgvArticulos.Columns["Marca"].Visible = false;
                //dgvArticulos.Columns["Id"].Visible = false; > VER PORQUE NO ME DEJA OCULTARLO QUE QUEDE SOLO CODIGO, NOMBRE Y PRECIO
                //pbArticulo.Load(listaArticulo[0].Imagen.imgUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccion.Imagen.imgUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }
       
        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }

        }
        
        /*private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            String filtro = comboBoxCampo.Text;
            listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }*/


        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            BusquedaAvanzada busqueda = new BusquedaAvanzada();

            try
            {
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = busqueda.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificarArticulo_Click(object sender, EventArgs e)
        {
            /*foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))

                    return;
            }*/

            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificarArticulo = new frmAgregar(seleccionado);

            modificarArticulo.MdiParent = this.MdiParent;
            modificarArticulo.Dock = DockStyle.Fill;
            modificarArticulo.Show();
        }

        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmVerDetalle))

                    return;
            }

            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmVerDetalle verArticulo = new frmVerDetalle(seleccionado);

            verArticulo.MdiParent = this.MdiParent; 
            verArticulo.Dock = DockStyle.Fill; 
            verArticulo.Show(); 

        }
    }
    }

