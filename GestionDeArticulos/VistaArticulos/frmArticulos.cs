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
using Negocio;
using Negocio.ModeloDTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VistaArticulos
{
    public partial class frmArticulos : Form
    {
        private List<ArticuloDTO> articuloDTOs;
        private List<Categoria> categorias;
        private List<Marca> marcas;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarGrilla();
                pbxArticulo.Load(articuloDTOs[0].ImagenUrl);
                FormatoGrilla();
                FormatoCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarGrilla()
        {
            ArticuloDTONegocio articuloDTONegocio = new ArticuloDTONegocio();
            articuloDTOs = articuloDTONegocio.ListarArticulosDTO();
            dgvArticulos.DataSource = articuloDTOs;
        }
        private void FormatoGrilla()
        {

            dgvArticulos.Columns["Categoria_Art"].Visible = false;
            dgvArticulos.Columns["Marca_Art"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Codigo"].DisplayIndex = 0;
            dgvArticulos.Columns["Nombre"].DisplayIndex = 1;
            dgvArticulos.Columns["Categoria"].DisplayIndex = 2;
        }
        private void FormatoCombos()
        {
            try
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Categoria categoriaTodas = new Categoria
                {
                    Id = 0,
                    Descripcion = "Todos"
                };
                categorias = new List<Categoria>();
                categorias.Add(categoriaTodas);
                categorias.AddRange(categoriaNegocio.Categorias());
                cmbCategoría.DataSource = categorias;
                cmbCategoría.DisplayMember = "Descripcion";
                cmbCategoría.ValueMember = "Id";

                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Marca marcaTodas = new Marca
                {
                    Id = 0,
                    Descripcion = "Todos"
                };
                marcas = new List<Marca>();
                marcas.Add(marcaTodas);
                marcas.AddRange(marcaNegocio.Marcas());
                cmbMarca.DataSource = marcas;
                cmbMarca.DisplayMember = "Descripcion";
                cmbMarca.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtBoxFiltroRapido(object sender, EventArgs e)
        {
            List<ArticuloDTO> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
                listaFiltrada = articuloDTOs.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = articuloDTOs;

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            FormatoGrilla();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            ArticuloDTO artSel = null;
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                artSel = (ArticuloDTO)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(artSel.ImagenUrl);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://us.123rf.com/450wm/momoforsale/momoforsale2105/momoforsale210500063/169348832-no-hay-se%C3%B1al-disponible-de-imagen-aislada-en-la-ilustraci%C3%B3n-de-vector-de-fondo-blanco-.jpg?ver=6");
            }
        }

        private void btnNuevoArt_Click(object sender, EventArgs e)
        {
            string sqlWhere = "";
            frmEditarArticulo editar = null;
            sqlWhere = WhereSqlFiltros();
            if (sqlWhere.Trim().Equals(""))
                editar = new frmEditarArticulo();
            else
                editar = new frmEditarArticulo(sqlWhere);

            editar.ShowDialog();
            LlenarGrilla();
        }

        private string WhereSqlFiltros()
        {
            string sqlWhere = string.Empty;
            if (!txtFiltro.Text.Equals(""))
                sqlWhere += " (codigo like '%" + txtFiltro.Text.Trim() + "&' OR nombre LIKE '%" + txtFiltro.Text + "%')";
            if (cmbCategoría.SelectedValue.ToString() != "0")
                sqlWhere += sqlWhere.Length > 0 ? " AND IdCategoria = " + cmbCategoría.SelectedValue : " IdCategoria = " + cmbCategoría.SelectedValue;
            if (cmbMarca.SelectedValue.ToString() != "0")
                sqlWhere += sqlWhere.Length > 0 ? " AND IdMarca = " + cmbMarca.SelectedValue : " IdMarca = " + cmbMarca.SelectedValue;
            if (!sqlWhere.Trim().Equals(""))
                sqlWhere = " WHERE " + sqlWhere;

            return sqlWhere;
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboMarcaGrilla();
        }
        private void ComboMarcaGrilla()
        {
            List<ArticuloDTO> articulosGrilla = (List<ArticuloDTO>)dgvArticulos.DataSource;
            if (cmbMarca.SelectedValue.ToString() != "0")
            {
                VistaMarcaGrilla((List<ArticuloDTO>)dgvArticulos.DataSource);
                if (cmbCategoría.SelectedValue.ToString() != "0")
                    VistaCategoriaGrilla((List<ArticuloDTO>)dgvArticulos.DataSource);
            }
            if (cmbMarca.SelectedValue.ToString() == "0")
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = articuloDTOs;
                if (cmbCategoría.SelectedValue.ToString() != "0")
                    VistaCategoriaGrilla((List<ArticuloDTO>)dgvArticulos.DataSource);
            }
            FormatoGrilla();
        }
        private void VistaCategoriaGrilla(List<ArticuloDTO> artsGrilla)
        {
            List<ArticuloDTO> artsFiltrados = artsGrilla.FindAll(x => x.IdCategoria.ToString().Equals(cmbCategoría.SelectedValue.ToString()));
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = artsFiltrados;
        }
        private void VistaMarcaGrilla(List<ArticuloDTO> artsGrilla)
        {
            List<ArticuloDTO> artsFiltrados = artsGrilla.FindAll(x => x.IdMarca.ToString().Equals(cmbMarca.SelectedValue.ToString()));
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = artsFiltrados;
        }
        private void cmbCategoría_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboCategoriaGrilla();
        }
        private void ComboCategoriaGrilla()
        {
            List<ArticuloDTO> articulosGrilla = (List<ArticuloDTO>)dgvArticulos.DataSource;
            if (cmbCategoría.SelectedValue.ToString() != "0")
            {
                VistaCategoriaGrilla((List<ArticuloDTO>)dgvArticulos.DataSource);
                if (cmbMarca.SelectedValue.ToString() != "0")
                    VistaMarcaGrilla((List<ArticuloDTO>)dgvArticulos.DataSource);
            }
            if (cmbCategoría.SelectedValue.ToString() == "0")
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = articuloDTOs;
                if (cmbMarca.SelectedValue.ToString() != "0")
                    VistaMarcaGrilla((List<ArticuloDTO>)dgvArticulos.DataSource);
            }
            FormatoGrilla();
        }
    }
}
