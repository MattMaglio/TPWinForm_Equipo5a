using ApplicationService;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormAPP
{
    public partial class frmArtAdd : Form
    {
        private Articulo articulo = new Articulo(); // variable que utilizo para el pasaje entre ventanas
        private bool modoVerDetalle = false;
        private int modoModificar = 0; // var para modo modificar
        List<Imagen> listImg =new List<Imagen>(); // Contenedor de la imagen al agregarla al articulo.
        private Imagen img = null; // Propiedad para manejar el control de la grid de imagenes.
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

                //lbExitoArtAdd.Visible = false;
                
            }
            else
            {
                lbTituloArtAltas.Text = "Agregar articulo";
            }


        }
        public frmArtAdd(Articulo articuloModificar, int modoModificar)// Duplico el constructor para utilizar la ventana en boton mod
        {
            InitializeComponent();
            this.articulo = articuloModificar;
             CargarDatos();
        }
        private void CargarDatos()
        {
            if (modoModificar == 0)
            {
                // Configuracion del  formulario para modificar
                lbTituloArtAltas.Text = "Modificar artículo";
                btnAddArt.Text = "Guardar artículo";
                // cargo los datos al formulario
                tbCodArt.Text = articulo.Codigo;
                tbNomArt.Text = articulo.Nombre;
                tbDescArt.Text = articulo.Descripcion;
                tbPreArt.Text = articulo.Precio.ToString();
                tbImgArt.Text = articulo.Imagen.ImagenUrl;
                cboMarcaArt.Text = articulo.Marca.Descripcion;
                cboCatArt.Text = articulo.Categoria.Descripcion;
                cargarDGV();
                // Configurar otros controles según sea necesario
            }
        }
        private void cargarDGV()
        {   
            tbImgArt.Clear();
            dgvUrlImg.DataSource = null;
            dgvUrlImg.DataSource = listImg;
            dgvUrlImg.Columns["Id"].Visible = false;
            dgvUrlImg.Columns["IdArticulo"].Visible = false;
        }
        private void frmArtAdd_Load(object sender, EventArgs e)
        {
            MarcaAS marca = new MarcaAS();
            CategoriaAS categoria = new CategoriaAS();


            try
            {

                cboMarcaArt.DataSource = marca.listar();
                cboCatArt.DataSource = categoria.listar();
                
                tbCodArt.Text = articulo.Codigo;
                tbNomArt.Text = articulo.Nombre;
                tbDescArt.Text = articulo.Descripcion;
                tbPreArt.Text = articulo.Precio.ToString();

                cboCatArt.ValueMember = "Id";
                cboCatArt.DisplayMember = "Descripcion";
                cboCatArt.SelectedValue = -1;

                cboMarcaArt.ValueMember = "Id";
                cboMarcaArt.DisplayMember = "Descripcion";
                cboMarcaArt.SelectedValue = -1;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAddArt_Click(object sender, EventArgs e)
        {
            // Cargo el objeto Artículo
            Articulo art = new Articulo();
            ArticuloAS artAS = new ArticuloAS();
            ImagenAS imgAS = new ImagenAS();

            try
            {
                if(modoModificar == 1)
                {
                    // Modificar artículo
                    articulo.Codigo = tbCodArt.Text;
                    articulo.Nombre = tbNomArt.Text;
                    articulo.Descripcion = tbDescArt.Text;
                    articulo.Precio = decimal.Parse(tbPreArt.Text);
                    articulo.Marca.Descripcion = cboMarcaArt.Text;
                    articulo.Categoria.Descripcion = cboCatArt.Text;
                    articulo.Imagen.ImagenUrl = tbImgArt.Text;
                    lbTituloArtAltas.Text = "Modificar artículo";
                    btnAddArt.Text = "Guardar artículo";


                    // Actualizar el artículo en la base de datos
                    artAS.actualizarArticulo(articulo);
                    MessageBox.Show("Artículo modificado exitosamente");
                    
                   Close();

                    
                }
                else
                {

                    // Asigno los valores a las propiedades del artículo para agregar
                    art.Codigo = tbCodArt.Text;
                    art.Nombre = tbNomArt.Text;
                    art.Descripcion = tbDescArt.Text;
                    art.Categoria = (Categoria)cboCatArt.SelectedItem;
                    art.Marca = (Marca)cboMarcaArt.SelectedItem;
                    art.Precio = decimal.Parse(tbPreArt.Text);

                    // Agrego el artículo y obtengo su ID
                    int idArticuloGenerado = artAS.agregarArt(art);
                    art.Id = idArticuloGenerado;  // Asigno el ID generado al artículo

                    imgAS.agegarImagenesArtNuevo(listImg, art);

                    MessageBox.Show("Artículo agregado exitosamente");
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
        //********************************************************************************
        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            try
            {
                

                // Verificar que la URL ingresada es válida
                string urlPattern = @"^((https?|ftp):\/\/)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}(:\d{1,5})?(\/\S*)?$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(tbImgArt.Text, urlPattern))
                {
                    MessageBox.Show("La URL ingresada no es válida. Por favor, ingrese una URL en formato correcto.");
                    return;
                }

                // Inicializar el objeto img y asignar sus valores
                Imagen img = new Imagen();
                
                img.ImagenUrl = tbImgArt.Text;

                // Agregar la imagen a la lista
                listImg.Add(img);
                cargarDGV();

                MessageBox.Show("URL agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la URL: " + ex.Message);
            }
        }


        //********************************************************************************
        /* private void btnAddUrl_Click(object sender, EventArgs e)
         {
             try
             {
                 img = new Imagen();
                 img.ImagenUrl = tbImgArt.Text;
                 listImg.Add(img);
                 cargarDGV();


                 MessageBox.Show("Url agregada");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }*/
        //*********************************************************************************
        private void btnDelUrl_Click(object sender, EventArgs e)
        {
            try
            {   
                listImg.Remove(img);
                cargarDGV();

                MessageBox.Show("Url eliminada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvUrlImg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUrlImg.CurrentRow != null)
            {
                img = (Imagen)dgvUrlImg.CurrentRow.DataBoundItem;
                cargarImagen(img.ImagenUrl);
                tbImgArt.Clear();
            }
        }
    }
}
