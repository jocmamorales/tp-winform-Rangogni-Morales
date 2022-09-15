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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarArticulo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbxArtEditar = new System.Windows.Forms.PictureBox();
            this.lblEditarArticulo = new System.Windows.Forms.Label();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblGrillaDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtEditar)).BeginInit();
            this.gbxDatosArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosEditar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxArtEditar
            // 
            this.pbxArtEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxArtEditar.Location = new System.Drawing.Point(0, 108);
            this.pbxArtEditar.Name = "pbxArtEditar";
            this.pbxArtEditar.Size = new System.Drawing.Size(289, 273);
            this.pbxArtEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArtEditar.TabIndex = 4;
            this.pbxArtEditar.TabStop = false;
            // 
            // lblEditarArticulo
            // 
            this.lblEditarArticulo.AutoSize = true;
            this.lblEditarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarArticulo.Location = new System.Drawing.Point(123, 18);
            this.lblEditarArticulo.Name = "lblEditarArticulo";
            this.lblEditarArticulo.Size = new System.Drawing.Size(181, 24);
            this.lblEditarArticulo.TabIndex = 0;
            this.lblEditarArticulo.Text = "Detalle de Artículo";
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarArticulo.Image")));
            this.btnModificarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarArticulo.Location = new System.Drawing.Point(0, 72);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(289, 36);
            this.btnModificarArticulo.TabIndex = 1;
            this.btnModificarArticulo.Text = "&Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarArticulo.Image")));
            this.btnAgregarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(289, 36);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "&Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnSalirEditarArticulo
            // 
            this.btnSalirEditarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirEditarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirEditarArticulo.Image")));
            this.btnSalirEditarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirEditarArticulo.Location = new System.Drawing.Point(1025, 383);
            this.btnSalirEditarArticulo.Name = "btnSalirEditarArticulo";
            this.btnSalirEditarArticulo.Size = new System.Drawing.Size(150, 36);
            this.btnSalirEditarArticulo.TabIndex = 4;
            this.btnSalirEditarArticulo.Text = "&Salir";
            this.btnSalirEditarArticulo.UseVisualStyleBackColor = true;
            this.btnSalirEditarArticulo.Click += new System.EventHandler(this.btnSalirEditarArticulo_Click);
            // 
            // lblDescripcionEditar
            // 
            this.lblDescripcionEditar.AutoSize = true;
            this.lblDescripcionEditar.Location = new System.Drawing.Point(33, 100);
            this.lblDescripcionEditar.Name = "lblDescripcionEditar";
            this.lblDescripcionEditar.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcionEditar.TabIndex = 1;
            this.lblDescripcionEditar.Text = "&Descripción";
            // 
            // lblImagenEditar
            // 
            this.lblImagenEditar.AutoSize = true;
            this.lblImagenEditar.Location = new System.Drawing.Point(57, 245);
            this.lblImagenEditar.Name = "lblImagenEditar";
            this.lblImagenEditar.Size = new System.Drawing.Size(48, 13);
            this.lblImagenEditar.TabIndex = 2;
            this.lblImagenEditar.Text = "&Imagen";
            // 
            // lblNombreEditarArt
            // 
            this.lblNombreEditarArt.AutoSize = true;
            this.lblNombreEditarArt.Location = new System.Drawing.Point(55, 61);
            this.lblNombreEditarArt.Name = "lblNombreEditarArt";
            this.lblNombreEditarArt.Size = new System.Drawing.Size(50, 13);
            this.lblNombreEditarArt.TabIndex = 0;
            this.lblNombreEditarArt.Text = "&Nombre";
            // 
            // btnImagenArchivo
            // 
            this.btnImagenArchivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImagenArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnImagenArchivo.Image")));
            this.btnImagenArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagenArchivo.Location = new System.Drawing.Point(287, 271);
            this.btnImagenArchivo.Name = "btnImagenArchivo";
            this.btnImagenArchivo.Size = new System.Drawing.Size(103, 28);
            this.btnImagenArchivo.TabIndex = 7;
            this.btnImagenArchivo.Text = "Archiv&o";
            this.btnImagenArchivo.UseVisualStyleBackColor = true;
            this.btnImagenArchivo.Click += new System.EventHandler(this.btnImagenArchivo_Click);
            // 
            // txtImagenEditar
            // 
            this.txtImagenEditar.Location = new System.Drawing.Point(111, 245);
            this.txtImagenEditar.Name = "txtImagenEditar";
            this.txtImagenEditar.Size = new System.Drawing.Size(277, 20);
            this.txtImagenEditar.TabIndex = 6;
            this.txtImagenEditar.TextChanged += new System.EventHandler(this.txtImagenEditar_TextChanged);
            // 
            // txtDescripcionEditar
            // 
            this.txtDescripcionEditar.Location = new System.Drawing.Point(111, 100);
            this.txtDescripcionEditar.Name = "txtDescripcionEditar";
            this.txtDescripcionEditar.Size = new System.Drawing.Size(277, 20);
            this.txtDescripcionEditar.TabIndex = 2;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(111, 61);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(277, 20);
            this.txtNombreEditar.TabIndex = 1;
            // 
            // lbl1Codigo
            // 
            this.lbl1Codigo.AutoSize = true;
            this.lbl1Codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1Codigo.Location = new System.Drawing.Point(59, 19);
            this.lbl1Codigo.Name = "lbl1Codigo";
            this.lbl1Codigo.Size = new System.Drawing.Size(46, 13);
            this.lbl1Codigo.TabIndex = 9;
            this.lbl1Codigo.Text = "&Codigo";
            // 
            // cboMarcaEditar
            // 
            this.cboMarcaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaEditar.FormattingEnabled = true;
            this.cboMarcaEditar.Location = new System.Drawing.Point(111, 139);
            this.cboMarcaEditar.Name = "cboMarcaEditar";
            this.cboMarcaEditar.Size = new System.Drawing.Size(277, 21);
            this.cboMarcaEditar.TabIndex = 3;
            // 
            // txtCodigoEditar
            // 
            this.txtCodigoEditar.Location = new System.Drawing.Point(111, 19);
            this.txtCodigoEditar.Name = "txtCodigoEditar";
            this.txtCodigoEditar.Size = new System.Drawing.Size(277, 20);
            this.txtCodigoEditar.TabIndex = 0;
            // 
            // cboCategoriaEditar
            // 
            this.cboCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaEditar.FormattingEnabled = true;
            this.cboCategoriaEditar.Location = new System.Drawing.Point(111, 177);
            this.cboCategoriaEditar.Name = "cboCategoriaEditar";
            this.cboCategoriaEditar.Size = new System.Drawing.Size(277, 21);
            this.cboCategoriaEditar.TabIndex = 4;
            // 
            // lblMarcaEditar
            // 
            this.lblMarcaEditar.AutoSize = true;
            this.lblMarcaEditar.Location = new System.Drawing.Point(63, 139);
            this.lblMarcaEditar.Name = "lblMarcaEditar";
            this.lblMarcaEditar.Size = new System.Drawing.Size(42, 13);
            this.lblMarcaEditar.TabIndex = 13;
            this.lblMarcaEditar.Text = "&Marca";
            // 
            // gbxDatosArticulo
            // 
            this.gbxDatosArticulo.BackColor = System.Drawing.Color.White;
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
            this.gbxDatosArticulo.ForeColor = System.Drawing.Color.BlueViolet;
            this.gbxDatosArticulo.Location = new System.Drawing.Point(12, 49);
            this.gbxDatosArticulo.Name = "gbxDatosArticulo";
            this.gbxDatosArticulo.Size = new System.Drawing.Size(390, 307);
            this.gbxDatosArticulo.TabIndex = 1;
            this.gbxDatosArticulo.TabStop = false;
            // 
            // txtPrecioEditar
            // 
            this.txtPrecioEditar.Location = new System.Drawing.Point(111, 212);
            this.txtPrecioEditar.Name = "txtPrecioEditar";
            this.txtPrecioEditar.Size = new System.Drawing.Size(277, 20);
            this.txtPrecioEditar.TabIndex = 5;
            // 
            // lblPrecioEditar
            // 
            this.lblPrecioEditar.AutoSize = true;
            this.lblPrecioEditar.Location = new System.Drawing.Point(62, 212);
            this.lblPrecioEditar.Name = "lblPrecioEditar";
            this.lblPrecioEditar.Size = new System.Drawing.Size(43, 13);
            this.lblPrecioEditar.TabIndex = 15;
            this.lblPrecioEditar.Text = "&Precio";
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(44, 177);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(63, 13);
            this.lblCategoriaEditar.TabIndex = 14;
            this.lblCategoriaEditar.Text = "&Categoría";
            // 
            // dgvArticulosEditar
            // 
            this.dgvArticulosEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulosEditar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulosEditar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulosEditar.GridColor = System.Drawing.Color.BlueViolet;
            this.dgvArticulosEditar.Location = new System.Drawing.Point(715, 49);
            this.dgvArticulosEditar.MultiSelect = false;
            this.dgvArticulosEditar.Name = "dgvArticulosEditar";
            this.dgvArticulosEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosEditar.Size = new System.Drawing.Size(460, 307);
            this.dgvArticulosEditar.TabIndex = 5;
            this.dgvArticulosEditar.SelectionChanged += new System.EventHandler(this.dgvArticulosEditar_SelectionChanged);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpiar.Image")));
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpiar.Location = new System.Drawing.Point(0, 36);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(289, 36);
            this.btLimpiar.TabIndex = 0;
            this.btLimpiar.Text = "&Limpiar Detalles";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pbxArtEditar);
            this.panel1.Controls.Add(this.btnModificarArticulo);
            this.panel1.Controls.Add(this.btLimpiar);
            this.panel1.Controls.Add(this.btnAgregarArticulo);
            this.panel1.Controls.Add(this.btnEliminarArticulo);
            this.panel1.Location = new System.Drawing.Point(408, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 417);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarArticulo.Image")));
            this.btnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(0, 381);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(289, 36);
            this.btnEliminarArticulo.TabIndex = 3;
            this.btnEliminarArticulo.Text = "&Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 363);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // lblGrillaDisponibles
            // 
            this.lblGrillaDisponibles.AutoSize = true;
            this.lblGrillaDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrillaDisponibles.Location = new System.Drawing.Point(832, 18);
            this.lblGrillaDisponibles.Name = "lblGrillaDisponibles";
            this.lblGrillaDisponibles.Size = new System.Drawing.Size(206, 24);
            this.lblGrillaDisponibles.TabIndex = 0;
            this.lblGrillaDisponibles.Text = "Artículos Disponibles";
            // 
            // frmEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1187, 420);
            this.Controls.Add(this.lblGrillaDisponibles);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvArticulosEditar);
            this.Controls.Add(this.btnSalirEditarArticulo);
            this.Controls.Add(this.lblEditarArticulo);
            this.Controls.Add(this.gbxDatosArticulo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1203, 459);
            this.MinimumSize = new System.Drawing.Size(1203, 459);
            this.Name = "frmEditarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición";
            this.Load += new System.EventHandler(this.frmEditarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArtEditar)).EndInit();
            this.gbxDatosArticulo.ResumeLayout(false);
            this.gbxDatosArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosEditar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxArtEditar;
        private System.Windows.Forms.Label lblEditarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Label lblGrillaDisponibles;
    }
}