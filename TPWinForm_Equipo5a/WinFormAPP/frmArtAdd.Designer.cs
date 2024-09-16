namespace WinFormAPP
{
    partial class frmArtAdd
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
            this.lbCodArt = new System.Windows.Forms.Label();
            this.lbNomArt = new System.Windows.Forms.Label();
            this.lbDescArt = new System.Windows.Forms.Label();
            this.lbMarcaArt = new System.Windows.Forms.Label();
            this.lbCatArt = new System.Windows.Forms.Label();
            this.lbPreArt = new System.Windows.Forms.Label();
            this.tbCodArt = new System.Windows.Forms.TextBox();
            this.tbNomArt = new System.Windows.Forms.TextBox();
            this.tbDescArt = new System.Windows.Forms.TextBox();
            this.tbPreArt = new System.Windows.Forms.TextBox();
            this.cboCatArt = new System.Windows.Forms.ComboBox();
            this.cboMarcaArt = new System.Windows.Forms.ComboBox();
            this.btnAddArt = new System.Windows.Forms.Button();
            this.lbTituloArtAltas = new System.Windows.Forms.Label();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.pbArt = new System.Windows.Forms.PictureBox();
            this.lbImgArt = new System.Windows.Forms.Label();
            this.tbImgArt = new System.Windows.Forms.TextBox();
            this.dgvUrlImg = new System.Windows.Forms.DataGridView();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.btnDelUrl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodArt
            // 
            this.lbCodArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(105, 105);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(98, 13);
            this.lbCodArt.TabIndex = 2;
            this.lbCodArt.Text = "Codigo de Artículo:";
            // 
            // lbNomArt
            // 
            this.lbNomArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomArt.AutoSize = true;
            this.lbNomArt.Location = new System.Drawing.Point(156, 138);
            this.lbNomArt.Name = "lbNomArt";
            this.lbNomArt.Size = new System.Drawing.Size(47, 13);
            this.lbNomArt.TabIndex = 1;
            this.lbNomArt.Text = "Nombre:";
            // 
            // lbDescArt
            // 
            this.lbDescArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDescArt.AutoSize = true;
            this.lbDescArt.Location = new System.Drawing.Point(137, 169);
            this.lbDescArt.Name = "lbDescArt";
            this.lbDescArt.Size = new System.Drawing.Size(66, 13);
            this.lbDescArt.TabIndex = 2;
            this.lbDescArt.Text = "Descripción:";
            // 
            // lbMarcaArt
            // 
            this.lbMarcaArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMarcaArt.AutoSize = true;
            this.lbMarcaArt.Location = new System.Drawing.Point(163, 231);
            this.lbMarcaArt.Name = "lbMarcaArt";
            this.lbMarcaArt.Size = new System.Drawing.Size(40, 13);
            this.lbMarcaArt.TabIndex = 3;
            this.lbMarcaArt.Text = "Marca:";
            // 
            // lbCatArt
            // 
            this.lbCatArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCatArt.AutoSize = true;
            this.lbCatArt.Location = new System.Drawing.Point(148, 200);
            this.lbCatArt.Name = "lbCatArt";
            this.lbCatArt.Size = new System.Drawing.Size(55, 13);
            this.lbCatArt.TabIndex = 4;
            this.lbCatArt.Text = "Categoria:";
            // 
            // lbPreArt
            // 
            this.lbPreArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPreArt.AutoSize = true;
            this.lbPreArt.Location = new System.Drawing.Point(163, 261);
            this.lbPreArt.Name = "lbPreArt";
            this.lbPreArt.Size = new System.Drawing.Size(40, 13);
            this.lbPreArt.TabIndex = 6;
            this.lbPreArt.Text = "Precio:";
            // 
            // tbCodArt
            // 
            this.tbCodArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCodArt.Location = new System.Drawing.Point(212, 105);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(179, 20);
            this.tbCodArt.TabIndex = 0;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNomArt.Location = new System.Drawing.Point(212, 131);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(179, 20);
            this.tbNomArt.TabIndex = 1;
            // 
            // tbDescArt
            // 
            this.tbDescArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDescArt.Location = new System.Drawing.Point(212, 166);
            this.tbDescArt.Name = "tbDescArt";
            this.tbDescArt.Size = new System.Drawing.Size(179, 20);
            this.tbDescArt.TabIndex = 2;
            // 
            // tbPreArt
            // 
            this.tbPreArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPreArt.Location = new System.Drawing.Point(212, 258);
            this.tbPreArt.Name = "tbPreArt";
            this.tbPreArt.Size = new System.Drawing.Size(179, 20);
            this.tbPreArt.TabIndex = 6;
            // 
            // cboCatArt
            // 
            this.cboCatArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCatArt.FormattingEnabled = true;
            this.cboCatArt.Location = new System.Drawing.Point(212, 196);
            this.cboCatArt.Name = "cboCatArt";
            this.cboCatArt.Size = new System.Drawing.Size(179, 21);
            this.cboCatArt.TabIndex = 3;
            // 
            // cboMarcaArt
            // 
            this.cboMarcaArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboMarcaArt.FormattingEnabled = true;
            this.cboMarcaArt.Location = new System.Drawing.Point(212, 227);
            this.cboMarcaArt.Name = "cboMarcaArt";
            this.cboMarcaArt.Size = new System.Drawing.Size(179, 21);
            this.cboMarcaArt.TabIndex = 4;
            // 
            // btnAddArt
            // 
            this.btnAddArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddArt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArt.Location = new System.Drawing.Point(612, 468);
            this.btnAddArt.Name = "btnAddArt";
            this.btnAddArt.Size = new System.Drawing.Size(110, 46);
            this.btnAddArt.TabIndex = 7;
            this.btnAddArt.Text = "Agregar artículo";
            this.btnAddArt.UseVisualStyleBackColor = false;
            this.btnAddArt.Click += new System.EventHandler(this.btnAddArt_Click);
            // 
            // lbTituloArtAltas
            // 
            this.lbTituloArtAltas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTituloArtAltas.AutoSize = true;
            this.lbTituloArtAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArtAltas.Location = new System.Drawing.Point(414, 9);
            this.lbTituloArtAltas.Name = "lbTituloArtAltas";
            this.lbTituloArtAltas.Size = new System.Drawing.Size(166, 25);
            this.lbTituloArtAltas.TabIndex = 3;
            this.lbTituloArtAltas.Text = "Alta de artículos";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelAdd.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(824, 468);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(111, 46);
            this.btnCancelAdd.TabIndex = 8;
            this.btnCancelAdd.Text = "Cancelar";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // pbArt
            // 
            this.pbArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbArt.Location = new System.Drawing.Point(583, 105);
            this.pbArt.Margin = new System.Windows.Forms.Padding(2);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(391, 342);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 18;
            this.pbArt.TabStop = false;
            // 
            // lbImgArt
            // 
            this.lbImgArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbImgArt.AutoSize = true;
            this.lbImgArt.Location = new System.Drawing.Point(118, 300);
            this.lbImgArt.Name = "lbImgArt";
            this.lbImgArt.Size = new System.Drawing.Size(85, 13);
            this.lbImgArt.TabIndex = 5;
            this.lbImgArt.Text = "URL de Imagen:";
            // 
            // tbImgArt
            // 
            this.tbImgArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbImgArt.Location = new System.Drawing.Point(212, 293);
            this.tbImgArt.Name = "tbImgArt";
            this.tbImgArt.Size = new System.Drawing.Size(179, 20);
            this.tbImgArt.TabIndex = 5;
            this.tbImgArt.Leave += new System.EventHandler(this.tbImgArt_Leave);
            // 
            // dgvUrlImg
            // 
            this.dgvUrlImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUrlImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlImg.Location = new System.Drawing.Point(71, 412);
            this.dgvUrlImg.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUrlImg.Name = "dgvUrlImg";
            this.dgvUrlImg.Size = new System.Drawing.Size(320, 155);
            this.dgvUrlImg.TabIndex = 39;
            this.dgvUrlImg.SelectionChanged += new System.EventHandler(this.dgvUrlImg_SelectionChanged);
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddUrl.Location = new System.Drawing.Point(209, 325);
            this.btnAddUrl.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(80, 24);
            this.btnAddUrl.TabIndex = 37;
            this.btnAddUrl.Text = "Add URL";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // btnDelUrl
            // 
            this.btnDelUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelUrl.Location = new System.Drawing.Point(297, 325);
            this.btnDelUrl.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelUrl.Name = "btnDelUrl";
            this.btnDelUrl.Size = new System.Drawing.Size(80, 24);
            this.btnDelUrl.TabIndex = 38;
            this.btnDelUrl.Text = "Del URL";
            this.btnDelUrl.UseVisualStyleBackColor = true;
            this.btnDelUrl.Click += new System.EventHandler(this.btnDelUrl_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lista de URL de imagenes:";
            // 
            // frmArtAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 757);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUrlImg);
            this.Controls.Add(this.btnAddUrl);
            this.Controls.Add(this.btnDelUrl);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.lbTituloArtAltas);
            this.Controls.Add(this.btnAddArt);
            this.Controls.Add(this.cboMarcaArt);
            this.Controls.Add(this.cboCatArt);
            this.Controls.Add(this.tbPreArt);
            this.Controls.Add(this.tbImgArt);
            this.Controls.Add(this.tbDescArt);
            this.Controls.Add(this.tbNomArt);
            this.Controls.Add(this.tbCodArt);
            this.Controls.Add(this.lbPreArt);
            this.Controls.Add(this.lbImgArt);
            this.Controls.Add(this.lbCatArt);
            this.Controls.Add(this.lbMarcaArt);
            this.Controls.Add(this.lbDescArt);
            this.Controls.Add(this.lbNomArt);
            this.Controls.Add(this.lbCodArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmArtAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Articulos - Alta";
            this.Load += new System.EventHandler(this.frmArtAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodArt;
        private System.Windows.Forms.Label lbNomArt;
        private System.Windows.Forms.Label lbDescArt;
        private System.Windows.Forms.Label lbMarcaArt;
        private System.Windows.Forms.Label lbCatArt;
        private System.Windows.Forms.Label lbPreArt;
        private System.Windows.Forms.TextBox tbCodArt;
        private System.Windows.Forms.TextBox tbNomArt;
        private System.Windows.Forms.TextBox tbDescArt;
        private System.Windows.Forms.TextBox tbPreArt;
        private System.Windows.Forms.ComboBox cboCatArt;
        private System.Windows.Forms.ComboBox cboMarcaArt;
        private System.Windows.Forms.Button btnAddArt;
        private System.Windows.Forms.Label lbTituloArtAltas;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.Label lbImgArt;
        private System.Windows.Forms.TextBox tbImgArt;
        private System.Windows.Forms.DataGridView dgvUrlImg;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.Button btnDelUrl;
        private System.Windows.Forms.Label label1;
    }
}