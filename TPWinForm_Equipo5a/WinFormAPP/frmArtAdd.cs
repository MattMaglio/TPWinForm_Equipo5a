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
        private Articulo articulo = null; // variable que utilizo para el pasaje entre ventanas
       // private bool modoVerDetalle = false;
        private bool modoModificar = false; // var para modo modificar
        List<Imagen> listImg =new List<Imagen>(); // Contenedor de la imagen al agregarla al articulo.
        private Imagen img = null; // Propiedad para manejar el control de la grid de imagenes.
        public frmArtAdd()
        {
            InitializeComponent();
        }
        private void PrecargarDatosArticulo()
        {
            /*// Suponiendo que tienes controles TextBox o ComboBox para cada campo del artículo
            tbNomArt.Text = articulo.Nombre;
            tbDescArt.Text = articulo.Descripcion;
            // Si tienes un ComboBox para la marca
            cboMarcaArt.SelectedValue = articulo.Marca.Id;
            // Si tienes un ComboBox para la categoría
            cboCatArt .SelectedValue = articulo.Categoria.Id;
            // Precargar URL de la imagen si tienes un PictureBox
           /* if (!string.IsNullOrEmpty(articulo.Imagen.ImagenUrl))
            {
                pbArt.Load(articulo.Imagen.ImagenUrl);
            }
            else
            {
                pbArt.Image = null; // O cargar una imagen por defecto
            }*/
        }
        public frmArtAdd(Articulo articuloModificar, bool modoModificar)// Duplico el constructor para utilizar la ventana en boton mod
        {
            InitializeComponent();
            this.articulo = articuloModificar;
            this.modoModificar = modoModificar;
            
            CargarDatos();
        }
        private void CargarDatos()
        {   
            ImagenAS imgAS = new ImagenAS();
            listImg = imgAS.listarFiltrado(articulo.Codigo);

            if (modoModificar == true)
            {
                // Configuracion del  formulario para modificar
                lbTituloArtAltas.Text = "Modificar artículo";
                btnAddArt.Text = "Guardar artículo";
                // cargo los datos al formulario
                tbCodArt.Text = articulo.Codigo;
                tbNomArt.Text = articulo.Nombre;
                tbDescArt.Text = articulo.Descripcion;
                tbPreArt.Text = articulo.Precio.ToString();
                cboMarcaArt.Text = articulo.Marca.Descripcion;
                cboCatArt.Text = articulo.Categoria.Descripcion;
                tbCodArt.ReadOnly = true;
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
            this.Enabled = true;

            MarcaAS marca = new MarcaAS();
            CategoriaAS categoria = new CategoriaAS();
            
            if (articulo == null)
            {
                articulo = new Articulo();
                
            }

            cboMarcaArt.DataSource = marca.listar();
            cboCatArt.DataSource = categoria.listar();

            if (modoModificar == true) // modificacíon
            {
                tbCodArt.Text = articulo.Codigo;
                tbNomArt.Text = articulo.Nombre;
                tbDescArt.Text = articulo.Descripcion;
                tbPreArt.Text = articulo.Precio.ToString();

                cboCatArt.ValueMember = "Id";
                cboCatArt.DisplayMember = "Descripcion";

                cboMarcaArt.ValueMember = "Id";
                cboMarcaArt.DisplayMember = "Descripcion";

                cboCatArt.SelectedValue = articulo.Categoria.Id;
                cboMarcaArt.SelectedValue = articulo.Marca.Id;
            }
            else
            {
                try
                {

                    tbCodArt.Text = articulo.Codigo;
                    tbNomArt.Text = articulo.Nombre;
                    tbDescArt.Text = articulo.Descripcion;
                    tbPreArt.Text = articulo.Precio.ToString();

                    cboCatArt.ValueMember = "Id";
                    cboCatArt.DisplayMember = "Descripcion";
                    
                    cboMarcaArt.ValueMember = "Id";
                    cboMarcaArt.DisplayMember = "Descripcion";

                    cboMarcaArt.SelectedValue = -1;
                    cboCatArt.SelectedValue = -1;


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
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
                if(modoModificar == true)
                {

                    try
                    {
                        
                        // Validar el nombre
                        if (string.IsNullOrWhiteSpace(tbNomArt.Text))
                        {
                            MessageBox.Show("El nombre del artículo es obligatorio.");
                            return;
                        }

                        // Validar la descripción
                        if (string.IsNullOrWhiteSpace(tbDescArt.Text))
                        {
                            MessageBox.Show("La descripción del artículo es obligatoria.");
                            return;
                        }

                        // Validar que se haya seleccionado una categoría
                        if (cboCatArt.SelectedItem == null)
                        {
                            MessageBox.Show("Debe seleccionar una categoría.");
                            return;
                        }

                        // Validar que se haya seleccionado una marca
                        if (cboMarcaArt.SelectedItem == null)
                        {
                            MessageBox.Show("Debe seleccionar una marca.");
                            return;
                        }

                        // Validar y convertir el precio
                        decimal precio;
                        if (!decimal.TryParse(tbPreArt.Text, out precio) || precio <= 0)
                        {
                            MessageBox.Show("El precio debe ser un número válido mayor que cero.");
                            return;
                        }

                        // Asignar los valores al objeto Articulo
                        art.Codigo = tbCodArt.Text;
                        art.Nombre = tbNomArt.Text;
                        art.Descripcion = tbDescArt.Text;
                        art.Categoria = (Categoria)cboCatArt.SelectedItem;
                        art.Marca = (Marca)cboMarcaArt.SelectedItem;
                        art.Precio = precio;

                        // Llamar al método de actualización
                        artAS.actualizarArticulo(art);
                        imgAS.agegarImagenesArtNuevo(listImg,art);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el artículo: " + ex.Message);
                    }
                    
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
                tbImgArt.Text = img.ImagenUrl;

            }
        }

    }
}
