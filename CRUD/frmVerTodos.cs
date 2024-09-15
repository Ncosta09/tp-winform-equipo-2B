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

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
        }

        private void frmVerTodos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                //pbArticulo.Load(listaArticulo[0].Imagen.imgUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Codigo");
            //comboBoxCampo.Items.Add("Descripcion");
            //comboBoxCampo.Items.Add("Categoria");
            //comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.Imagen.imgUrl);
            }
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
        private bool validarFiltro()
        {
            if(comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if(comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un criterio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if(comboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debe cargar el campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                if (!(soloNumeros(textBoxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Debe ingresar unicamente numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string numeros)
        {
            foreach(char caracter in numeros)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            BusquedaAvanzada busqueda = new BusquedaAvanzada();

            try
            {
                if (validarFiltro()) 
                {
                    return;
                }

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = busqueda.filtrar(campo, criterio, filtro);
                ocultarColumnas();

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

            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un elemento antes de modificarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificarArticulo = new frmAgregar(seleccionado);


            modificarArticulo.FormClosed += (s, args) =>
            {
                //ACTUALIZA LOS DATOS DESPUES DE CERRAR EL FORMULARIO DE MODIFIC
                cargar();
            };

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

