namespace WinFormAPP
{
    partial class frmListArt
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
            this.dgvArt = new System.Windows.Forms.DataGridView();
            this.pboxImagenUrl = new System.Windows.Forms.PictureBox();
            this.btnVerDetalleArt = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArt
            // 
            this.dgvArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArt.Location = new System.Drawing.Point(12, 85);
            this.dgvArt.MultiSelect = false;
            this.dgvArt.Name = "dgvArt";
            this.dgvArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArt.Size = new System.Drawing.Size(522, 250);
            this.dgvArt.TabIndex = 0;
            this.dgvArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArt_CellContentClick);
            this.dgvArt.SelectionChanged += new System.EventHandler(this.dgvArt_SelectionChanged);
            // 
            // pboxImagenUrl
            // 
            this.pboxImagenUrl.Location = new System.Drawing.Point(540, 85);
            this.pboxImagenUrl.Name = "pboxImagenUrl";
            this.pboxImagenUrl.Size = new System.Drawing.Size(343, 250);
            this.pboxImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagenUrl.TabIndex = 1;
            this.pboxImagenUrl.TabStop = false;
            // 
            // btnVerDetalleArt
            // 
            this.btnVerDetalleArt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerDetalleArt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleArt.Location = new System.Drawing.Point(285, 45);
            this.btnVerDetalleArt.Name = "btnVerDetalleArt";
            this.btnVerDetalleArt.Size = new System.Drawing.Size(84, 28);
            this.btnVerDetalleArt.TabIndex = 2;
            this.btnVerDetalleArt.Text = "Ver detalle";
            this.btnVerDetalleArt.UseVisualStyleBackColor = false;
            this.btnVerDetalleArt.Click += new System.EventHandler(this.btnVerDetalleArt_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(432, 45);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(75, 28);
            this.btnAgregarArticulo.TabIndex = 3;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(572, 45);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(80, 28);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(714, 45);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarArticulo.TabIndex = 5;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 50);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(231, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(13, 356);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(70, 16);
            this.lblCat.TabIndex = 7;
            this.lblCat.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(82, 351);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 8;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(227, 356);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 16);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(285, 351);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 10;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(462, 349);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(89, 23);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // frmListArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 381);
            this.ControlBox = false;
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnVerDetalleArt);
            this.Controls.Add(this.pboxImagenUrl);
            this.Controls.Add(this.dgvArt);
            this.Name = "frmListArt";
            this.Text = "frmListArt";
            this.Load += new System.EventHandler(this.frmListArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArt;
        private System.Windows.Forms.PictureBox pboxImagenUrl;
        private System.Windows.Forms.Button btnVerDetalleArt;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnAplicar;
    }
}