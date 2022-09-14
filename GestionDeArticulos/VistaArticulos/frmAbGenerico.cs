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
            if (_tipo == "Marca")
                CargarMarca();
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
        private void CargarMarca()
        {
            try
            {
                dgvABM.DataSource = null;
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                marcas = marcaNegocio.Marcas();

                dgvABM.DataSource = marcas;
                dgvABM.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtDescrip.Text.Trim().Equals(""))
            {
                MensajeSinDatos();
                return;
            }
            if (!txtDescrip.Text.Trim().Equals(""))
            {
                DialogResult result = MessageBox.Show("Se va dar de alta la siguiente descripcion: " + txtDescrip.Text.Trim(), "Alta Descripción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                    EjecutarAlta();
            }
        }
        private void MensajeSinDatos()
        {
            MessageBox.Show("Descripcion sin datos", "Sin descripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EjecutarAlta()
        {
            if (_tipo.Equals("Categoria"))
            {
                Categoria categoria = new Categoria();
                categoria.Descripcion = txtDescrip.Text.Trim();
                EjecutarAlta(categoria);
            }
            if (_tipo.Equals("Marca"))
            {
                Marca marca  = new Marca();
                marca.Descripcion = txtDescrip.Text.Trim();
                EjecutarAlta(marca);
            }
        }

        private void EjecutarAlta(Categoria categoria)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            if (categoriaNegocio.Alta(categoria))
            {
                MensajeAlta();
                CargarCategoria();
            }
        }
        private void EjecutarAlta(Marca marca )
        {
            MarcaNegocio marcaNegocio  = new MarcaNegocio();
            if (marcaNegocio.Alta(marca))
            {
                MensajeAlta();
                CargarMarca();
            }
        }
        private void MensajeAlta()
        {
            txtDescrip.Text = string.Empty;
            MessageBox.Show("Nueva alta categoría", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarCategoria();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtDescrip.Text.Trim().Equals(""))
            {
                MensajeSinDatos();
                return;
            }
            if (dgvABM.Rows.Count > 0 && _tipo.Equals("Categoria"))
            {
                ModificarCategoria();
            }
            if (dgvABM.Rows.Count > 0 && _tipo.Equals("Marca"))
            {
                ModificarMarca();
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
        private void ModificarMarca()
        {
            Marca marca = (Marca)dgvABM.CurrentRow.DataBoundItem;
            marca.Descripcion = txtDescrip.Text.Trim();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            if (marcaNegocio.Modifica(marca))
            {
                txtDescrip.Text = string.Empty;
                MessageBox.Show("Modificación categoría correcta", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMarca();
            }
        }
    }
}
