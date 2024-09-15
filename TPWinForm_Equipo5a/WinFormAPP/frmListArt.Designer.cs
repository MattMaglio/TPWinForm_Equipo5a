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
            this.btnVerDetalleArt = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.lblCat = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.dgvUrlImg = new System.Windows.Forms.DataGridView();
            this.pbArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArt
            // 
            this.dgvArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArt.Location = new System.Drawing.Point(17, 144);
            this.dgvArt.MultiSelect = false;
            this.dgvArt.Name = "dgvArt";
            this.dgvArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArt.Size = new System.Drawing.Size(507, 239);
            this.dgvArt.TabIndex = 0;
            this.dgvArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArt_CellContentClick);
            this.dgvArt.SelectionChanged += new System.EventHandler(this.dgvArt_SelectionChanged);
            // 
            // btnVerDetalleArt
            // 
            this.btnVerDetalleArt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerDetalleArt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleArt.Location = new System.Drawing.Point(244, 75);
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
            this.btnAgregarArticulo.Location = new System.Drawing.Point(17, 76);
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
            this.btnModificarArticulo.Location = new System.Drawing.Point(131, 76);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(80, 27);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(357, 75);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 27);
            this.btnEliminarArticulo.TabIndex = 5;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(336, 42);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(70, 16);
            this.lblCat.TabIndex = 7;
            this.lblCat.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(416, 42);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 8;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(553, 45);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 16);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(622, 42);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 10;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFiltrar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(762, 42);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(102, 23);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(90, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(231, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClean.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(762, 80);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(102, 23);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Clean filtros";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dgvUrlImg
            // 
            this.dgvUrlImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlImg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUrlImg.Location = new System.Drawing.Point(546, 397);
            this.dgvUrlImg.MultiSelect = false;
            this.dgvUrlImg.Name = "dgvUrlImg";
            this.dgvUrlImg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrlImg.Size = new System.Drawing.Size(318, 127);
            this.dgvUrlImg.TabIndex = 14;
            this.dgvUrlImg.SelectionChanged += new System.EventHandler(this.dgvUrlImg_SelectionChanged);
            // 
            // pbArt
            // 
            this.pbArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbArt.Location = new System.Drawing.Point(546, 144);
            this.pbArt.Margin = new System.Windows.Forms.Padding(2);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(318, 239);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 19;
            this.pbArt.TabStop = false;
            // 
            // frmListArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(894, 549);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.dgvUrlImg);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnVerDetalleArt);
            this.Controls.Add(this.dgvArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frm Lista Articulos";
            this.Load += new System.EventHandler(this.frmListArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArt;
        private System.Windows.Forms.Button btnVerDetalleArt;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dgvUrlImg;
        private System.Windows.Forms.PictureBox pbArt;
    }
}