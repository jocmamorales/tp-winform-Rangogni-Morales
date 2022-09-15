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
using Negocio.ModeloDTO;

namespace VistaArticulos
{
    public partial class frmEditarArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        private string filtro = string.Empty;
        private List<Categoria> categorias;
        private List<Marca> marcas;

        public frmEditarArticulo()
        {
            InitializeComponent();
        }

        public frmEditarArticulo(string filtro)
        {
            InitializeComponent();
            this.filtro = filtro;
        }

        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            FormatoCombos();
            cargarGrilla();
            FormatoGrilla();
            if (articulo != null)
            {
                txtCodigoEditar.Text = articulo.Codigo;
                txtNombreEditar.Text = articulo.Nombre;
                txtDescripcionEditar.Text = articulo.Descripcion;
                txtPrecioEditar.Text = articulo.Precio.ToString();
                txtImagenEditar.Text = articulo.ImagenUrl;
            }
            LimpiarDatos();
        }

        private void CargarCombos(string idCat, string idMar)
        {
            Categoria categoriaSeleccionada = null;
            Marca marcaSeleccionada = null;
            try
            {
                if (!(idCat.Equals("0") || idCat.Equals("")))
                {
                    categoriaSeleccionada = categorias.Find(x => x.Id.ToString().Equals(idCat));
                    if (categoriaSeleccionada != null)
                        cboCategoriaEditar.Text = categoriaSeleccionada.Descripcion;
                }
                if (idCat.Equals("0"))
                    cboCategoriaEditar.Text = "";
                if (!(idMar.Equals("0") || idMar.Equals("")))
                {
                    marcaSeleccionada = marcas.Find(x => x.Id.ToString().Equals(idMar));
                    if (marcaSeleccionada != null)
                        cboMarcaEditar.Text = marcaSeleccionada.Descripcion;
                }
                if (idMar.Equals("0"))
                    cboMarcaEditar.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormatoGrilla()
        {
            dgvArticulosEditar.Columns["ImagenUrl"].HeaderText = "Origen Imagen";
            dgvArticulosEditar.Columns["Id"].Visible = false;
            dgvArticulosEditar.Columns["Descripcion"].Visible = true;
            dgvArticulosEditar.Columns["IdMarca"].Visible = false;
            dgvArticulosEditar.Columns["IdCategoria"].Visible = false;
            dgvArticulosEditar.Columns["ImagenUrl"].Visible = false;
            dgvArticulosEditar.Columns["Precio"].Visible = true;
            dgvArticulosEditar.Columns["Codigo"].Visible = true;
            dgvArticulosEditar.Columns["Nombre"].Visible = true;
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

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar este artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulosEditar.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            try
            {
                if (dgvArticulosEditar.CurrentRow == null)
                    return;
                seleccionado = (Articulo)dgvArticulosEditar.CurrentRow.DataBoundItem;
                seleccionado.Codigo = txtCodigoEditar.Text;
                seleccionado.Nombre = txtNombreEditar.Text;
                seleccionado.Descripcion = txtDescripcionEditar.Text;
                if (validarPositivo(decimal.Parse(txtPrecioEditar.Text)))
                {
                    seleccionado.Precio = decimal.Parse(txtPrecioEditar.Text);
                }
                else
                {
                    throw new FormatException();
                }
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
                MessageBox.Show(fex.Message.ToString(), "Precio mal ingresado");
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
                if (validarPositivo(decimal.Parse(txtPrecioEditar.Text)))
                {
                    articulo.Precio = decimal.Parse(txtPrecioEditar.Text);
                }
                else
                {
                    throw new FormatException();
                }
                articulo.ImagenUrl = txtImagenEditar.Text;
                articulo.IdMarca = int.Parse(cboMarcaEditar.SelectedValue.ToString());
                articulo.IdCategoria = int.Parse(cboCategoriaEditar.SelectedValue.ToString());
                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado exitosamente");
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

        private bool validarPositivo(decimal numero)
        {
            if (numero >= 0)
                return true;
            else
                return false;
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
                CargarCombos(artSel.IdCategoria == null ? "" : artSel.IdCategoria.ToString(), artSel.IdMarca == null ? "" : artSel.IdMarca.ToString());
                txtId.Text = artSel.Id.ToString();
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
                if (!File.Exists(ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
        }

        private void FormatoCombos()
        {
            categorias = new List<Categoria>();
            marcas = new List<Marca>();

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

        private void dgvArticulosEditar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvArticulosEditar.CurrentRow != null)
                dgvArticulosEditar_SelectionChanged(sender, e);
        }

    }
}
