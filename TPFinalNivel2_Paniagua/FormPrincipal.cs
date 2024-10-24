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
            //cbxCampo.Items.Add("Nombre");
            //cboxCampo.Items.Add("Marca");
            //cboxCampo.Items.Add("Precio");
            //cboxCampo.Items.Add("Categoria");
        }


        private void cargarGrilla()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.Listar();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            opcEliminar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            opcEliminar(true);
        }

        private void opcEliminar(bool logico = false)
        {
            //Chequeo que haya un item seleccionado:
            if (listaArticulo.Count > 0 && (dgvArticulos.CurrentRow == null))
            {
                dgvArticulos.Rows[0].Selected = true;
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[2];
            }

            if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                //Pido confirmacion previo a eliminar:
                if (confirmarAccion(seleccionado.Codigo, logico))
                {
                    try
                    {
                        if (logico)
                            negocio.activar_desactivar(seleccionado.Id);
                        else
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

        private bool confirmarAccion(string cod, bool logico)
        {
            DialogResult respuesta;
            if (logico)
                respuesta = MessageBox.Show("¿Seguro que quiere dar de baja el registro con Código=" + cod + " de la BD?", "Desactivando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else
                respuesta = MessageBox.Show("¿Seguro que quiere eliminar el registro con Código=" + cod + " de la BD?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
                return true;
            return false;
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
                    lblDescMarca.Text = "Marca: " + seleccionado.TipoMarca.Descipcion;
                    lblDescPrecio.Text = "Precio: $" + seleccionado.Precio.ToString("0.00");
                    lblDescCodigo.Text = "Código: " + seleccionado.Codigo;
                    lblDescDescripcion.Text = "Descripción: " + seleccionado.Descripcion;
                    lblDescCateg.Text = "Sector: " + seleccionado.TipoCategoria.Descripcion;
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

                btnEliminar.Enabled = false;
                btnEliminar.BackColor = Color.Gray;
                btnBaja.Enabled = false;
                btnBaja.BackColor = Color.Gray;
                btnActualizar.Enabled = false;
                btnActualizar.BackColor = Color.Gray;
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            validarCeldaSelec();
        }

        /*
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtroAv();
        }*/
        /*
        private void txtboxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            //No inicializo el obj lista antes ya que la Lista se genera en el FindAll

            string filtro = txbBusqueda.Text; //donde es txtbxFiltro
            if (filtro.Length >= 2)
                listaFiltrada = listaArticulo.FindAll(art => art.Nombre.ToUpper().Contains(filtro.ToUpper()) || art.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || art.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || art.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaArticulo;

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            validarCeldaSelec();
            ocultarColumnas();
        }
        */

        /*
        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxCriterio.Items.Clear();
            if (cboxCampo.SelectedIndex != -1)
            {
                string campo = cboxCampo.SelectedItem.ToString();
                switch (campo)
                {
                    case "Precio":
                        cboxCriterio.Items.Add("Menor a");
                        cboxCriterio.Items.Add("Mayor a");
                        cboxCriterio.Items.Add("Igual a");
                        break;
                    default:
                        cboxCriterio.Items.Add("Comienza con");
                        cboxCriterio.Items.Add("Termina con");
                        cboxCriterio.Items.Add("Contiene");
                        break;
                }
            }
            else
                cboxCriterio.Items.Clear();
        } */
        /*
        private void btnReactivar_Click(object sender, EventArgs e)
        {
            FrmReactivarArt activacion = new FrmReactivarArt();
            activacion.ShowDialog();
            cargarGrilla();
        }
        */
        /*
        private void TsMenuAgregarArticulo_Click(object sender, EventArgs e)
        {
            FrmAgregar alta = new FrmAgregar();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void TsMenuCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        */


        /*
        private void TsMenuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        */

        /*
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            txtboxFiltroAvanzado.Text = "";
            txtboxFiltro.Text = "";
            cboxCampo.SelectedIndex = -1;
        }
        */

        /*
        private void filtroAv()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (!Validacion.validarFiltro(cboxCampo, cboxCriterio, txtboxFiltroAvanzado))
                    return;

                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = txtboxFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

                validarCeldaSelec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/
        /*
        private void txtboxFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                filtroAv();
                e.Handled = true; // evita que se genere el sonido de la tecla Enter
            }
        }
        */


        /*
        private void TsMenuAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarCategMarca nuevaMarca = new frmAgregarCategMarca(true);
            nuevaMarca.ShowDialog();
        }

        private void TsMenuAgregarCat_Click(object sender, EventArgs e)
        {
            frmAgregarCategMarca nuevaCateg = new frmAgregarCategMarca();
            nuevaCateg.ShowDialog();
        }
        */
        /*
        private void lblMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (listaArticulo.Count > 0 && (dgvArticulos.CurrentRow == null) && lblDescNombre.Text != "Sin coincidencias")
            {
                dgvArticulos.Rows[0].Selected = true;
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[2];
            }

            if (lblDescCodigo.Visible)
            {

                if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
                {
                    lblDescMarca.Visible = false;
                    lblDescCodigo.Visible = false;
                    lblDescDescripcion.Visible = false;
                    lblDescCateg.Visible = false;
                    Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    lblDescNombre.Text = articulo.Nombre;
                }
                else
                {
                    lblDescNombre.Text = "Sin coincidencias";
                    lblDescCodigo.Text = "";
                    lblDescMarca.Text = "";
                    lblDescDescripcion.Text = "";
                    lblDescPrecio.Text = "";
                    lblDescCateg.Text = "";
                }

            }
            else
            {

                if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
                {
                    lblDescMarca.Visible = true;
                    lblDescCodigo.Visible = true;
                    lblDescDescripcion.Visible = true;
                    lblDescCateg.Visible = true;
                    Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    lblDescNombre.Text = "Nombre: " + articulo.Nombre;
                    lblDescMarca.Text = "Marca: " + articulo.Marca;
                    lblDescPrecio.Text = "Precio: $" + articulo.Precio.ToString("0.00");
                    lblDescCodigo.Text = "Código: " + articulo.Codigo;
                    lblDescDescripcion.Text = "Descripción: " + articulo.Descripcion;
                    lblDescCateg.Text = "Sector: " + articulo.Categoria.Descripcion;
                }
                else
                {
                    lblDescNombre.Text = "Sin coincidencias";
                    lblDescPrecio.Text = "";
                }
            }
        }
    */
        /*
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
        */
    }
}