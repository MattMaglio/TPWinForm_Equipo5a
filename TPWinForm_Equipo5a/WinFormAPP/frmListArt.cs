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
using DataPersistence;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;



namespace WinFormAPP
{
    public partial class frmListArt : Form
    {
        private List<Articulo> listArt;
        private List<Imagen> imageList;
        Imagen img = null;
        public frmListArt()
        {
            InitializeComponent();
        }
        private void frmListArt_Load(object sender, EventArgs e)
        {
            CategoriaAS cat = new CategoriaAS();
            MarcaAS marca = new MarcaAS();

            cboCategoria.DataSource = cat.listar();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.SelectedValue = -1;

            cboMarca.DataSource = marca.listar();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.SelectedValue = -1;

            cargar();
        }
        private void dgvArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmArtAdd ventana = new frmArtAdd();
            ventana.ShowDialog();
            cargar();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // funcion para borrar la busqueda, actualice la lista 
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                cargar();
            }
           
        }
        private void cargar(int marca = -1, int cate = -1)
        {   // cargamos la lista y mostramos imagen 
            ArticuloAS artAS = new ArticuloAS();
            listArt = artAS.listarVersatil(marca, cate);
            dgvArt.DataSource = listArt;
            ocultarColumnas();

        }
        private void ocultarColumnas()
        {
            dgvArt.Columns["Id"].Visible = false;
            dgvArt.Columns["Marca"].Visible = true;
            dgvArt.Columns["Categoria"].Visible = true;
            dgvArt.Columns["Imagen"].Visible = false;

        }
        private void cargarDGV()
        {
            dgvUrlImg.DataSource = null;
            dgvUrlImg.DataSource = imageList;
            dgvUrlImg.Columns["Id"].Visible = false;
            dgvUrlImg.Columns["IdArticulo"].Visible = false;
        }
        private void cargarImagen(string img)
        {
            try
            {
                pbArt.Load(img);
            }
            catch (Exception)
            {
                pbArt.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT3gpZSb_Y8zMJevdd9E2ZxI4doS3D4BMsus5ltKAyKydLH-zxnGIQQ3Dx7sNWcnZvFea4&usqp=CAU");
            }
            
        }
        private void dgvArt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArt.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArt.CurrentRow.DataBoundItem;
                ImagenAS imgAS = new ImagenAS();

                imageList = imgAS.listarFiltrado(seleccion.Codigo);
                cargarImagen("");

            }
            cargarDGV();
        }
        private void dgvUrlImg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUrlImg.CurrentRow != null)
            {
                //dgvUrlImg.CurrentRow.Cells[0].Selected = true;

                img = (Imagen)dgvUrlImg.CurrentRow.DataBoundItem;
                cargarImagen(img.ImagenUrl);
            }

        }
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (dgvArt.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvArt.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    try
                    {
                        ArticuloAS articuloAs = new ArticuloAS();
                        articuloAs.eliminar(articulo.Id);
                        cargar();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccionar un artículo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo = (Articulo)dgvArt.CurrentRow.DataBoundItem;
            bool modificar = true;

            //frmArtSearch articuloModificar = new frmArtSearch(accion, articulo);

            frmArtAdd articuloModificar = new frmArtAdd(articulo, modificar);

            articuloModificar.Show();

            /*if (articuloModificar.ShowDialog() == DialogResult.OK)
            {  
                cargar();
                Close();
            }*/

        }
        private void btnVerDetalleArt_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo = (Articulo)dgvArt.CurrentRow.DataBoundItem;
            int accion = 2;

            frmArtSearch articuloDetalle = new frmArtSearch(accion, articulo);

            if (articuloDetalle.ShowDialog() == DialogResult.OK)
            {
            
                cargar();
                Close();
            }
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaArticulosFiltrada = new List<Articulo>();
            string filtro = txtBuscar.Text;
            if(filtro != "")
            {
                listaArticulosFiltrada = listArt.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) ||
                                                         x.Codigo.ToUpper().Contains(filtro.ToUpper())||
                                                         x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                 
            }
            else
            {
                listaArticulosFiltrada = listArt;
            }
            dgvArt.DataSource = null;
            dgvArt.DataSource = listaArticulosFiltrada;
            ocultarColumnas();

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloAS articuloAS = new ArticuloAS();
            int sCate = Convert.ToInt32(cboCategoria.SelectedValue);
            int sMarca = Convert.ToInt32(cboMarca.SelectedValue);
            List<Articulo> listaArt = articuloAS.listarVersatil(sMarca, sCate);
            
            dgvArt.DataSource = null;
            dgvArt.DataSource = listaArt;

            ocultarColumnas();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            cboMarca.SelectedValue = -1;
            cboCategoria.SelectedValue = -1;
        }

    }
}