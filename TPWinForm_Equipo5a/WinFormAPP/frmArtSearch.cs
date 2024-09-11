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
using System.Security.Policy;
using System.Text.RegularExpressions;


namespace WinFormAPP
{
    public partial class frmArtSearch : Form
    {   
        private List<Imagen> listUrl;
        private Articulo art = null;
        private Imagen img = null;
        public frmArtSearch()
        {
            InitializeComponent();
        }

        public void cargarArticuloBuscado()
        {
            ImagenAS img = new ImagenAS();

            tbNomArt.Text = art.Nombre.ToString();
            tbDescArt.Text = art.Descripcion.ToString();
            cboCatArt.SelectedValue = art.Categoria.Id;
            cboMarcaArt.SelectedValue = art.Marca.Id;
            tbPreArt.Text = art.Precio.ToString();

            listUrl = img.listarFiltrado(tbCodArt.Text);
            dgvUrlImg.DataSource = listUrl;
            dgvUrlImg.Columns["Id"].Visible = false;
            dgvUrlImg.Columns["IdArticulo"].Visible = false;
            cargarImagen(listUrl[0].ImagenUrl);
        }

        public void cargarFormularioDisable()
        {
            CategoriaAS cat = new CategoriaAS();
            MarcaAS marca = new MarcaAS();

            cboCatArt.DataSource = cat.listar();
            cboCatArt.ValueMember = "Id";
            cboCatArt.DisplayMember = "Descripcion";

            cboMarcaArt.DataSource = marca.listar();
            cboMarcaArt.ValueMember = "Id";
            cboMarcaArt.DisplayMember = "Descripcion";

            tbNomArt.ReadOnly = true;
            tbDescArt.ReadOnly = true;
            cboCatArt.Enabled = false;
            cboMarcaArt.Enabled = false;
            tbImgArt.ReadOnly = true;
            tbPreArt.ReadOnly = true;
            btnModArt.Enabled = false;
            btnDeletArt.Enabled = false;
            btnAddUrl.Enabled = false;
            btnDelUrl.Enabled = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
        }

        public void cargarFormularioEnable()
        {
            CategoriaAS cat = new CategoriaAS();
            MarcaAS marca = new MarcaAS();

            cboCatArt.DataSource = cat.listar();
            cboCatArt.ValueMember = "Id";
            cboCatArt.DisplayMember = "Descripcion";

            cboMarcaArt.DataSource = marca.listar();
            cboMarcaArt.ValueMember = "Id";
            cboMarcaArt.DisplayMember = "Descripcion";

            tbNomArt.ReadOnly = false;
            tbDescArt.ReadOnly = false;
            cboCatArt.Enabled = true;
            cboMarcaArt.Enabled = true;
            tbImgArt.ReadOnly = false;
            tbPreArt.ReadOnly = false;
            btnModArt.Enabled = true;
            btnDeletArt.Enabled = true;
            btnAddUrl.Enabled = true;
            btnDelUrl.Enabled = true;
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }

        private void cargarImagen(string img)
        {
            try
            {
                pbArt.Load(img);
            }
            catch (Exception ex)
            {
                pbArt.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT3gpZSb_Y8zMJevdd9E2ZxI4doS3D4BMsus5ltKAyKydLH-zxnGIQQ3Dx7sNWcnZvFea4&usqp=CAU");
            }
        }
        private void btnSeachArt_Click(object sender, EventArgs e)
        {
            ArticuloAS artAS = new ArticuloAS();

            art = artAS.buscarArt(tbCodArt.Text);

            if(art.Codigo != null)
            {
                cargarFormularioDisable();
                cargarArticuloBuscado();
                

                btnModArt.Enabled = true;
                btnDeletArt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Articulo invalido");
            }
        }

        private void dgvUrlImg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUrlImg.CurrentRow != null)
            {
                dgvUrlImg.CurrentRow.Cells[0].Selected = true;
                
                img = (Imagen)dgvUrlImg.CurrentRow.DataBoundItem;
                cargarImagen(img.ImagenUrl);
                tbImgArt.Text = img.ImagenUrl;
            }
        }

        private void btnModArt_Click(object sender, EventArgs e)
        {
            ArticuloAS artAS = new ArticuloAS();
            CategoriaAS cat = new CategoriaAS();
            MarcaAS marca = new MarcaAS();
            ImagenAS img = new ImagenAS();

            art = artAS.buscarArt(tbCodArt.Text);

            lbTituloArt.Text = "Modificación de artículos";
            
            cargarFormularioEnable();
            cargarArticuloBuscado();
            btnDeletArt.Enabled = false;            
        }

        private void btnDeletArt_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloAS artAS = new ArticuloAS();
                artAS.borrarArticulo(art);
                MessageBox.Show("Articulo eliminado");
                cargarFormularioDisable();
                cargarArticuloBuscado();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void frmArtSearch_Load(object sender, EventArgs e)
        {
            cargarFormularioDisable();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloAS artAS = new ArticuloAS();

            art.Nombre = tbNomArt.Text;
            art.Descripcion = tbDescArt.Text;
            art.Categoria = (Categoria)cboCatArt.SelectedItem;
            art.Marca = (Marca)cboMarcaArt.SelectedItem;
            art.Precio = Convert.ToDecimal(tbPreArt.Text);
            artAS.actualizarArticulo(art);
            cargarFormularioDisable();
            cargarArticuloBuscado();
            btnDeletArt.Enabled = true;
            btnModArt.Enabled = true;

        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenAS imgAS = new ImagenAS();
                img.IdArticulo = art.Id;
                img.ImagenUrl = tbImgArt.Text;
                imgAS.agregarImagen(img);
                MessageBox.Show("Url agregada");

                cargarFormularioEnable();
                cargarArticuloBuscado();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDelUrl_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenAS imgAS = new ImagenAS();
                imgAS.eliminarImagen(img);
                MessageBox.Show("Url eliminada");
                
                cargarFormularioEnable();
                cargarArticuloBuscado();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
