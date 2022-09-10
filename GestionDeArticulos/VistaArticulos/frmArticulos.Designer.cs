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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
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
            this.dgvArticulos.Size = new System.Drawing.Size(212, 296);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnNuevoArt
            // 
            this.btnNuevoArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNuevoArt.Location = new System.Drawing.Point(348, 353);
            this.btnNuevoArt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevoArt.Name = "btnNuevoArt";
            this.btnNuevoArt.Size = new System.Drawing.Size(122, 29);
            this.btnNuevoArt.TabIndex = 1;
            this.btnNuevoArt.Text = "+   Editar Articulo";
            this.btnNuevoArt.UseVisualStyleBackColor = true;
            this.btnNuevoArt.Click += new System.EventHandler(this.btnNuevoArt_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(4, 353);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 29);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "-   Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(4, 25);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(192, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtBoxFiltroRapido);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(2, 10);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(68, 12);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtro Rápido";
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModificarArticulo.Location = new System.Drawing.Point(85, 353);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(75, 29);
            this.btnModificarArticulo.TabIndex = 5;
            this.btnModificarArticulo.Text = "+   Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(221, 51);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(338, 296);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 6;
            this.pbxArticulo.TabStop = false;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1217, 383);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoArt);
            this.Controls.Add(this.dgvArticulos);
            this.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}