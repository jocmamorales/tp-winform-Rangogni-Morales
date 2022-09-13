namespace VistaArticulos
{
    partial class frmEditarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxArtEditar = new System.Windows.Forms.PictureBox();
            this.lblEditarArticulo = new System.Windows.Forms.Label();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnSalirEditarArticulo = new System.Windows.Forms.Button();
            this.lblDescripcionEditar = new System.Windows.Forms.Label();
            this.lblImagenEditar = new System.Windows.Forms.Label();
            this.lblNombreEditarArt = new System.Windows.Forms.Label();
            this.btnImagenArchivo = new System.Windows.Forms.Button();
            this.txtImagenEditar = new System.Windows.Forms.TextBox();
            this.txtDescripcionEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.lbl1Codigo = new System.Windows.Forms.Label();
            this.cboMarcaEditar = new System.Windows.Forms.ComboBox();
            this.txtCodigoEditar = new System.Windows.Forms.TextBox();
            this.cboCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblMarcaEditar = new System.Windows.Forms.Label();
            this.gbxDatosArticulo = new System.Windows.Forms.GroupBox();
            this.txtPrecioEditar = new System.Windows.Forms.TextBox();
            this.lblPrecioEditar = new System.Windows.Forms.Label();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.dgvArticulosEditar = new System.Windows.Forms.DataGridView();
            this.btLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtEditar)).BeginInit();
            this.gbxDatosArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArtEditar
            // 
            this.pbxArtEditar.Location = new System.Drawing.Point(417, 39);
            this.pbxArtEditar.Name = "pbxArtEditar";
            this.pbxArtEditar.Size = new System.Drawing.Size(212, 130);
            this.pbxArtEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArtEditar.TabIndex = 4;
            this.pbxArtEditar.TabStop = false;
            this.pbxArtEditar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblEditarArticulo
            // 
            this.lblEditarArticulo.AutoSize = true;
            this.lblEditarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarArticulo.Location = new System.Drawing.Point(12, 10);
            this.lblEditarArticulo.Name = "lblEditarArticulo";
            this.lblEditarArticulo.Size = new System.Drawing.Size(123, 20);
            this.lblEditarArticulo.TabIndex = 5;
            this.lblEditarArticulo.Text = "Editar Artículo";
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(468, 271);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(119, 26);
            this.btnModificarArticulo.TabIndex = 2;
            this.btnModificarArticulo.Text = "&Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(468, 226);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(119, 26);
            this.btnAgregarArticulo.TabIndex = 1;
            this.btnAgregarArticulo.Text = "&Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(468, 313);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(119, 26);
            this.btnEliminarArticulo.TabIndex = 3;
            this.btnEliminarArticulo.Text = "&Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnSalirEditarArticulo
            // 
            this.btnSalirEditarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirEditarArticulo.Location = new System.Drawing.Point(959, 372);
            this.btnSalirEditarArticulo.Name = "btnSalirEditarArticulo";
            this.btnSalirEditarArticulo.Size = new System.Drawing.Size(75, 25);
            this.btnSalirEditarArticulo.TabIndex = 4;
            this.btnSalirEditarArticulo.Text = "&Salir";
            this.btnSalirEditarArticulo.UseVisualStyleBackColor = true;
            this.btnSalirEditarArticulo.Click += new System.EventHandler(this.btnSalirEditarArticulo_Click);
            // 
            // lblDescripcionEditar
            // 
            this.lblDescripcionEditar.AutoSize = true;
            this.lblDescripcionEditar.Location = new System.Drawing.Point(33, 108);
            this.lblDescripcionEditar.Name = "lblDescripcionEditar";
            this.lblDescripcionEditar.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcionEditar.TabIndex = 1;
            this.lblDescripcionEditar.Text = "Descripción";
            // 
            // lblImagenEditar
            // 
            this.lblImagenEditar.AutoSize = true;
            this.lblImagenEditar.Location = new System.Drawing.Point(57, 252);
            this.lblImagenEditar.Name = "lblImagenEditar";
            this.lblImagenEditar.Size = new System.Drawing.Size(48, 13);
            this.lblImagenEditar.TabIndex = 2;
            this.lblImagenEditar.Text = "Imagen";
            // 
            // lblNombreEditarArt
            // 
            this.lblNombreEditarArt.AutoSize = true;
            this.lblNombreEditarArt.Location = new System.Drawing.Point(57, 72);
            this.lblNombreEditarArt.Name = "lblNombreEditarArt";
            this.lblNombreEditarArt.Size = new System.Drawing.Size(50, 13);
            this.lblNombreEditarArt.TabIndex = 0;
            this.lblNombreEditarArt.Text = "Nombre";
            // 
            // btnImagenArchivo
            // 
            this.btnImagenArchivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenArchivo.Location = new System.Drawing.Point(337, 276);
            this.btnImagenArchivo.Name = "btnImagenArchivo";
            this.btnImagenArchivo.Size = new System.Drawing.Size(53, 23);
            this.btnImagenArchivo.TabIndex = 7;
            this.btnImagenArchivo.Text = "Archiv&o";
            this.btnImagenArchivo.UseVisualStyleBackColor = true;
            this.btnImagenArchivo.Click += new System.EventHandler(this.btnImagenArchivo_Click);
            // 
            // txtImagenEditar
            // 
            this.txtImagenEditar.Location = new System.Drawing.Point(111, 252);
            this.txtImagenEditar.Name = "txtImagenEditar";
            this.txtImagenEditar.Size = new System.Drawing.Size(279, 20);
            this.txtImagenEditar.TabIndex = 6;
            this.txtImagenEditar.TextChanged += new System.EventHandler(this.txtImagenEditar_TextChanged);
            // 
            // txtDescripcionEditar
            // 
            this.txtDescripcionEditar.Location = new System.Drawing.Point(113, 100);
            this.txtDescripcionEditar.Name = "txtDescripcionEditar";
            this.txtDescripcionEditar.Size = new System.Drawing.Size(275, 20);
            this.txtDescripcionEditar.TabIndex = 2;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(113, 65);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(275, 20);
            this.txtNombreEditar.TabIndex = 1;
            // 
            // lbl1Codigo
            // 
            this.lbl1Codigo.AutoSize = true;
            this.lbl1Codigo.Location = new System.Drawing.Point(57, 33);
            this.lbl1Codigo.Name = "lbl1Codigo";
            this.lbl1Codigo.Size = new System.Drawing.Size(46, 13);
            this.lbl1Codigo.TabIndex = 9;
            this.lbl1Codigo.Text = "Codigo";
            // 
            // cboMarcaEditar
            // 
            this.cboMarcaEditar.FormattingEnabled = true;
            this.cboMarcaEditar.Location = new System.Drawing.Point(113, 139);
            this.cboMarcaEditar.Name = "cboMarcaEditar";
            this.cboMarcaEditar.Size = new System.Drawing.Size(275, 21);
            this.cboMarcaEditar.TabIndex = 3;
            // 
            // txtCodigoEditar
            // 
            this.txtCodigoEditar.Location = new System.Drawing.Point(113, 30);
            this.txtCodigoEditar.Name = "txtCodigoEditar";
            this.txtCodigoEditar.Size = new System.Drawing.Size(275, 20);
            this.txtCodigoEditar.TabIndex = 0;
            // 
            // cboCategoriaEditar
            // 
            this.cboCategoriaEditar.FormattingEnabled = true;
            this.cboCategoriaEditar.Location = new System.Drawing.Point(113, 177);
            this.cboCategoriaEditar.Name = "cboCategoriaEditar";
            this.cboCategoriaEditar.Size = new System.Drawing.Size(275, 21);
            this.cboCategoriaEditar.TabIndex = 4;
            // 
            // lblMarcaEditar
            // 
            this.lblMarcaEditar.AutoSize = true;
            this.lblMarcaEditar.Location = new System.Drawing.Point(61, 148);
            this.lblMarcaEditar.Name = "lblMarcaEditar";
            this.lblMarcaEditar.Size = new System.Drawing.Size(42, 13);
            this.lblMarcaEditar.TabIndex = 13;
            this.lblMarcaEditar.Text = "Marca";
            // 
            // gbxDatosArticulo
            // 
            this.gbxDatosArticulo.Controls.Add(this.txtPrecioEditar);
            this.gbxDatosArticulo.Controls.Add(this.lblPrecioEditar);
            this.gbxDatosArticulo.Controls.Add(this.lblCategoriaEditar);
            this.gbxDatosArticulo.Controls.Add(this.lblMarcaEditar);
            this.gbxDatosArticulo.Controls.Add(this.cboCategoriaEditar);
            this.gbxDatosArticulo.Controls.Add(this.txtCodigoEditar);
            this.gbxDatosArticulo.Controls.Add(this.cboMarcaEditar);
            this.gbxDatosArticulo.Controls.Add(this.lbl1Codigo);
            this.gbxDatosArticulo.Controls.Add(this.txtNombreEditar);
            this.gbxDatosArticulo.Controls.Add(this.txtDescripcionEditar);
            this.gbxDatosArticulo.Controls.Add(this.txtImagenEditar);
            this.gbxDatosArticulo.Controls.Add(this.btnImagenArchivo);
            this.gbxDatosArticulo.Controls.Add(this.lblNombreEditarArt);
            this.gbxDatosArticulo.Controls.Add(this.lblImagenEditar);
            this.gbxDatosArticulo.Controls.Add(this.lblDescripcionEditar);
            this.gbxDatosArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosArticulo.Location = new System.Drawing.Point(12, 49);
            this.gbxDatosArticulo.Name = "gbxDatosArticulo";
            this.gbxDatosArticulo.Size = new System.Drawing.Size(390, 307);
            this.gbxDatosArticulo.TabIndex = 3;
            this.gbxDatosArticulo.TabStop = false;
            this.gbxDatosArticulo.Text = "Detalles";
            // 
            // txtPrecioEditar
            // 
            this.txtPrecioEditar.Location = new System.Drawing.Point(113, 211);
            this.txtPrecioEditar.Name = "txtPrecioEditar";
            this.txtPrecioEditar.Size = new System.Drawing.Size(275, 20);
            this.txtPrecioEditar.TabIndex = 5;
            // 
            // lblPrecioEditar
            // 
            this.lblPrecioEditar.AutoSize = true;
            this.lblPrecioEditar.Location = new System.Drawing.Point(62, 207);
            this.lblPrecioEditar.Name = "lblPrecioEditar";
            this.lblPrecioEditar.Size = new System.Drawing.Size(43, 13);
            this.lblPrecioEditar.TabIndex = 15;
            this.lblPrecioEditar.Text = "Precio";
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(44, 177);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(63, 13);
            this.lblCategoriaEditar.TabIndex = 14;
            this.lblCategoriaEditar.Text = "Categoría";
            // 
            // dgvArticulosEditar
            // 
            this.dgvArticulosEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulosEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosEditar.Location = new System.Drawing.Point(647, 40);
            this.dgvArticulosEditar.Name = "dgvArticulosEditar";
            this.dgvArticulosEditar.Size = new System.Drawing.Size(387, 314);
            this.dgvArticulosEditar.TabIndex = 10;
            this.dgvArticulosEditar.SelectionChanged += new System.EventHandler(this.dgvArticulosEditar_SelectionChanged);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLimpiar.Location = new System.Drawing.Point(468, 189);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(119, 25);
            this.btLimpiar.TabIndex = 0;
            this.btLimpiar.Text = "&Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // frmEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 420);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.dgvArticulosEditar);
            this.Controls.Add(this.btnSalirEditarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.lblEditarArticulo);
            this.Controls.Add(this.pbxArtEditar);
            this.Controls.Add(this.gbxDatosArticulo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1062, 459);
            this.Name = "frmEditarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición";
            this.Load += new System.EventHandler(this.frmEditarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtEditar)).EndInit();
            this.gbxDatosArticulo.ResumeLayout(false);
            this.gbxDatosArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxArtEditar;
        private System.Windows.Forms.Label lblEditarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnSalirEditarArticulo;
        private System.Windows.Forms.Label lblDescripcionEditar;
        private System.Windows.Forms.Label lblImagenEditar;
        private System.Windows.Forms.Label lblNombreEditarArt;
        private System.Windows.Forms.Button btnImagenArchivo;
        private System.Windows.Forms.TextBox txtImagenEditar;
        private System.Windows.Forms.TextBox txtDescripcionEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.Label lbl1Codigo;
        private System.Windows.Forms.ComboBox cboMarcaEditar;
        private System.Windows.Forms.TextBox txtCodigoEditar;
        private System.Windows.Forms.ComboBox cboCategoriaEditar;
        private System.Windows.Forms.Label lblMarcaEditar;
        private System.Windows.Forms.GroupBox gbxDatosArticulo;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.DataGridView dgvArticulosEditar;
        private System.Windows.Forms.TextBox txtPrecioEditar;
        private System.Windows.Forms.Label lblPrecioEditar;
        private System.Windows.Forms.Button btLimpiar;
    }
}