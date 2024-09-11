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
        private Articulo articulo = null; // variable que utilizo para el pasaje entre ventanas
        private bool modoVerDetalle = false;
        public frmArtAdd()
        {
            InitializeComponent();
        }
        public frmArtAdd(Articulo articulo ,bool modoVerDetalle)// Duplico para utilizar la ventana de ver detalle
        {
            InitializeComponent();
            this.articulo = articulo;
            if (modoVerDetalle)// si es modo ver detalle articulo
            {
                lbTituloArtAltas.Text = "Detalle articulo";
                btnAddArt.Visible = false;
                foreach (Control control in this.Controls)
                {
                  if (control is TextBox)
                  {
                    ((TextBox)control).Enabled = false;
                  }else if(control is ComboBox) {
                    ((ComboBox)control).Enabled = false;
                  }
                }
                //CENTRAMOS BOTON CANCELAR EN MODO VER DETALLE
                btnCancelAdd.Left = (this.ClientSize.Width - btnCancelAdd.Width) / 2;
                btnCancelAdd.Top = (this.ClientSize.Height - btnCancelAdd.Height) / 2+120;

                lbExitoArtAdd.Visible = false;
                
            }
            else
            {
                lbTituloArtAltas.Text = "Agregar articulo";
            }


        }

        private void frmArtAdd_Load(object sender, EventArgs e)
        {
            MarcaAS marca = new MarcaAS();
            CategoriaAS categoria = new CategoriaAS();


            try
            {

                cboMarcaArt.DataSource = marca.listar();
                cboCatArt.DataSource = categoria.listar();
                if(articulo != null)// Desde el if para manipular la ventana agregar desde el boton ver detalle articulo
                {
                    tbCodArt.Text = articulo.Codigo;
                    tbNomArt.Text = articulo.Nombre;
                    tbDescArt.Text = articulo.Descripcion;
                    tbPreArt.Text = articulo.Precio.ToString();

                    cboCatArt.ValueMember = "Id";
                    cboCatArt.DisplayMember = "Descripcion";
                    cboMarcaArt.ValueMember = "Id";
                    cboMarcaArt.DisplayMember = "Descripcion";
                    cargarImagen(articulo.Imagen.ImagenUrl);

                }

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

            // OBTENER EL ID DEL OBJ ART PARA PASARLO AL OBJ IMAGEN. 

            // Verifico si se ingresó URL de Img
                if (!string.IsNullOrWhiteSpace(tbImgArt.Text))
                {
                    Imagen img = new Imagen();

                    img.IdArticulo = art.Id;
                    img.ImagenUrl = tbImgArt.Text.ToString();
                    
                    
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

                pbArt.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
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
