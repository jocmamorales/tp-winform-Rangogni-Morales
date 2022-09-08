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
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                List<Articulo> articulos = articuloNegocio.ListarArticulos();

                dgvArtiulos.DataSource = articulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
            
        }
    }
}
