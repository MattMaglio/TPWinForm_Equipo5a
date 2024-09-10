using ApplicationService;
using Model;
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
    public partial class frmArtAdd : Form
    {
        public frmArtAdd()
        {
            InitializeComponent();
        }

        private void frmArtAdd_Load(object sender, EventArgs e)
        {
            MarcaAS marca = new MarcaAS();
            CategoriaAS categoria = new CategoriaAS();

            cboMarcaArt.DataSource = marca.listar();
            cboCatArt.DataSource = categoria.listar();
        }

        private void btnAddArt_Click(object sender, EventArgs e)
        {

        }

    }
}
