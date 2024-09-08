using DataPersistence;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationService;


namespace WinFormAPP
{
    public partial class frmArtSearch : Form
    {
        public frmArtSearch()
        {
            InitializeComponent();
        }

        private void btnSeachArt_Click(object sender, EventArgs e)
        {
            ArticuloAS artAS = new ArticuloAS();
            Articulo art = new Articulo();

            //MarcaAS marca = new MarcaAS();


            //cbMarcaArt.DataSource = marca.listar();
            //cbMarcaArt.SelectedValue = art.IdMarca;

            art = artAS.buscarArt(tbCodArt.Text);

            tbNomArt.Text = art.Nombre.ToString();
            tbDescArt.Text = art.Descripcion.ToString();
            //tbImgArt.Text ;
            //cbCatArt.SelectedValue = art.IdCategoria;
            tbPreArt.Text = art.Precio.ToString();

        }

    }
}
