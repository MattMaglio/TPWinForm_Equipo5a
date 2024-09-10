using ApplicationService;
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

namespace WinFormAPP
{
    public partial class frmArtAdd : Form
    {
        private Articulo articulo = null;
        public frmArtAdd()
        {
            InitializeComponent();
        }
        public frmArtAdd(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmArtAdd_Load(object sender, EventArgs e)
        {
            //OBTENGO DATOS DE LOS DESPEGABLE 
            MarcaAS marca = new MarcaAS();
            CategoriaAS categoria = new CategoriaAS();
                    
            try
            {
                cbMarcaArt.DataSource = marca.listar();
                cbCatArt.DataSource = categoria.listar();

                cbCatArt.ValueMember = "Id";
                cbCatArt.DisplayMember = "Descripcion";

                cbMarcaArt.ValueMember = "Id";
                cbMarcaArt.DisplayMember = "Descripcion";
            
                if(articulo != null) //si es dintinto de null es modificar
                {
                
                    tbCodArt.Text = articulo.Codigo;
                    tbNomArt.Text = articulo.Nombre;
                    tbDescArt.Text = articulo.Descripcion;
                    tbImgArt.Text = articulo.Imagen.ImagenUrl;
                    tbPreArt.Text = articulo.Precio.ToString();

                    cbCatArt.SelectedValue = articulo.Categoria.Id;
                    cbMarcaArt.SelectedValue = articulo.Marca.Id;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddArt_Click(object sender, EventArgs e)
        {
            /*
            Articulo NuevoArt = new Articulo();
            ArticuloAS NuevoArtAS = new ArticuloAS();

            NuevoArt.Codigo = tbCodArt.Text;
            //
            //
            NuevoArtAS.insertarArt(NuevoArt);
            */

        }

    }
}
