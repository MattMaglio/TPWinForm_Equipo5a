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
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodArt
            // 
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(303, 138);
            this.lbCodArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(120, 16);
            this.lbCodArt.TabIndex = 2;
            this.lbCodArt.Text = "Codigo de Artículo:";
            // 
            // lbNomArt
            // 
            this.lbNomArt.AutoSize = true;
            this.lbNomArt.Location = new System.Drawing.Point(368, 174);
            this.lbNomArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomArt.Name = "lbNomArt";
            this.lbNomArt.Size = new System.Drawing.Size(59, 16);
            this.lbNomArt.TabIndex = 1;
            this.lbNomArt.Text = "Nombre:";
            // 
            // lbDescArt
            // 
            this.lbDescArt.AutoSize = true;
            this.lbDescArt.Location = new System.Drawing.Point(343, 214);
            this.lbDescArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescArt.Name = "lbDescArt";
            this.lbDescArt.Size = new System.Drawing.Size(82, 16);
            this.lbDescArt.TabIndex = 2;
            this.lbDescArt.Text = "Descripción:";
            // 
            // lbMarcaArt
            // 
            this.lbMarcaArt.AutoSize = true;
            this.lbMarcaArt.Location = new System.Drawing.Point(377, 294);
            this.lbMarcaArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarcaArt.Name = "lbMarcaArt";
            this.lbMarcaArt.Size = new System.Drawing.Size(48, 16);
            this.lbMarcaArt.TabIndex = 3;
            this.lbMarcaArt.Text = "Marca:";
            // 
            // lbCatArt
            // 
            this.lbCatArt.AutoSize = true;
            this.lbCatArt.Location = new System.Drawing.Point(357, 254);
            this.lbCatArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCatArt.Name = "lbCatArt";
            this.lbCatArt.Size = new System.Drawing.Size(69, 16);
            this.lbCatArt.TabIndex = 4;
            this.lbCatArt.Text = "Categoria:";
            // 
            // lbImgArt
            // 
            this.lbImgArt.AutoSize = true;
            this.lbImgArt.Location = new System.Drawing.Point(317, 338);
            this.lbImgArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImgArt.Name = "lbImgArt";
            this.lbImgArt.Size = new System.Drawing.Size(104, 16);
            this.lbImgArt.TabIndex = 5;
            this.lbImgArt.Text = "URL de Imagen:";
            // 
            // lbPreArt
            // 
            this.lbPreArt.AutoSize = true;
            this.lbPreArt.Location = new System.Drawing.Point(377, 382);
            this.lbPreArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPreArt.Name = "lbPreArt";
            this.lbPreArt.Size = new System.Drawing.Size(49, 16);
            this.lbPreArt.TabIndex = 6;
            this.lbPreArt.Text = "Precio:";
            // 
            // tbCodArt
            // 
            this.tbCodArt.Location = new System.Drawing.Point(440, 138);
            this.tbCodArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(237, 22);
            this.tbCodArt.TabIndex = 0;
            // 
            // tbNomArt
            // 
            this.tbNomArt.Location = new System.Drawing.Point(440, 170);
            this.tbNomArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNomArt.Name = "tbNomArt";
            this.tbNomArt.Size = new System.Drawing.Size(237, 22);
            this.tbNomArt.TabIndex = 1;
            // 
            // tbDescArt
            // 
            this.tbDescArt.Location = new System.Drawing.Point(440, 208);
            this.tbDescArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescArt.Name = "tbDescArt";
            this.tbDescArt.Size = new System.Drawing.Size(237, 22);
            this.tbDescArt.TabIndex = 2;
            // 
            // tbImgArt
            // 
            this.tbImgArt.Location = new System.Drawing.Point(439, 338);
            this.tbImgArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbImgArt.Name = "tbImgArt";
            this.tbImgArt.Size = new System.Drawing.Size(238, 22);
            this.tbImgArt.TabIndex = 5;
            // 
            // tbPreArt
            // 
            this.tbPreArt.Location = new System.Drawing.Point(437, 378);
            this.tbPreArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPreArt.Name = "tbPreArt";
            this.tbPreArt.Size = new System.Drawing.Size(137, 22);
            this.tbPreArt.TabIndex = 6;
            // 
            // cboCatArt
            // 
            this.cboCatArt.FormattingEnabled = true;
            this.cboCatArt.Location = new System.Drawing.Point(440, 254);
            this.cboCatArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCatArt.Name = "cboCatArt";
            this.cboCatArt.Size = new System.Drawing.Size(237, 24);
            this.cboCatArt.TabIndex = 3;
            // 
            // cboMarcaArt
            // 
            this.cboMarcaArt.FormattingEnabled = true;
            this.cboMarcaArt.Location = new System.Drawing.Point(440, 284);
            this.cboMarcaArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarcaArt.Name = "cboMarcaArt";
            this.cboMarcaArt.Size = new System.Drawing.Size(237, 24);
            this.cboMarcaArt.TabIndex = 4;
            // 
            // btnAddArt
            // 
            this.btnAddArt.Location = new System.Drawing.Point(437, 434);
            this.btnAddArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddArt.Name = "btnAddArt";
            this.btnAddArt.Size = new System.Drawing.Size(169, 66);
            this.btnAddArt.TabIndex = 7;
            this.btnAddArt.Text = "Agregar artículo";
            this.btnAddArt.UseVisualStyleBackColor = true;
            this.btnAddArt.Click += new System.EventHandler(this.btnAddArt_Click);
            // 
            // lbTituloArtAltas
            // 
            this.lbTituloArtAltas.AutoSize = true;
            this.lbTituloArtAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloArtAltas.Location = new System.Drawing.Point(457, 49);
            this.lbTituloArtAltas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloArtAltas.Name = "lbTituloArtAltas";
            this.lbTituloArtAltas.Size = new System.Drawing.Size(207, 31);
            this.lbTituloArtAltas.TabIndex = 3;
            this.lbTituloArtAltas.Text = "Alta de artículos";
            // 
            // lbExitoArtAdd
            // 
            this.lbExitoArtAdd.AutoSize = true;
            this.lbExitoArtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExitoArtAdd.Location = new System.Drawing.Point(400, 518);
            this.lbExitoArtAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExitoArtAdd.Name = "lbExitoArtAdd";
            this.lbExitoArtAdd.Size = new System.Drawing.Size(324, 18);
            this.lbExitoArtAdd.TabIndex = 17;
            this.lbExitoArtAdd.Text = "place holder: ¡Articulo agregado con exito!";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(677, 434);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(169, 66);
            this.btnCancelAdd.TabIndex = 8;
            this.btnCancelAdd.Text = "Cancelar";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // frmArtAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelAdd);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArtAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnCancelAdd;
    }
}