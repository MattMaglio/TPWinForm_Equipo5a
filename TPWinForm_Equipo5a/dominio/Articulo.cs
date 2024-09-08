using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{      //Clase Articulo
    public class Articulo
    {
        public int IdArticulo { get; set; }

        public string CodigoArticulo { get; set; }

        public string NombreArticulo { get; set; }

        public string DescripcionArticulo { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }

        public decimal Precio { get; set; }

        public List<string> Imagenes { get; set; }


        //Constructor de clase Articulo
       
        public Articulo()
        {
            Imagenes = new List<string>();
        }

    }
}



