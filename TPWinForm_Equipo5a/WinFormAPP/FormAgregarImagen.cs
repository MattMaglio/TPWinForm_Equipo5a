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
    public partial class FormAgregarImagen : Form
    {
        public string UrlImagen { get; private set; }
        public FormAgregarImagen()
        {
            InitializeComponent();
        }

        private void FormAgregarImagen_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Asigna el valor del TextBox a la propiedad UrlImagen
            UrlImagen = tbUrlImagen.Text;

            // Establece el resultado del formulario como OK si se ingresó una URL válida
            if (!string.IsNullOrWhiteSpace(UrlImagen))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();  // Cierra el formulario
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una URL válida.");
            }
        }
    }
}
