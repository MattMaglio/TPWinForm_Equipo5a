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
        private int modoModificar = 1; // var para modo modificar
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
            
            if (modoModificar == 1)
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
                // Configurar otros controles según sea necesario
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
        //********************************************************************************************
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

                

                    // Verifico si se ingresó URL de imagen
                    if (!string.IsNullOrWhiteSpace(tbImgArt.Text))
                    {
                        Imagen img = new Imagen();
                        img.IdArticulo = art.Id;
                        img.ImagenUrl = tbImgArt.Text.ToString();

                        // Agrego la imagen
                        imgAS.agregarImagen(img);
                    }

                    //segunda imagen*********************************************************************
                    // Preguntar si se desea agregar una segunda imagen
                   /* DialogResult result = MessageBox.Show("¿Desea agregar una segunda imagen?", "Agregar Imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Abrir el formulario para ingresar la segunda URL
                        FormAgregarImagen formImagen = new FormAgregarImagen();
                        if (formImagen.ShowDialog() == DialogResult.OK)
                        {
                            // Si se ingresó una URL válida en el formulario
                            if (!string.IsNullOrWhiteSpace(formImagen.UrlImagen))
                            {
                                Imagen imgSegunda = new Imagen();
                                imgSegunda.IdArticulo = art.Id;
                                imgSegunda.ImagenUrl = formImagen.UrlImagen;

                                // Agregar la segunda imagen
                                imgAS.agregarImagen(imgSegunda);
                            }
                        }
                    }*/

                    ///***********************************************************************************
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
    }
}
