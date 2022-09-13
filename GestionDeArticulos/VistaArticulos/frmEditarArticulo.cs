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
using System.IO;
using System.Configuration;

namespace VistaArticulos
{
    public partial class frmEditarArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
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
            cargarGrilla();
            if (articulo != null)
            {
                txtCodigoEditar.Text = articulo.Codigo;
                txtNombreEditar.Text = articulo.Nombre;
                txtDescripcionEditar.Text = articulo.Descripcion;
                txtPrecioEditar.Text = articulo.Precio.ToString();
                txtImagenEditar.Text = articulo.ImagenUrl;
            }
            FormatoCombos();
        }

        private void cargarGrilla()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            if (filtro.Equals(""))
                dgvArticulosEditar.DataSource = articuloNegocio.ListarArticulos();
            else
                dgvArticulosEditar.DataSource = articuloNegocio.ListarArticulos(filtro);
        }
        private void txtImagenEditar_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagenEditar.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArtEditar.Load(imagen);
            }
            catch (Exception)
            {
                pbxArtEditar.Load("https://us.123rf.com/450wm/momoforsale/momoforsale2105/momoforsale210500063/169348832-no-hay-se%C3%B1al-disponible-de-imagen-aislada-en-la-ilustraci%C3%B3n-de-vector-de-fondo-blanco-.jpg?ver=6");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            //eliminar();

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            try
            {
              
                seleccionado = (Articulo)dgvArticulosEditar.CurrentRow.DataBoundItem;
                seleccionado.Codigo = txtCodigoEditar.Text;
                seleccionado.Nombre = txtNombreEditar.Text;
                seleccionado.Descripcion = txtDescripcionEditar.Text;
               
                seleccionado.Precio = decimal.Parse(txtPrecioEditar.Text);
                seleccionado.ImagenUrl = txtImagenEditar.Text;
                seleccionado.IdMarca = int.Parse(cboMarcaEditar.SelectedValue.ToString());
                seleccionado.IdCategoria = int.Parse(cboCategoriaEditar.SelectedValue.ToString());

                ArticuloNegocio aux = new ArticuloNegocio();
                aux.modificar(seleccionado);
                noGuardarImagenLocal(txtImagenEditar.Text);
                MessageBox.Show("Articulo modificado exitosamente");
                cargarGrilla();

            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message, "Precio mal ingresado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


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
                articulo.IdMarca = int.Parse(cboMarcaEditar.SelectedValue.ToString());
                articulo.IdCategoria = int.Parse(cboCategoriaEditar.SelectedValue.ToString());
                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado exitosamente");
                cargarGrilla();
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message,"Precio mal ingresado"); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarEditar()
        {
            if (!(validarNumeros(txtPrecioEditar.Text)))
            {
                MessageBox.Show("El campo solo se admite carga de numeros");
                return false;
            }
            return true;
        }
        private bool validarNumeros(string cadena)
        {   
            foreach (char caracter in cadena)
            {
                if (!(char.IsDigit(caracter)))
                    return false;
            }
            return true;
        }

        private void LimpiarDatos()
        {
            txtCodigoEditar.Clear();
            txtDescripcionEditar.Clear();
            txtImagenEditar.Clear();
            txtNombreEditar.Clear();
            txtPrecioEditar.Clear();
            cboCategoriaEditar.SelectedItem = cboCategoriaEditar.Items[0];
            cboMarcaEditar.SelectedItem = cboMarcaEditar.Items[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArticulosEditar_SelectionChanged(object sender, EventArgs e)
        {

            Articulo artSel = null;
            if (dgvArticulosEditar.SelectedRows.Count > 0)
            {
                artSel = (Articulo)dgvArticulosEditar.CurrentRow.DataBoundItem;
                txtCodigoEditar.Text = artSel.Codigo;
                txtDescripcionEditar.Text = artSel.Descripcion;
                txtNombreEditar.Text = artSel.Nombre;
                txtPrecioEditar.Text = artSel.Precio.ToString();
                txtImagenEditar.Text = artSel.ImagenUrl;
                cboCategoriaEditar.Text = artSel.IdCategoria.ToString();
                cboMarcaEditar.Text = artSel.IdMarca.ToString();

            }

        }

        private void btnSalirEditarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnImagenArchivo_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenEditar.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

            }
        }
        private void noGuardarImagenLocal(string x)
        {
            if (archivo != null && !(txtImagenEditar.Text.ToUpper().Contains("HTTP")))
                if(!File.Exists(ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName))
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
        }
        private void FormatoCombos()
        {
            List<Categoria> categorias = new List<Categoria>();
            List<Marca> marcas = new List<Marca>();

            try
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Categoria categoriaTodas = new Categoria
                {
                    Id = 0,
                    Descripcion = ""
                };
                categorias = new List<Categoria>();
                categorias.Add(categoriaTodas);
                categorias.AddRange(categoriaNegocio.Categorias());
                cboCategoriaEditar.DataSource = categorias;
                cboCategoriaEditar.DisplayMember = "Descripcion";
                cboCategoriaEditar.ValueMember = "Id";

                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Marca marcaTodas = new Marca
                {
                    Id = 0,
                    Descripcion = ""
                };
                marcas = new List<Marca>();
                marcas.Add(marcaTodas);
                marcas.AddRange(marcaNegocio.Marcas());
                cboMarcaEditar.DataSource = marcas;
                cboMarcaEditar.DisplayMember = "Descripcion";
                cboMarcaEditar.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
