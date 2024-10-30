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
    public partial class FrmMarcaCategoria : Form
    {
        public FrmMarcaCategoria()
        {
            InitializeComponent();
        }
        public string TablaDestino { get; set; }
        private void AgregarMarcaCategoria_Load(object sender, EventArgs e)
        {
            if (TablaDestino == "Marcas")
                lblTitulo.Text = "Agregue una Marca Nueva";
            else
                lblTitulo.Text = "Agregue una Categoria Nueva";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (TablaDestino == "Marcas")
                    AgregarMarcaNueva();
                else
                    AgregarCategoriaNueva();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }
        private void AgregarMarcaNueva()
        {
            MarcaNegocio marcas = new MarcaNegocio();
            marcas.Agregar(txtNombre.Text);
        }

        private void AgregarCategoriaNueva()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            categoriaNegocio.Agregar(txtNombre.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
