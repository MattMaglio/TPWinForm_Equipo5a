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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbSearchArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.gbUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloArt
            // 
            this.lbTituloArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTituloArt.AutoSize = true;
            this.lbTituloArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArt.Location = new System.Drawing.Point(193, 60);
            this.lbTituloArt.Name = "lbTituloArt";
            this.lbTituloArt.Size = new System.Drawing.Size(226, 25);
            this.lbTituloArt.TabIndex = 17;
            this.lbTituloArt.Text = "Busqueda de artículos";
            // 
            // btnSeachArt
            // 
            this.btnSeachArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeachArt.Location = new System.Drawing.Point(258, 108);
            this.btnSeachArt.Name = "btnSeachArt";
            this.btnSeachArt.Size = new System.Drawing.Size(121, 25);
            this.btnSeachArt.TabIndex = 32;
            this.btnSeachArt.Text = "Buscar artículo";
            this.btnSeachArt.UseVisualStyleBackColor = true;
            this.btnSeachArt.Click += new System.EventHandler(this.btnSeachArt_Click);
            // 
            // cboMarcaArt
            // 
            this.cboMarcaArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaArt.FormattingEnabled = true;
            this.cboMarcaArt.Location = new System.Drawing.Point(110, 130);
            this.cboMarcaArt.Name = "cboMarcaArt";
            this.cboMarcaArt.Size = new System.Drawing.Size(180, 21);
            this.cboMarcaArt.TabIndex = 31;
            // 
            // cboCatArt
            // 
            this.cboCatArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatArt.FormattingEnabled = true;
            this.cboCatArt.Location = new System.Drawing.Point(110, 95);
            this.cboCatArt.Name = "cboCatArt";
            this.cboCatArt.Size = new System.Drawing.Size(179, 21);
            this.cboCatArt.TabIndex = 30;
            // 
            // tbPreArt
            // 
            this.tbPreArt.Location = new System.Drawing.Point(110, 157);
            this.tbPreArt.Name = "tbPreArt";
            this.tbPreArt.Size = new System.Drawing.Size(105, 20);
            this.tbPreArt.TabIndex = 29;
            // 
            // tbImgArt
            // 
            this.tbImgArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbImgArt.Location = new System.Drawing.Point(118, 19);
            this.tbImgArt.Name = "tbImgArt";
            this.tbImgArt.Size = new System.Drawing.Size(310, 20);
            this.tbImgArt.TabIndex = 28;
            // 
            // tbDescArt
            // 
            this.tbDescArt.Location = new System.Drawing.Point(110, 60);
            this.tbDescArt.Name = "tbDescArt";
            this.tbDescArt.Size = new System.Drawing.Size(310, 20);
            this.tbDescArt.TabIndex = 27;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Location = new System.Drawing.Point(110, 30);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(179, 20);
            this.tbNomArt.TabIndex = 26;
            // 
            // tbCodArt
            // 
            this.tbCodArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodArt.Location = new System.Drawing.Point(152, 111);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(100, 20);
            this.tbCodArt.TabIndex = 25;
            // 
            // lbPreArt
            // 
            this.lbPreArt.AutoSize = true;
            this.lbPreArt.Location = new System.Drawing.Point(62, 160);
            this.lbPreArt.Name = "lbPreArt";
            this.lbPreArt.Size = new System.Drawing.Size(40, 13);
            this.lbPreArt.TabIndex = 24;
            this.lbPreArt.Text = "Precio:";
            // 
            // lbImgArt
            // 
            this.lbImgArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbImgArt.AutoSize = true;
            this.lbImgArt.Location = new System.Drawing.Point(27, 22);
            this.lbImgArt.Name = "lbImgArt";
            this.lbImgArt.Size = new System.Drawing.Size(85, 13);
            this.lbImgArt.TabIndex = 23;
            this.lbImgArt.Text = "URL de Imagen:";
            // 
            // lbCatArt
            // 
            this.lbCatArt.AutoSize = true;
            this.lbCatArt.Location = new System.Drawing.Point(47, 96);
            this.lbCatArt.Name = "lbCatArt";
            this.lbCatArt.Size = new System.Drawing.Size(55, 13);
            this.lbCatArt.TabIndex = 22;
            this.lbCatArt.Text = "Categoria:";
            // 
            // lbMarcaArt
            // 
            this.lbMarcaArt.AutoSize = true;
            this.lbMarcaArt.Location = new System.Drawing.Point(62, 129);
            this.lbMarcaArt.Name = "lbMarcaArt";
            this.lbMarcaArt.Size = new System.Drawing.Size(40, 13);
            this.lbMarcaArt.TabIndex = 21;
            this.lbMarcaArt.Text = "Marca:";
            // 
            // lbDescArt
            // 
            this.lbDescArt.AutoSize = true;
            this.lbDescArt.Location = new System.Drawing.Point(36, 61);
            this.lbDescArt.Name = "lbDescArt";
            this.lbDescArt.Size = new System.Drawing.Size(66, 13);
            this.lbDescArt.TabIndex = 20;
            this.lbDescArt.Text = "Descripción:";
            // 
            // lbNomArt
            // 
            this.lbNomArt.AutoSize = true;
            this.lbNomArt.Location = new System.Drawing.Point(55, 30);
            this.lbNomArt.Name = "lbNomArt";
            this.lbNomArt.Size = new System.Drawing.Size(47, 13);
            this.lbNomArt.TabIndex = 19;
            this.lbNomArt.Text = "Nombre:";
            // 
            // lbCodArt
            // 
            this.lbCodArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(50, 114);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(96, 13);
            this.lbCodArt.TabIndex = 18;
            this.lbCodArt.Text = "Codigo de Articulo:";
            // 
            // gbSearchArt
            // 
            this.gbSearchArt.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.gbSearchArt.Location = new System.Drawing.Point(50, 174);
            this.gbSearchArt.Name = "gbSearchArt";
            this.gbSearchArt.Size = new System.Drawing.Size(500, 191);
            this.gbSearchArt.TabIndex = 33;
            this.gbSearchArt.TabStop = false;
            this.gbSearchArt.Text = "Articulo:";
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUrl.Location = new System.Drawing.Point(118, 45);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(68, 23);
            this.btnAddUrl.TabIndex = 32;
            this.btnAddUrl.Text = "Add URL";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // btnModArt
            // 
            this.btnModArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModArt.Location = new System.Drawing.Point(56, 137);
            this.btnModArt.Name = "btnModArt";
            this.btnModArt.Size = new System.Drawing.Size(121, 31);
            this.btnModArt.TabIndex = 34;
            this.btnModArt.Text = "Modificar artículo";
            this.btnModArt.UseVisualStyleBackColor = true;
            this.btnModArt.Click += new System.EventHandler(this.btnModArt_Click);
            // 
            // btnDeletArt
            // 
            this.btnDeletArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletArt.Location = new System.Drawing.Point(183, 137);
            this.btnDeletArt.Name = "btnDeletArt";
            this.btnDeletArt.Size = new System.Drawing.Size(121, 31);
            this.btnDeletArt.TabIndex = 35;
            this.btnDeletArt.Text = "Eliminar artículo";
            this.btnDeletArt.UseVisualStyleBackColor = true;
            this.btnDeletArt.Click += new System.EventHandler(this.btnDeletArt_Click);
            // 
            // dgvUrlImg
            // 
            this.dgvUrlImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUrlImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlImg.Location = new System.Drawing.Point(6, 74);
            this.dgvUrlImg.Name = "dgvUrlImg";
            this.dgvUrlImg.Size = new System.Drawing.Size(240, 240);
            this.dgvUrlImg.TabIndex = 36;
            this.dgvUrlImg.SelectionChanged += new System.EventHandler(this.dgvUrlImg_SelectionChanged);
            // 
            // pbArt
            // 
            this.pbArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbArt.Location = new System.Drawing.Point(254, 74);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(240, 240);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 37;
            this.pbArt.TabStop = false;
            // 
            // btnDelUrl
            // 
            this.btnDelUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelUrl.Location = new System.Drawing.Point(192, 45);
            this.btnDelUrl.Name = "btnDelUrl";
            this.btnDelUrl.Size = new System.Drawing.Size(68, 23);
            this.btnDelUrl.TabIndex = 33;
            this.btnDelUrl.Text = "Del URL";
            this.btnDelUrl.UseVisualStyleBackColor = true;
            this.btnDelUrl.Click += new System.EventHandler(this.btnDelUrl_Click);
            // 
            // gbUrl
            // 
            this.gbUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbUrl.Controls.Add(this.lbImgArt);
            this.gbUrl.Controls.Add(this.dgvUrlImg);
            this.gbUrl.Controls.Add(this.pbArt);
            this.gbUrl.Controls.Add(this.btnAddUrl);
            this.gbUrl.Controls.Add(this.tbImgArt);
            this.gbUrl.Controls.Add(this.btnDelUrl);
            this.gbUrl.Location = new System.Drawing.Point(50, 371);
            this.gbUrl.Name = "gbUrl";
            this.gbUrl.Size = new System.Drawing.Size(500, 320);
            this.gbUrl.TabIndex = 38;
            this.gbUrl.TabStop = false;
            this.gbUrl.Text = "Lista de Imagenes por Articulo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(56, 697);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 36);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(198, 697);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 36);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCanelar_Click);
            // 
            // frmArtSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbUrl);
            this.Controls.Add(this.btnDeletArt);
            this.Controls.Add(this.btnModArt);
            this.Controls.Add(this.gbSearchArt);
            this.Controls.Add(this.btnSeachArt);
            this.Controls.Add(this.tbCodArt);
            this.Controls.Add(this.lbCodArt);
            this.Controls.Add(this.lbTituloArt);
            this.Name = "frmArtSearch";
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
    }
}