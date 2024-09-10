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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
