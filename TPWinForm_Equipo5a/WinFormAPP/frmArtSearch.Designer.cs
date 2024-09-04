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
            this.lbTituloArtSearch = new System.Windows.Forms.Label();
            this.btnSeachArt = new System.Windows.Forms.Button();
            this.cbMarcaArt = new System.Windows.Forms.ComboBox();
            this.cbCatArt = new System.Windows.Forms.ComboBox();
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
            this.btnModArt = new System.Windows.Forms.Button();
            this.btnDeletArt = new System.Windows.Forms.Button();
            this.gbSearchArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloArtSearch
            // 
            this.lbTituloArtSearch.AutoSize = true;
            this.lbTituloArtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArtSearch.Location = new System.Drawing.Point(343, 26);
            this.lbTituloArtSearch.Name = "lbTituloArtSearch";
            this.lbTituloArtSearch.Size = new System.Drawing.Size(226, 25);
            this.lbTituloArtSearch.TabIndex = 17;
            this.lbTituloArtSearch.Text = "Busqueda de artículos";
            // 
            // btnSeachArt
            // 
            this.btnSeachArt.Location = new System.Drawing.Point(423, 75);
            this.btnSeachArt.Name = "btnSeachArt";
            this.btnSeachArt.Size = new System.Drawing.Size(121, 31);
            this.btnSeachArt.TabIndex = 32;
            this.btnSeachArt.Text = "Buscar artículo";
            this.btnSeachArt.UseVisualStyleBackColor = true;
            // 
            // cbMarcaArt
            // 
            this.cbMarcaArt.FormattingEnabled = true;
            this.cbMarcaArt.Location = new System.Drawing.Point(109, 121);
            this.cbMarcaArt.Name = "cbMarcaArt";
            this.cbMarcaArt.Size = new System.Drawing.Size(179, 21);
            this.cbMarcaArt.TabIndex = 31;
            // 
            // cbCatArt
            // 
            this.cbCatArt.FormattingEnabled = true;
            this.cbCatArt.Location = new System.Drawing.Point(109, 96);
            this.cbCatArt.Name = "cbCatArt";
            this.cbCatArt.Size = new System.Drawing.Size(179, 21);
            this.cbCatArt.TabIndex = 30;
            // 
            // tbPreArt
            // 
            this.tbPreArt.Location = new System.Drawing.Point(107, 197);
            this.tbPreArt.Name = "tbPreArt";
            this.tbPreArt.Size = new System.Drawing.Size(104, 20);
            this.tbPreArt.TabIndex = 29;
            // 
            // tbImgArt
            // 
            this.tbImgArt.Location = new System.Drawing.Point(108, 165);
            this.tbImgArt.Name = "tbImgArt";
            this.tbImgArt.Size = new System.Drawing.Size(313, 20);
            this.tbImgArt.TabIndex = 28;
            // 
            // tbDescArt
            // 
            this.tbDescArt.Location = new System.Drawing.Point(109, 61);
            this.tbDescArt.Name = "tbDescArt";
            this.tbDescArt.Size = new System.Drawing.Size(312, 20);
            this.tbDescArt.TabIndex = 27;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Location = new System.Drawing.Point(109, 28);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(179, 20);
            this.tbNomArt.TabIndex = 26;
            // 
            // tbCodArt
            // 
            this.tbCodArt.Location = new System.Drawing.Point(300, 84);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(102, 20);
            this.tbCodArt.TabIndex = 25;
            // 
            // lbPreArt
            // 
            this.lbPreArt.AutoSize = true;
            this.lbPreArt.Location = new System.Drawing.Point(62, 200);
            this.lbPreArt.Name = "lbPreArt";
            this.lbPreArt.Size = new System.Drawing.Size(40, 13);
            this.lbPreArt.TabIndex = 24;
            this.lbPreArt.Text = "Precio:";
            // 
            // lbImgArt
            // 
            this.lbImgArt.AutoSize = true;
            this.lbImgArt.Location = new System.Drawing.Point(17, 165);
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
            this.lbDescArt.Location = new System.Drawing.Point(36, 64);
            this.lbDescArt.Name = "lbDescArt";
            this.lbDescArt.Size = new System.Drawing.Size(66, 13);
            this.lbDescArt.TabIndex = 20;
            this.lbDescArt.Text = "Descripción:";
            // 
            // lbNomArt
            // 
            this.lbNomArt.AutoSize = true;
            this.lbNomArt.Location = new System.Drawing.Point(55, 31);
            this.lbNomArt.Name = "lbNomArt";
            this.lbNomArt.Size = new System.Drawing.Size(47, 13);
            this.lbNomArt.TabIndex = 19;
            this.lbNomArt.Text = "Nombre:";
            // 
            // lbCodArt
            // 
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(197, 84);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(96, 13);
            this.lbCodArt.TabIndex = 18;
            this.lbCodArt.Text = "Codigo de Articulo:";
            // 
            // gbSearchArt
            // 
            this.gbSearchArt.Controls.Add(this.lbNomArt);
            this.gbSearchArt.Controls.Add(this.lbDescArt);
            this.gbSearchArt.Controls.Add(this.cbMarcaArt);
            this.gbSearchArt.Controls.Add(this.lbMarcaArt);
            this.gbSearchArt.Controls.Add(this.cbCatArt);
            this.gbSearchArt.Controls.Add(this.lbCatArt);
            this.gbSearchArt.Controls.Add(this.tbPreArt);
            this.gbSearchArt.Controls.Add(this.lbImgArt);
            this.gbSearchArt.Controls.Add(this.tbImgArt);
            this.gbSearchArt.Controls.Add(this.lbPreArt);
            this.gbSearchArt.Controls.Add(this.tbDescArt);
            this.gbSearchArt.Controls.Add(this.tbNomArt);
            this.gbSearchArt.Location = new System.Drawing.Point(195, 112);
            this.gbSearchArt.Name = "gbSearchArt";
            this.gbSearchArt.Size = new System.Drawing.Size(549, 236);
            this.gbSearchArt.TabIndex = 33;
            this.gbSearchArt.TabStop = false;
            this.gbSearchArt.Text = "Articulo:";
            this.gbSearchArt.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnModArt
            // 
            this.btnModArt.Location = new System.Drawing.Point(317, 354);
            this.btnModArt.Name = "btnModArt";
            this.btnModArt.Size = new System.Drawing.Size(121, 31);
            this.btnModArt.TabIndex = 34;
            this.btnModArt.Text = "Modificar artículo";
            this.btnModArt.UseVisualStyleBackColor = true;
            // 
            // btnDeletArt
            // 
            this.btnDeletArt.Location = new System.Drawing.Point(459, 354);
            this.btnDeletArt.Name = "btnDeletArt";
            this.btnDeletArt.Size = new System.Drawing.Size(121, 31);
            this.btnDeletArt.TabIndex = 35;
            this.btnDeletArt.Text = "Eliminar artículo";
            this.btnDeletArt.UseVisualStyleBackColor = true;
            // 
            // frmArtSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeletArt);
            this.Controls.Add(this.btnModArt);
            this.Controls.Add(this.gbSearchArt);
            this.Controls.Add(this.btnSeachArt);
            this.Controls.Add(this.tbCodArt);
            this.Controls.Add(this.lbCodArt);
            this.Controls.Add(this.lbTituloArtSearch);
            this.Name = "frmArtSearch";
            this.Text = "frmArtSearch";
            this.gbSearchArt.ResumeLayout(false);
            this.gbSearchArt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloArtSearch;
        private System.Windows.Forms.Button btnSeachArt;
        private System.Windows.Forms.ComboBox cbMarcaArt;
        private System.Windows.Forms.ComboBox cbCatArt;
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
    }
}