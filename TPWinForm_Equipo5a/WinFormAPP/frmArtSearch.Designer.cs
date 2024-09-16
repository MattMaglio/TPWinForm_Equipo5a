namespace WinFormAPP
{
    partial class frmArtSearch
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
            this.lbTituloArt = new System.Windows.Forms.Label();
            this.btnSeachArt = new System.Windows.Forms.Button();
            this.cboMarcaArt = new System.Windows.Forms.ComboBox();
            this.cboCatArt = new System.Windows.Forms.ComboBox();
            this.tbPreArt = new System.Windows.Forms.TextBox();
            this.tbImgArt = new System.Windows.Forms.TextBox();
            this.tbDescArt = new System.Windows.Forms.TextBox();
            this.tbNomArt = new System.Windows.Forms.TextBox();
            this.tbCodArt = new System.Windows.Forms.TextBox();
            this.lbPreArt = new System.Windows.Forms.Label();
            this.lbImgArt = new System.Windows.Forms.Label();
            this.lbCatArt = new System.Windows.Forms.Label();
            this.lbMarcaArt = new System.Windows.Forms.Label();
            this.lbDescArt = new System.Windows.Forms.Label();
            this.lbNomArt = new System.Windows.Forms.Label();
            this.lbCodArt = new System.Windows.Forms.Label();
            this.gbSearchArt = new System.Windows.Forms.GroupBox();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.btnModArt = new System.Windows.Forms.Button();
            this.btnDeletArt = new System.Windows.Forms.Button();
            this.dgvUrlImg = new System.Windows.Forms.DataGridView();
            this.pbArt = new System.Windows.Forms.PictureBox();
            this.btnDelUrl = new System.Windows.Forms.Button();
            this.gbUrl = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelarBusquedaArt = new System.Windows.Forms.Button();
            this.gbSearchArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.gbUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloArt
            // 
            this.lbTituloArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTituloArt.AutoSize = true;
            this.lbTituloArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArt.Location = new System.Drawing.Point(303, 9);
            this.lbTituloArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloArt.Name = "lbTituloArt";
            this.lbTituloArt.Size = new System.Drawing.Size(226, 25);
            this.lbTituloArt.TabIndex = 17;
            this.lbTituloArt.Text = "Busqueda de artículos";
            // 
            // btnSeachArt
            // 
            this.btnSeachArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeachArt.Location = new System.Drawing.Point(388, 49);
            this.btnSeachArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeachArt.Name = "btnSeachArt";
            this.btnSeachArt.Size = new System.Drawing.Size(141, 27);
            this.btnSeachArt.TabIndex = 32;
            this.btnSeachArt.Text = "Buscar artículo";
            this.btnSeachArt.UseVisualStyleBackColor = true;
            this.btnSeachArt.Click += new System.EventHandler(this.btnSeachArt_Click);
            // 
            // cboMarcaArt
            // 
            this.cboMarcaArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaArt.FormattingEnabled = true;
            this.cboMarcaArt.Location = new System.Drawing.Point(129, 140);
            this.cboMarcaArt.Margin = new System.Windows.Forms.Padding(4);
            this.cboMarcaArt.Name = "cboMarcaArt";
            this.cboMarcaArt.Size = new System.Drawing.Size(210, 22);
            this.cboMarcaArt.TabIndex = 31;
            // 
            // cboCatArt
            // 
            this.cboCatArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatArt.FormattingEnabled = true;
            this.cboCatArt.Location = new System.Drawing.Point(129, 103);
            this.cboCatArt.Margin = new System.Windows.Forms.Padding(4);
            this.cboCatArt.Name = "cboCatArt";
            this.cboCatArt.Size = new System.Drawing.Size(208, 22);
            this.cboCatArt.TabIndex = 30;
            // 
            // tbPreArt
            // 
            this.tbPreArt.Location = new System.Drawing.Point(129, 169);
            this.tbPreArt.Margin = new System.Windows.Forms.Padding(4);
            this.tbPreArt.Name = "tbPreArt";
            this.tbPreArt.Size = new System.Drawing.Size(122, 20);
            this.tbPreArt.TabIndex = 29;
            // 
            // tbImgArt
            // 
            this.tbImgArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbImgArt.Location = new System.Drawing.Point(144, 21);
            this.tbImgArt.Margin = new System.Windows.Forms.Padding(4);
            this.tbImgArt.Name = "tbImgArt";
            this.tbImgArt.Size = new System.Drawing.Size(361, 20);
            this.tbImgArt.TabIndex = 28;
            // 
            // tbDescArt
            // 
            this.tbDescArt.Location = new System.Drawing.Point(129, 64);
            this.tbDescArt.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescArt.Name = "tbDescArt";
            this.tbDescArt.Size = new System.Drawing.Size(361, 20);
            this.tbDescArt.TabIndex = 27;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Location = new System.Drawing.Point(129, 33);
            this.tbNomArt.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(208, 20);
            this.tbNomArt.TabIndex = 26;
            // 
            // tbCodArt
            // 
            this.tbCodArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCodArt.Location = new System.Drawing.Point(264, 52);
            this.tbCodArt.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(116, 20);
            this.tbCodArt.TabIndex = 25;
            // 
            // lbPreArt
            // 
            this.lbPreArt.AutoSize = true;
            this.lbPreArt.Location = new System.Drawing.Point(73, 173);
            this.lbPreArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPreArt.Name = "lbPreArt";
            this.lbPreArt.Size = new System.Drawing.Size(46, 14);
            this.lbPreArt.TabIndex = 24;
            this.lbPreArt.Text = "Precio:";
            // 
            // lbImgArt
            // 
            this.lbImgArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbImgArt.AutoSize = true;
            this.lbImgArt.Location = new System.Drawing.Point(39, 23);
            this.lbImgArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImgArt.Name = "lbImgArt";
            this.lbImgArt.Size = new System.Drawing.Size(98, 14);
            this.lbImgArt.TabIndex = 23;
            this.lbImgArt.Text = "URL de Imagen:";
            // 
            // lbCatArt
            // 
            this.lbCatArt.AutoSize = true;
            this.lbCatArt.Location = new System.Drawing.Point(55, 104);
            this.lbCatArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCatArt.Name = "lbCatArt";
            this.lbCatArt.Size = new System.Drawing.Size(67, 14);
            this.lbCatArt.TabIndex = 22;
            this.lbCatArt.Text = "Categoria:";
            // 
            // lbMarcaArt
            // 
            this.lbMarcaArt.AutoSize = true;
            this.lbMarcaArt.Location = new System.Drawing.Point(73, 139);
            this.lbMarcaArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarcaArt.Name = "lbMarcaArt";
            this.lbMarcaArt.Size = new System.Drawing.Size(47, 14);
            this.lbMarcaArt.TabIndex = 21;
            this.lbMarcaArt.Text = "Marca:";
            // 
            // lbDescArt
            // 
            this.lbDescArt.AutoSize = true;
            this.lbDescArt.Location = new System.Drawing.Point(42, 65);
            this.lbDescArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescArt.Name = "lbDescArt";
            this.lbDescArt.Size = new System.Drawing.Size(77, 14);
            this.lbDescArt.TabIndex = 20;
            this.lbDescArt.Text = "Descripción:";
            // 
            // lbNomArt
            // 
            this.lbNomArt.AutoSize = true;
            this.lbNomArt.Location = new System.Drawing.Point(64, 33);
            this.lbNomArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomArt.Name = "lbNomArt";
            this.lbNomArt.Size = new System.Drawing.Size(57, 14);
            this.lbNomArt.TabIndex = 19;
            this.lbNomArt.Text = "Nombre:";
            // 
            // lbCodArt
            // 
            this.lbCodArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(145, 54);
            this.lbCodArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(116, 14);
            this.lbCodArt.TabIndex = 18;
            this.lbCodArt.Text = "Codigo de Articulo:";
            // 
            // gbSearchArt
            // 
            this.gbSearchArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSearchArt.Controls.Add(this.lbNomArt);
            this.gbSearchArt.Controls.Add(this.lbDescArt);
            this.gbSearchArt.Controls.Add(this.cboMarcaArt);
            this.gbSearchArt.Controls.Add(this.lbMarcaArt);
            this.gbSearchArt.Controls.Add(this.cboCatArt);
            this.gbSearchArt.Controls.Add(this.lbCatArt);
            this.gbSearchArt.Controls.Add(this.tbPreArt);
            this.gbSearchArt.Controls.Add(this.lbPreArt);
            this.gbSearchArt.Controls.Add(this.tbDescArt);
            this.gbSearchArt.Controls.Add(this.tbNomArt);
            this.gbSearchArt.Location = new System.Drawing.Point(142, 126);
            this.gbSearchArt.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchArt.Name = "gbSearchArt";
            this.gbSearchArt.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchArt.Size = new System.Drawing.Size(598, 205);
            this.gbSearchArt.TabIndex = 33;
            this.gbSearchArt.TabStop = false;
            this.gbSearchArt.Text = "Articulo:";
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUrl.Location = new System.Drawing.Point(144, 49);
            this.btnAddUrl.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(80, 24);
            this.btnAddUrl.TabIndex = 32;
            this.btnAddUrl.Text = "Add URL";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // btnModArt
            // 
            this.btnModArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModArt.BackColor = System.Drawing.Color.White;
            this.btnModArt.Location = new System.Drawing.Point(142, 84);
            this.btnModArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnModArt.Name = "btnModArt";
            this.btnModArt.Size = new System.Drawing.Size(155, 34);
            this.btnModArt.TabIndex = 34;
            this.btnModArt.Text = "Modificar artículo";
            this.btnModArt.UseVisualStyleBackColor = false;
            this.btnModArt.Click += new System.EventHandler(this.btnModArt_Click);
            // 
            // btnDeletArt
            // 
            this.btnDeletArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletArt.BackColor = System.Drawing.Color.Red;
            this.btnDeletArt.Location = new System.Drawing.Point(308, 84);
            this.btnDeletArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletArt.Name = "btnDeletArt";
            this.btnDeletArt.Size = new System.Drawing.Size(155, 34);
            this.btnDeletArt.TabIndex = 35;
            this.btnDeletArt.Text = "Eliminar artículo";
            this.btnDeletArt.UseVisualStyleBackColor = false;
            this.btnDeletArt.Click += new System.EventHandler(this.btnDeletArt_Click);
            // 
            // dgvUrlImg
            // 
            this.dgvUrlImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUrlImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlImg.Location = new System.Drawing.Point(15, 79);
            this.dgvUrlImg.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUrlImg.Name = "dgvUrlImg";
            this.dgvUrlImg.Size = new System.Drawing.Size(280, 192);
            this.dgvUrlImg.TabIndex = 36;
            this.dgvUrlImg.SelectionChanged += new System.EventHandler(this.dgvUrlImg_SelectionChanged);
            // 
            // pbArt
            // 
            this.pbArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbArt.Location = new System.Drawing.Point(302, 79);
            this.pbArt.Margin = new System.Windows.Forms.Padding(4);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(282, 192);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 37;
            this.pbArt.TabStop = false;
            // 
            // btnDelUrl
            // 
            this.btnDelUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelUrl.Location = new System.Drawing.Point(231, 49);
            this.btnDelUrl.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelUrl.Name = "btnDelUrl";
            this.btnDelUrl.Size = new System.Drawing.Size(80, 24);
            this.btnDelUrl.TabIndex = 33;
            this.btnDelUrl.Text = "Del URL";
            this.btnDelUrl.UseVisualStyleBackColor = true;
            this.btnDelUrl.Click += new System.EventHandler(this.btnDelUrl_Click);
            // 
            // gbUrl
            // 
            this.gbUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbUrl.Controls.Add(this.btnCancelar);
            this.gbUrl.Controls.Add(this.btnGuardar);
            this.gbUrl.Controls.Add(this.lbImgArt);
            this.gbUrl.Controls.Add(this.dgvUrlImg);
            this.gbUrl.Controls.Add(this.pbArt);
            this.gbUrl.Controls.Add(this.btnAddUrl);
            this.gbUrl.Controls.Add(this.tbImgArt);
            this.gbUrl.Controls.Add(this.btnDelUrl);
            this.gbUrl.Location = new System.Drawing.Point(142, 323);
            this.gbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.gbUrl.Name = "gbUrl";
            this.gbUrl.Padding = new System.Windows.Forms.Padding(4);
            this.gbUrl.Size = new System.Drawing.Size(598, 344);
            this.gbUrl.TabIndex = 38;
            this.gbUrl.TabStop = false;
            this.gbUrl.Text = "Lista de Imagenes por Articulo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(302, 285);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 38);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCanelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(151, 285);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 38);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarBusquedaArt
            // 
            this.btnCancelarBusquedaArt.BackColor = System.Drawing.Color.Red;
            this.btnCancelarBusquedaArt.Location = new System.Drawing.Point(537, 49);
            this.btnCancelarBusquedaArt.Name = "btnCancelarBusquedaArt";
            this.btnCancelarBusquedaArt.Size = new System.Drawing.Size(124, 26);
            this.btnCancelarBusquedaArt.TabIndex = 39;
            this.btnCancelarBusquedaArt.Text = "Cancelar";
            this.btnCancelarBusquedaArt.UseVisualStyleBackColor = false;
            this.btnCancelarBusquedaArt.Click += new System.EventHandler(this.btnCancelarBusquedaArt_Click);
            // 
            // frmArtSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(830, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarBusquedaArt);
            this.Controls.Add(this.gbUrl);
            this.Controls.Add(this.btnDeletArt);
            this.Controls.Add(this.btnModArt);
            this.Controls.Add(this.gbSearchArt);
            this.Controls.Add(this.btnSeachArt);
            this.Controls.Add(this.tbCodArt);
            this.Controls.Add(this.lbCodArt);
            this.Controls.Add(this.lbTituloArt);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArtSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArtSearch";
            this.Load += new System.EventHandler(this.frmArtSearch_Load);
            this.gbSearchArt.ResumeLayout(false);
            this.gbSearchArt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.gbUrl.ResumeLayout(false);
            this.gbUrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloArt;
        private System.Windows.Forms.Button btnSeachArt;
        private System.Windows.Forms.ComboBox cboMarcaArt;
        private System.Windows.Forms.ComboBox cboCatArt;
        private System.Windows.Forms.TextBox tbPreArt;
        private System.Windows.Forms.TextBox tbImgArt;
        private System.Windows.Forms.TextBox tbDescArt;
        private System.Windows.Forms.TextBox tbNomArt;
        private System.Windows.Forms.TextBox tbCodArt;
        private System.Windows.Forms.Label lbPreArt;
        private System.Windows.Forms.Label lbImgArt;
        private System.Windows.Forms.Label lbCatArt;
        private System.Windows.Forms.Label lbMarcaArt;
        private System.Windows.Forms.Label lbDescArt;
        private System.Windows.Forms.Label lbNomArt;
        private System.Windows.Forms.Label lbCodArt;
        private System.Windows.Forms.GroupBox gbSearchArt;
        private System.Windows.Forms.Button btnModArt;
        private System.Windows.Forms.Button btnDeletArt;
        private System.Windows.Forms.DataGridView dgvUrlImg;
        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.Button btnDelUrl;
        private System.Windows.Forms.GroupBox gbUrl;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCancelarBusquedaArt;
    }
}