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

namespace VistaArticulos
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                listaArticulo = articuloNegocio.ListarArticulos();

                dgvArticulos.DataSource = listaArticulo;
                pbxArticulo.Load(listaArticulo[0].ImagenUrl);
                FormatoGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FormatoGrilla()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxFiltroRapido(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            FormatoGrilla();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulo seleccionado = null;
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
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
            frmEditarArticulo editar = new frmEditarArticulo();
            editar.ShowDialog();
        }
    }
}
