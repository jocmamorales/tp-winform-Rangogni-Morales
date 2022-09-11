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
using Dominio;


namespace VistaArticulos
{
    public partial class frmEditarArticulo : Form
    {
        public frmEditarArticulo()
        {
            InitializeComponent();
        }

        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            dgvArticulosEditar.DataSource = articuloNegocio.ListarArticulos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulo.Codigo = txtCodigoEditar.Text;
                articulo.Nombre = txtNombreEditar.Text;
                articulo.Descripcion = txtDescripcionEditar.Text;
                articulo.Precio = decimal.Parse(txtPrecioEditar.Text);
                articulo.ImagenUrl = txtImagenEditar.Text;
                //FALTA AGREGAR MARCA Y CATEGORIA
                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado exitosamente");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
