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
            this.lbImgArt = new System.Windows.Forms.Label();
            this.lbPreArt = new System.Windows.Forms.Label();
            this.tbCodArt = new System.Windows.Forms.TextBox();
            this.tbNomArt = new System.Windows.Forms.TextBox();
            this.tbDescArt = new System.Windows.Forms.TextBox();
            this.tbImgArt = new System.Windows.Forms.TextBox();
            this.tbPreArt = new System.Windows.Forms.TextBox();
            this.cboCatArt = new System.Windows.Forms.ComboBox();
            this.cboMarcaArt = new System.Windows.Forms.ComboBox();
            this.btnAddArt = new System.Windows.Forms.Button();
            this.lbTituloArtAltas = new System.Windows.Forms.Label();
            this.lbExitoArtAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCodArt
            // 
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(227, 112);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(96, 13);
            this.lbCodArt.TabIndex = 0;
            this.lbCodArt.Text = "Codigo de Articulo:";
            // 
            // lbNomArt
            // 
            this.lbNomArt.AutoSize = true;
            this.lbNomArt.Location = new System.Drawing.Point(276, 141);
            this.lbNomArt.Name = "lbNomArt";
            this.lbNomArt.Size = new System.Drawing.Size(47, 13);
            this.lbNomArt.TabIndex = 1;
            this.lbNomArt.Text = "Nombre:";
            // 
            // lbDescArt
            // 
            this.lbDescArt.AutoSize = true;
            this.lbDescArt.Location = new System.Drawing.Point(257, 174);
            this.lbDescArt.Name = "lbDescArt";
            this.lbDescArt.Size = new System.Drawing.Size(66, 13);
            this.lbDescArt.TabIndex = 2;
            this.lbDescArt.Text = "Descripción:";
            // 
            // lbMarcaArt
            // 
            this.lbMarcaArt.AutoSize = true;
            this.lbMarcaArt.Location = new System.Drawing.Point(283, 239);
            this.lbMarcaArt.Name = "lbMarcaArt";
            this.lbMarcaArt.Size = new System.Drawing.Size(40, 13);
            this.lbMarcaArt.TabIndex = 3;
            this.lbMarcaArt.Text = "Marca:";
            // 
            // lbCatArt
            // 
            this.lbCatArt.AutoSize = true;
            this.lbCatArt.Location = new System.Drawing.Point(268, 206);
            this.lbCatArt.Name = "lbCatArt";
            this.lbCatArt.Size = new System.Drawing.Size(55, 13);
            this.lbCatArt.TabIndex = 4;
            this.lbCatArt.Text = "Categoria:";
            // 
            // lbImgArt
            // 
            this.lbImgArt.AutoSize = true;
            this.lbImgArt.Location = new System.Drawing.Point(238, 275);
            this.lbImgArt.Name = "lbImgArt";
            this.lbImgArt.Size = new System.Drawing.Size(85, 13);
            this.lbImgArt.TabIndex = 5;
            this.lbImgArt.Text = "URL de Imagen:";
            // 
            // lbPreArt
            // 
            this.lbPreArt.AutoSize = true;
            this.lbPreArt.Location = new System.Drawing.Point(283, 310);
            this.lbPreArt.Name = "lbPreArt";
            this.lbPreArt.Size = new System.Drawing.Size(40, 13);
            this.lbPreArt.TabIndex = 6;
            this.lbPreArt.Text = "Precio:";
            // 
            // tbCodArt
            // 
            this.tbCodArt.Location = new System.Drawing.Point(330, 112);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(102, 20);
            this.tbCodArt.TabIndex = 7;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Location = new System.Drawing.Point(330, 138);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(179, 20);
            this.tbNomArt.TabIndex = 8;
            // 
            // tbDescArt
            // 
            this.tbDescArt.Location = new System.Drawing.Point(330, 171);
            this.tbDescArt.Name = "tbDescArt";
            this.tbDescArt.Size = new System.Drawing.Size(312, 20);
            this.tbDescArt.TabIndex = 9;
            // 
            // tbImgArt
            // 
            this.tbImgArt.Location = new System.Drawing.Point(329, 275);
            this.tbImgArt.Name = "tbImgArt";
            this.tbImgArt.Size = new System.Drawing.Size(313, 20);
            this.tbImgArt.TabIndex = 11;
            // 
            // tbPreArt
            // 
            this.tbPreArt.Location = new System.Drawing.Point(328, 307);
            this.tbPreArt.Name = "tbPreArt";
            this.tbPreArt.Size = new System.Drawing.Size(104, 20);
            this.tbPreArt.TabIndex = 12;
            // 
            // cboCatArt
            // 
            this.cboCatArt.FormattingEnabled = true;
            this.cboCatArt.Location = new System.Drawing.Point(330, 206);
            this.cboCatArt.Name = "cboCatArt";
            this.cboCatArt.Size = new System.Drawing.Size(179, 21);
            this.cboCatArt.TabIndex = 13;
            // 
            // cboMarcaArt
            // 
            this.cboMarcaArt.FormattingEnabled = true;
            this.cboMarcaArt.Location = new System.Drawing.Point(330, 231);
            this.cboMarcaArt.Name = "cboMarcaArt";
            this.cboMarcaArt.Size = new System.Drawing.Size(179, 21);
            this.cboMarcaArt.TabIndex = 14;
            // 
            // btnAddArt
            // 
            this.btnAddArt.Location = new System.Drawing.Point(366, 354);
            this.btnAddArt.Name = "btnAddArt";
            this.btnAddArt.Size = new System.Drawing.Size(127, 54);
            this.btnAddArt.TabIndex = 15;
            this.btnAddArt.Text = "Agregar artículo";
            this.btnAddArt.UseVisualStyleBackColor = true;
            this.btnAddArt.Click += new System.EventHandler(this.btnAddArt_Click);
            // 
            // lbTituloArtAltas
            // 
            this.lbTituloArtAltas.AutoSize = true;
            this.lbTituloArtAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArtAltas.Location = new System.Drawing.Point(343, 40);
            this.lbTituloArtAltas.Name = "lbTituloArtAltas";
            this.lbTituloArtAltas.Size = new System.Drawing.Size(166, 25);
            this.lbTituloArtAltas.TabIndex = 16;
            this.lbTituloArtAltas.Text = "Alta de artículos";
            // 
            // lbExitoArtAdd
            // 
            this.lbExitoArtAdd.AutoSize = true;
            this.lbExitoArtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExitoArtAdd.Location = new System.Drawing.Point(300, 421);
            this.lbExitoArtAdd.Name = "lbExitoArtAdd";
            this.lbExitoArtAdd.Size = new System.Drawing.Size(278, 15);
            this.lbExitoArtAdd.TabIndex = 17;
            this.lbExitoArtAdd.Text = "place holder: ¡Articulo agregado con exito!";
            // 
            // frmArtAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.lbExitoArtAdd);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Articulos - Alta";
            this.Load += new System.EventHandler(this.frmArtAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodArt;
        private System.Windows.Forms.Label lbNomArt;
        private System.Windows.Forms.Label lbDescArt;
        private System.Windows.Forms.Label lbMarcaArt;
        private System.Windows.Forms.Label lbCatArt;
        private System.Windows.Forms.Label lbImgArt;
        private System.Windows.Forms.Label lbPreArt;
        private System.Windows.Forms.TextBox tbCodArt;
        private System.Windows.Forms.TextBox tbNomArt;
        private System.Windows.Forms.TextBox tbDescArt;
        private System.Windows.Forms.TextBox tbImgArt;
        private System.Windows.Forms.TextBox tbPreArt;
        private System.Windows.Forms.ComboBox cboCatArt;
        private System.Windows.Forms.ComboBox cboMarcaArt;
        private System.Windows.Forms.Button btnAddArt;
        private System.Windows.Forms.Label lbTituloArtAltas;
        private System.Windows.Forms.Label lbExitoArtAdd;
    }
}