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
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArt
            // 
            this.dgvArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArt.Location = new System.Drawing.Point(12, 12);
            this.dgvArt.Name = "dgvArt";
            this.dgvArt.Size = new System.Drawing.Size(522, 384);
            this.dgvArt.TabIndex = 0;
            this.dgvArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArt_CellContentClick);
            // 
            // frmListArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.ControlBox = false;
            this.Controls.Add(this.dgvArt);
            this.Name = "frmListArt";
            this.Text = "frmListArt";
            this.Load += new System.EventHandler(this.frmListArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArt;
    }
}