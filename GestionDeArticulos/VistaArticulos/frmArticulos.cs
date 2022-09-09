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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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
                listaFiltrada = listaArticulo.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

    }
}
