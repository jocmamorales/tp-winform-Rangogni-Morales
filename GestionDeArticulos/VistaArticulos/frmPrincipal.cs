using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaArticulos
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos frm = new frmArticulos();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Finalizar el programa ", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Dispose();
        }

        private void altaModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbGenerico frmAbm = new frmAbGenerico("Categoria","Alta");
            frmAbm.ShowDialog();
        }

        private void altaModificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbGenerico frmAb = new frmAbGenerico("Marca", "Alta");
            frmAb.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos frm = new frmArticulos();
            frm.ShowDialog();
        }

        private void ediciónToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmEditarArticulo editar =  new frmEditarArticulo();
            editar.ShowDialog();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbGenerico frmAb = new frmAbGenerico("Marca", "Modificacion");
            frmAb.ShowDialog();
        }

        private void modificacónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbGenerico frmAbm = new frmAbGenerico("Categoria", "Modificaion");
            frmAbm.ShowDialog();
        }

        private void tsmAcerca_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Item management system 2022 (Version Berta 1.0) ©2022 UTN FRGP Rangogni Roberto - Morales Jose  ", "Acerca Sistema de Gestion de Artículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
