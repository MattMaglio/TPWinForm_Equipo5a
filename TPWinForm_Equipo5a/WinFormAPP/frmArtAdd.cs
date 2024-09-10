using ApplicationService;
using Model;
using System;
using System.Collections;
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


            try
            {
            cboMarcaArt.DataSource = marca.listar();
            cboCatArt.DataSource = categoria.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
       

        private void btnAddArt_Click(object sender, EventArgs e)
        {
            //Cargo el obj
            Articulo art = new Articulo(); 
            ArticuloAS artAS = new ArticuloAS();
            ImagenAS imgAS = new ImagenAS();



            try
            {
                art.Codigo = tbCodArt.Text;
                art.Nombre = tbNomArt.Text;
                art.Descripcion = tbDescArt.Text;
                art.Categoria = (Categoria)cboCatArt.SelectedItem;
                art.Marca = (Marca)cboMarcaArt.SelectedItem;
                art.Precio = decimal.Parse(tbPreArt.Text);


               
            //Agrego el obj
                artAS.agregarArt(art);
                MessageBox.Show("Artículo agregado exitosamente");


            // Verifico si se ingresó URL de Img
                if (!string.IsNullOrWhiteSpace(tbImgArt.Text))
                {
                    Imagen img = new Imagen
                    {
                        IdArticulo = art.Id, 
                        ImagenUrl = tbImgArt.Text
                    };

                    // Agrego la imagen
                    imgAS.agregarImagen(img);
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArt.Load(imagen);
            }
            catch (Exception)
            {

                pbArt.Load("https://picsum.photos/id/870/536/354?grayscale&blur=2");
            }
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbImgArt_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbImgArt.Text);
        }
    }
}
