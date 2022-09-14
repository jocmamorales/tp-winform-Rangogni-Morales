namespace VistaArticulos
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnNuevoArt = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategori = new System.Windows.Forms.Label();
            this.cmbCategoría = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(4, 51);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(453, 296);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnNuevoArt
            // 
            this.btnNuevoArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNuevoArt.Location = new System.Drawing.Point(574, 353);
            this.btnNuevoArt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevoArt.Name = "btnNuevoArt";
            this.btnNuevoArt.Size = new System.Drawing.Size(122, 29);
            this.btnNuevoArt.TabIndex = 1;
            this.btnNuevoArt.Text = "+   &Editar Articulo";
            this.btnNuevoArt.UseVisualStyleBackColor = true;
            this.btnNuevoArt.Click += new System.EventHandler(this.btnNuevoArt_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(76, 25);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(192, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtBoxFiltroRapido);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(2, 28);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(68, 12);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtro Rápido";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(462, 51);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(234, 296);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 6;
            this.pbxArticulo.TabStop = false;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Todos"});
            this.cmbMarca.Location = new System.Drawing.Point(532, 25);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 20);
            this.cmbMarca.TabIndex = 7;
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.cmbMarca_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca";
            // 
            // lblCategori
            // 
            this.lblCategori.AutoSize = true;
            this.lblCategori.Location = new System.Drawing.Point(283, 28);
            this.lblCategori.Name = "lblCategori";
            this.lblCategori.Size = new System.Drawing.Size(53, 12);
            this.lblCategori.TabIndex = 10;
            this.lblCategori.Text = "Categoría";
            // 
            // cmbCategoría
            // 
            this.cmbCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoría.FormattingEnabled = true;
            this.cmbCategoría.Items.AddRange(new object[] {
            "Todos"});
            this.cmbCategoría.Location = new System.Drawing.Point(342, 25);
            this.cmbCategoría.Name = "cmbCategoría";
            this.cmbCategoría.Size = new System.Drawing.Size(121, 20);
            this.cmbCategoría.TabIndex = 9;
            this.cmbCategoría.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoría_SelectionChangeCommitted);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(720, 390);
            this.Controls.Add(this.lblCategori);
            this.Controls.Add(this.cmbCategoría);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnNuevoArt);
            this.Controls.Add(this.dgvArticulos);
            this.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnNuevoArt;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategori;
        private System.Windows.Forms.ComboBox cmbCategoría;
    }
}