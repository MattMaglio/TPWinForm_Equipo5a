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



namespace WinFormAPP
{
    public partial class frmListArt : Form
    {
        private List<Articulo> listArt;
        public frmListArt()
        {
            InitializeComponent();
        }

        private void frmListArt_Load(object sender, EventArgs e)
        {

            cargar();
            cboCategoria.Items.Add("Televisores");
            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Audio");

            cboMarca.Items.Add("Samgung");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Huawei");
            cboMarca.Items.Add("Motorola");
        }

        private void dgvArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerDetalleArt_Click(object sender, EventArgs e)
        {
            Articulo verArticulo = new Articulo();
            verArticulo = (Articulo)dgvArt.CurrentRow.DataBoundItem;

            frmArtAdd verDetalle = new frmArtAdd(verArticulo, true);
            verDetalle.ShowDialog();
            cargar();
   

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
        private void cargar()
        {   // cargamos la lista y mostramos imagen 
            ArticuloAS artAS = new ArticuloAS();
            listArt = artAS.listarFrmListado();
            dgvArt.DataSource = listArt;
            ocultarColumnas();
            pboxImagenUrl.Load(listArt[0].Imagen.ImagenUrl);


        }
        private void ocultarColumnas()
        {
            dgvArt.Columns["Id"].Visible = false;
            dgvArt.Columns["Marca"].Visible = true;
            dgvArt.Columns["Categoria"].Visible = true;
            dgvArt.Columns["Imagen"].Visible = false;

        }

        public void cargarImagenUrl(string imagen)
        {
            try
            {
                pboxImagenUrl.Load(imagen);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al cargar la imagen desde la URL: {ex.Message}");
                // Cargar imagen por defecto
                pboxImagenUrl.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");

            }

        }


        private void dgvArt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArt.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArt.CurrentRow.DataBoundItem;

                if (seleccion != null && seleccion.Imagen != null)
                {
                    string imagenUrl = seleccion.Imagen.ImagenUrl;

                    if (!string.IsNullOrEmpty(imagenUrl))
                    {
                        cargarImagenUrl(imagenUrl);
                    }
                    else
                    {
                        // Si la URL es nula o vacía, carga una imagen por defecto
                        cargarImagenUrl("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
                    }
                }
                else
                {
                    // Si 'seleccion' o 'Imagen' es null, carga una imagen por defecto
                    cargarImagenUrl("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
                }
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
            Articulo articulo;
            articulo = (Articulo)dgvArt.CurrentRow.DataBoundItem;
            int modificar = 1;

            frmArtAdd articuloModificar = new frmArtAdd(articulo, modificar);

            if (articuloModificar.ShowDialog() == DialogResult.OK)
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

            //string seleccionCat = cboCategoria.SelectedItem.ToString();
            //string seleccionMarca = cboMarca.SelectedItem.ToString();
            string seleccionCat = cboCategoria.SelectedItem != null ? cboCategoria.SelectedItem.ToString() : "Todas";
            string seleccionMarca = cboMarca.SelectedItem != null ? cboMarca.SelectedItem.ToString() : "Todas";

            List<Articulo> listaArt = articuloAS.ListaFiltrada(seleccionCat, seleccionMarca);
            
            dgvArt.DataSource = null;
            dgvArt.DataSource = listaArt;

            ocultarColumnas();
        }
    }
}