using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domino;
using negocio;

namespace TPFinalNivel2_Paniagua
{
    public partial class FormPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarActualizar nuevo = new FrmAgregarActualizar();
            nuevo.ShowDialog();
            cargarGrilla();

        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            cargarGrilla();
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Categoria");
        }


        private void cargarGrilla()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulo = articuloNegocio.Listar();
                dgvArticulos.DataSource = listaArticulo;    
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticuloImagen.Visible = true;
                pbxArticuloImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticuloImagen.Load("https://img.freepik.com/premium-vector/default-image-icon-vector-missing-picture-page-website-design-mobile-app-no-photo-available_87543-11093.jpg");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (listaArticulo.Count > 0 && (dgvArticulos.CurrentRow == null))
            {
                dgvArticulos.Rows[0].Selected = true;
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[2];
            }
            if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo modificable = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmAgregarActualizar actualizar = new FrmAgregarActualizar(modificable);
                actualizar.ShowDialog();
                cargarGrilla();
            }
            else
                MessageBox.Show("Ninguna fila seleccionada");
        }

        private void validarCeldaSelec()
        {
            if (dgvArticulos.CurrentRow != null)
            { 
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
                if (lblDescDescripcion.Visible)
                {
                    lblDescNombre.Text = "Nombre: " + seleccionado.Nombre;
                    lblDescMarca.Text = "Marca: " + seleccionado.TipoMarca.Descripcion;
                    lblDescPrecio.Text = "Precio: $" + seleccionado.Precio.ToString("0.00");
                    lblDescCodigo.Text = "Código: " + seleccionado.Codigo;
                    lblDescDescripcion.Text = "Descripción: " + seleccionado.Descripcion;
                    lblDescCateg.Text = "Categoria: " + seleccionado.TipoCategoria.Descripcion;
                }
                else
                {
                    lblDescNombre.Text = seleccionado.Nombre;
                    lblDescPrecio.Text = "$" + seleccionado.Precio.ToString("0.00");
                }

            }
            else
            {
                lblDescNombre.Text = "Sin coincidencias";
                lblDescMarca.Text = "";
                lblDescPrecio.Text = "";
                lblDescCodigo.Text = "";
                lblDescDescripcion.Text = "";
                lblDescCateg.Text = "";
                pbxArticuloImagen.Load("https://faculty.eng.ufl.edu/elliot-douglas/wp-content/uploads/sites/70/2015/11/img-placeholder.png");

            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            validarCeldaSelec();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           filtroAvanzado();
        }

        
        private void filtroAvanzado()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = articuloNegocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0) 
            {
                MessageBox.Show("Por favor, Seleccione el campo a filtrar.");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0) 
            {
                MessageBox.Show("Por favor, Seleccione el criterio para filtrar.");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "precio") 
            {
                if (string.IsNullOrEmpty(txtFiltro.Text)) 
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text))) 
                {
                    MessageBox.Show("Solo números para filtrar por un campo numérico...");
                    return true;
                }
            }
            if (cbxCampo.SelectedItem.ToString() == "nombre" || cbxCampo.SelectedItem.ToString() == "categoría")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text)) 
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if ((soloNumeros(txtFiltro.Text))) 
                {
                    MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                    return true;
                }
            }

            return false;
        }
        private bool soloNumeros(string cadena)
            {
                foreach (char caracter in cadena)
                {
                    if (!(char.IsNumber(caracter)))
                        return false;
                }
                return true;
            }



        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCriterio.Items.Clear();
            if (cbxCampo.SelectedIndex != -1)
            {
                string campo = cbxCampo.SelectedItem.ToString();
                switch (campo)
                {
                    case "Precio":
                        cbxCriterio.Items.Add("Menor a");
                        cbxCriterio.Items.Add("Mayor a");
                        cbxCriterio.Items.Add("Igual a");
                        break;
                    default:
                        cbxCriterio.Items.Add("Comienza con");
                        cbxCriterio.Items.Add("Termina con");
                        cbxCriterio.Items.Add("Contiene");
                        break;
                }
            }
            else
                cbxCriterio.Items.Clear();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                filtroAvanzado();
                e.Handled = true; 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (listaArticulo.Count > 0 && (dgvArticulos.CurrentRow == null))
                {
                    dgvArticulos.Rows[0].Selected = true;
                    dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[2];
                }

                if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    if (confirmarAccion(seleccionado.Codigo))
                    {
                        try
                        {
                            negocio.elimFisico(seleccionado.Id);
                            cargarGrilla();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                else
                    MessageBox.Show("Ninguna fila seleccionada");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool confirmarAccion(string codigo)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Estás seguro que queres eliminar el registro de Código:" + codigo + " definitivamente?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            txtBusqueda.Text = ""; //txtFiltro Avanzado
            txtFiltro.Text = "";
            cbxCampo.SelectedIndex = -1;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBusqueda.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.TipoCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.TipoMarca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcaCategoria frmMarcaCategoria = new FrmMarcaCategoria();
            frmMarcaCategoria.TablaDestino = "Marcas";
            frmMarcaCategoria.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcaCategoria frmMarcaCategoria = new FrmMarcaCategoria();
            frmMarcaCategoria.TablaDestino = "Categorias";
            frmMarcaCategoria.ShowDialog();
        }

        private void carrarPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreLaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutor frmAturora = new FrmAutor();
            frmAturora.ShowDialog();
        }

    }
}