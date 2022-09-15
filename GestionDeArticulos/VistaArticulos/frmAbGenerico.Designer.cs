namespace VistaArticulos
{
    partial class frmAbGenerico
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
            this.grbABM = new System.Windows.Forms.GroupBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.dgvABM = new System.Windows.Forms.DataGridView();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbABM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvABM)).BeginInit();
            this.SuspendLayout();
            // 
            // grbABM
            // 
            this.grbABM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbABM.Controls.Add(this.btnSalir);
            this.grbABM.Controls.Add(this.btnMod);
            this.grbABM.Controls.Add(this.btnAlta);
            this.grbABM.Controls.Add(this.dgvABM);
            this.grbABM.Controls.Add(this.txtDescrip);
            this.grbABM.Controls.Add(this.lblDescrip);
            this.grbABM.Location = new System.Drawing.Point(12, 22);
            this.grbABM.Name = "grbABM";
            this.grbABM.Size = new System.Drawing.Size(450, 268);
            this.grbABM.TabIndex = 5;
            this.grbABM.TabStop = false;
            this.grbABM.Text = "Grupo";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(94, 230);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 21);
            this.btnMod.TabIndex = 10;
            this.btnMod.Text = "Modifca";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(13, 230);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 21);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Nuevo";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dgvABM
            // 
            this.dgvABM.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvABM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvABM.Location = new System.Drawing.Point(13, 18);
            this.dgvABM.Name = "dgvABM";
            this.dgvABM.ReadOnly = true;
            this.dgvABM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvABM.Size = new System.Drawing.Size(415, 161);
            this.dgvABM.TabIndex = 8;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(79, 194);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(349, 20);
            this.txtDescrip.TabIndex = 7;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(10, 197);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(61, 12);
            this.lblDescrip.TabIndex = 6;
            this.lblDescrip.Text = "Descripción";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(353, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 21);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAbGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 301);
            this.Controls.Add(this.grbABM);
            this.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAbGenerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descripciones";
            this.Load += new System.EventHandler(this.frmAbmGenerico_Load);
            this.grbABM.ResumeLayout(false);
            this.grbABM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvABM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbABM;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridView dgvABM;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Button btnSalir;
    }
}