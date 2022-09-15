namespace VistaArticulos
{
    partial class frmGestion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaModificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaModificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.ediciónToolStripMenuItem});
            this.articulosToolStripMenuItem.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "&Artículos";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.listadoToolStripMenuItem.Text = "&Buscar";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ediciónToolStripMenuItem.Text = "&Editar";
            this.ediciónToolStripMenuItem.Click += new System.EventHandler(this.ediciónToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaModificacionToolStripMenuItem,
            this.modificacónToolStripMenuItem});
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.categoriaToolStripMenuItem.Text = "&Categoría";
            // 
            // altaModificacionToolStripMenuItem
            // 
            this.altaModificacionToolStripMenuItem.Name = "altaModificacionToolStripMenuItem";
            this.altaModificacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaModificacionToolStripMenuItem.Text = "Alta";
            this.altaModificacionToolStripMenuItem.Click += new System.EventHandler(this.altaModificacionToolStripMenuItem_Click);
            // 
            // modificacónToolStripMenuItem
            // 
            this.modificacónToolStripMenuItem.Name = "modificacónToolStripMenuItem";
            this.modificacónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificacónToolStripMenuItem.Text = "Modificacón";
            this.modificacónToolStripMenuItem.Click += new System.EventHandler(this.modificacónToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaModificaciónToolStripMenuItem,
            this.modificaciónToolStripMenuItem});
            this.marcaToolStripMenuItem.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.marcaToolStripMenuItem.Text = "&Marca";
            // 
            // altaModificaciónToolStripMenuItem
            // 
            this.altaModificaciónToolStripMenuItem.Name = "altaModificaciónToolStripMenuItem";
            this.altaModificaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaModificaciónToolStripMenuItem.Text = "Alta";
            this.altaModificaciónToolStripMenuItem.Click += new System.EventHandler(this.altaModificaciónToolStripMenuItem_Click);
            // 
            // modificaciónToolStripMenuItem
            // 
            this.modificaciónToolStripMenuItem.Name = "modificaciónToolStripMenuItem";
            this.modificaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaciónToolStripMenuItem.Text = " Modificación";
            this.modificaciónToolStripMenuItem.Click += new System.EventHandler(this.modificaciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 30);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sistema de Gestíon de Comercio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaModificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaModificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem;
    }
}

