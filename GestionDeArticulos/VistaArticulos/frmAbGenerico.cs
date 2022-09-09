using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Runtime.Remoting.Messaging;

namespace VistaArticulos
{
    public partial class frmAbGenerico : Form
    {
        private string _tipo;
        private List<Categoria> categorias = null;
        private List<Marca> marcas = null;
        public frmAbGenerico(string tipo)
        {
            InitializeComponent();
            _tipo = tipo;
        }

        private void frmAbmGenerico_Load(object sender, EventArgs e)
        {
            if (_tipo == "Categoria")
                CargarCategoria();

        }

        private void CargarCategoria()
        {
            try
            {
                dgvABM.DataSource = null;
                CategoriaNegocio categoriaNegocio = new Negocio.CategoriaNegocio();
                categorias = categoriaNegocio.Categorias();
                
                dgvABM.DataSource = categorias;
                dgvABM.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!txtDescrip.Text.Trim().Equals(""))
                AltaCatagoria();
        }

        private void AltaCatagoria()
        {
            DialogResult result = MessageBox.Show("Se va dar de alta la siguiente descripcion: " + txtDescrip.Text.Trim(), "Alta Descripción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Categoria categoria = new Categoria();
                categoria.Descripcion = txtDescrip.Text.Trim();
                EjecutarAlta(categoria);
            }
        }

        private void EjecutarAlta(Categoria categoria)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            if (categoriaNegocio.Alta(categoria))
            {
                txtDescrip.Text = string.Empty;
                MessageBox.Show("Nueva alta categoría", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategoria();
            }

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtDescrip.Text.Trim().Equals(""))
            {
                MessageBox.Show("Descripcion sin datos para modificar", "Sin descripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvABM.Rows.Count > 0 && _tipo.Equals("Categoria"))
            {
                ModificarCategoria();
            }
        }

        private void ModificarCategoria()
        {
            Categoria categoria = (Categoria)dgvABM.CurrentRow.DataBoundItem;
            categoria.Descripcion = txtDescrip.Text.Trim();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            if (categoriaNegocio.Modifica(categoria))
            {
                txtDescrip.Text = string.Empty;
                MessageBox.Show("Modificación categoría correcta", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategoria();
            }
        }
    }
}
