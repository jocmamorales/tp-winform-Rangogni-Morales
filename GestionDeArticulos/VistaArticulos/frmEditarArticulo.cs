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
        private Articulo articulo = null;
        private string filtro = string.Empty;
        public frmEditarArticulo()
        {
            InitializeComponent();
        }
        public frmEditarArticulo(string filtro)
        {   
            InitializeComponent();
            this.filtro = filtro;
        }
            public frmEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            if(filtro.Equals(""))
            dgvArticulosEditar.DataSource = articuloNegocio.ListarArticulos();
            else
                dgvArticulosEditar.DataSource = articuloNegocio.ListarArticulos(filtro);
            if (articulo != null)
            {
                txtCodigoEditar.Text = articulo.Codigo;
                txtNombreEditar.Text = articulo.Nombre;
                txtDescripcionEditar.Text = articulo.Descripcion;
                //txtPrecioEditar = articulo.Precio;
                txtImagenEditar.Text = articulo.ImagenUrl;//FALTA AGREGAR CARGAR IMAGEN
                

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            
            seleccionado = (Articulo)dgvArticulosEditar.CurrentRow.DataBoundItem;
           

            ArticuloNegocio modificar = new ArticuloNegocio();
            modificar.agregar(seleccionado);
            MessageBox.Show("Articulo modificado exitosamente");

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                validarAgregar();
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

        private bool validarAgregar()
        {
            
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
