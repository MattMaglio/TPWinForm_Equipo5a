using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{   ///Clase Marca
    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        
        //Constructores de clase Marca
        public Marca() { }

        public Marca(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

    }

}
