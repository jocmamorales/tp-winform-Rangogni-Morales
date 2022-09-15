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
        private string _am;
        private string _tipo;
        private List<Categoria> categorias = null;
        private List<Marca> marcas = null;
        public frmAbGenerico(string tipo, string am)
        {
            InitializeComponent();
            _tipo = tipo;
            _am = am;
        }

        private void frmAbmGenerico_Load(object sender, EventArgs e)
        {
            if (_tipo == "Categoria")
                CargarCategoria();
            if (_tipo == "Marca")
                CargarMarca();
            if (_am.Equals("Alta"))
                btnMod.Visible = !btnAlta.Visible;
            else
                btnAlta.Visible = !btnMod.Visible;
            grbABM.Text += " " + _tipo;

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
                MensajeTextboxSinDatos();
                return;
            }
            if (!txtDescrip.Text.Trim().Equals(""))
            {
                DialogResult result = MessageBox.Show("Se va dar de alta la siguiente descripcion: " + txtDescrip.Text.Trim(), "Alta Descripción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                    EjecutarAlta();
            }
        }
        private void MensajeTextboxSinDatos()
        {
            MessageBox.Show("Descripcion sin datos", "Sin descripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeSinSeleccionGrilla()
        {
            MessageBox.Show("No selecciono la descipción en la grilla", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtDescrip.Text.Trim().Equals("") )
            {
                MensajeTextboxSinDatos();
                return;
            }
            if ( dgvABM.CurrentRow == null)
            {
                MensajeSinSeleccionGrilla();
                return;
            }
            if (dgvABM.Rows.Count > 0 && _tipo.Equals("Categoria"))
                ModificarCategoria();
            if (dgvABM.Rows.Count > 0 && _tipo.Equals("Marca"))
                ModificarMarca();
        }

        private void ModificarCategoria()
        {
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        private void ModificarMarca()
        {
            try
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
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
