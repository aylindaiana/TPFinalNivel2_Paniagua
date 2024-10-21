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
            FrmAgregar nuevo = new FrmAgregar();
            nuevo.ShowDialog();
            cargarGrilla();

        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //this.ClientSize = new System.Drawing.Size(805, 545);
            cargarGrilla();
            //cboxCampo.Items.Add("Nombre");
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
                pbxArticuloImagen.Load("https://faculty.eng.ufl.edu/elliot-douglas/wp-content/uploads/sites/70/2015/11/img-placeholder.png");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listaArticulo.Count > 0 && (dgvArticulos.CurrentRow == null))
            {
                dgvArticulos.Rows[0].Selected = true;
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[2];
            }
            if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo modificable = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                //  FrmAgregar editar = new FrmAgregar(modificable);
                //editar.ShowDialog();
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

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


    }
}