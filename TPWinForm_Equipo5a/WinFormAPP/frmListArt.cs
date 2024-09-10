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
            cboCategoria.Items.Add("Televisor");
            cboCategoria.Items.Add("Telefono");
            cboCategoria.Items.Add("Consola");
           

        }

        private void dgvArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerDetalleArt_Click(object sender, EventArgs e)
        {
            /*Articulo seleccionarArt;
            seleccionarArt = (Articulo)dgvArt.CurrentRow.DataBoundItem;
            detalle*/
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmArtAdd ventana = new frmArtAdd();
            ventana.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargar()
        {
            ArticuloAS artAS = new ArticuloAS();
            listArt = artAS.listar();
            dgvArt.DataSource = listArt;
            ocultarColumnas();
            pboxImagenUrl.Load(listArt[0].Imagen.ImagenUrl);
            

        }
        private void  ocultarColumnas()
        {
            dgvArt.Columns["IdMarca"].Visible = false;
            dgvArt.Columns["IdCategoria"].Visible = false;
            dgvArt.Columns["Id"].Visible = false;
            if (dgvArt.Columns["ImagenUrl"]!= null)
            {
                dgvArt.Columns["ImagenUrl"].Visible = false;
            }

          /*  else
            {
                MessageBox.Show("La columna 'ImagenUrl' no está presente en el DataGridView.");
            }*/
        }
        private void cargarImagenUrl(string imagen)
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
            if(dgvArt.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvArt.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta  == DialogResult.Yes)
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
    }
}
