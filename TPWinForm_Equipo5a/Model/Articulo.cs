using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }

        //public Marca IdMarca { get; set; }
        //public Categoria IdCategoria { get; set; }

        public decimal Precio { get; set; }

    }
}
