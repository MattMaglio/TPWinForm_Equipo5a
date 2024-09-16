using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAPP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenidos a la aplicacion!");
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtAdd wndAltaArt = new frmArtAdd();
            wndAltaArt.MdiParent = this;
            wndAltaArt.FormBorderStyle = FormBorderStyle.None;
            wndAltaArt.Dock = DockStyle.Fill;
            wndAltaArt.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtSearch wndSearchArt = new frmArtSearch();
            wndSearchArt.MdiParent = this;
            wndSearchArt.FormBorderStyle = FormBorderStyle.None;
            wndSearchArt.Dock = DockStyle.Fill;
            wndSearchArt.Show();
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListArt wndListArt = new frmListArt();
            wndListArt.MdiParent = this;
            wndListArt.FormBorderStyle = FormBorderStyle.None;
            wndListArt.Dock = DockStyle.Fill;
            wndListArt.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor comuniquese con el soporte tecnico, gracias!");
        }
    }
}
