using domino;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Paniagua
{
    public partial class FrmAgregarActualizar : Form
    {
        private Articulo _Articulo = null;
        private OpenFileDialog archivo = null;
        public FrmAgregarActualizar()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public FrmAgregarActualizar(Articulo Articulo)
        {
            InitializeComponent();
            _Articulo = Articulo;
            Text = "Modificar Articulo";
        }
        private void FrmAgregarActualizar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.Listar();
                cbxCategoria.ValueMember = "id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcaNegocio.Listar();
                cbxMarca.ValueMember = "id";
                cbxMarca.DisplayMember = "Descripcion";
                
                if (_Articulo != null)
                {
                    txtCodigo.Text = _Articulo.Codigo;
                    txtNombre.Text = _Articulo.Nombre;
                    txtDescripcion.Text = _Articulo.Descripcion;
                    txtImagenUrl.Text = _Articulo.ImagenUrl;
                    CargarImagen(_Articulo.ImagenUrl);
                    cbxMarca.SelectedValue = _Articulo.TipoMarca.Id;
                    cbxCategoria.SelectedValue = _Articulo.TipoCategoria.Id;
                    txtPrecio.Text = _Articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            bool todoValido = true;
            decimal precio;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                lblCodigo.ForeColor = Color.Red;
                lblCodigo.Text = "Codigo*";
                todoValido = false;
            }
            else
            {
                lblCodigo.ForeColor = Color.Black;
                lblCodigo.Text = "Codigo";
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lblNombre.ForeColor = Color.Red;
                lblNombre.Text = "Nombre*";
                todoValido = false;
            }
            else if (soloNumeros(txtNombre.Text))
            {
                lblNombre.ForeColor = Color.Red;
                lblNombre.Text = "Nombre*";
                MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                todoValido = false;
            }
            else
            {
                lblNombre.ForeColor = Color.Black;
                lblNombre.Text = "Nombre";
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                lblDescripcion.ForeColor = Color.Red;
                lblDescripcion.Text = "Descripcion*";
                todoValido = false;
            }
            else if (soloNumeros(txtDescripcion.Text))
            {
                lblDescripcion.ForeColor = Color.Red;
                lblDescripcion.Text = "Descripcion*";
                MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                todoValido = false;
            }
            else
            {
                lblDescripcion.ForeColor = Color.Black;
                lblDescripcion.Text = "Descripcion";
            }

            
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                lblPrecio.ForeColor = Color.Red;
                lblPrecio.Text = "Precio*";
                todoValido = false;
            }
            else if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                lblPrecio.ForeColor = Color.Red;
                lblPrecio.Text = "Precio*";
                MessageBox.Show("Precio invalido. Por favor ingrese un numero valido");
                todoValido = false;
            }

            return todoValido;
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validarFiltro())
            {
                return;
            }

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if (_Articulo == null)
                    _Articulo = new Articulo();

                _Articulo.Codigo = txtCodigo.Text;
                _Articulo.Nombre = txtNombre.Text;
                _Articulo.Descripcion = txtDescripcion.Text;
                _Articulo.ImagenUrl = txtImagenUrl.Text;
                _Articulo.TipoMarca = (Marca)cbxMarca.SelectedItem;
                _Articulo.TipoCategoria = (Categoria)cbxCategoria.SelectedItem;
                decimal precioDecimal;
                if (decimal.TryParse(txtPrecio.Text, out precioDecimal)) 
                {
                    _Articulo.Precio = precioDecimal;
                }



                if (_Articulo.Id != 0) 
                {
                    articuloNegocio.modificar(_Articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    articuloNegocio.agregar(_Articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtImagenUrl.Text);
        }

        private void CargarImagen(string img)
        {
            try
            {
                pbxImagen.Load(img);
            }
            catch
            {
                pbxImagen.Load("https://img.freepik.com/premium-vector/default-image-icon-vector-missing-picture-page-website-design-mobile-app-no-photo-available_87543-11093.jpg");

            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
