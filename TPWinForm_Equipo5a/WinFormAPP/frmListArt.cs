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
using ApplicationService;


namespace WinFormAPP
{
    public partial class frmListArt : Form
    {
        public frmListArt()
        {
            InitializeComponent();
        }

        private void frmListArt_Load(object sender, EventArgs e)
        {
            ArticuloAS artAS = new ArticuloAS();
            dgvArt.DataSource = artAS.listar();

        }

        private void dgvArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
