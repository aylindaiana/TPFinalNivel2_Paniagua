using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace domino
{
    public class Articulo
    {
        public int Id { get; set; }

        public string Codigo { get; set; }
        [DisplayName("Número")]
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Marca")]
        public Marca TipoMarca { get; set; }
        [DisplayName("Categoria")]
        public Categoria TipoCategoria  { get; set; }

        public string ImagenUrl { get; set; }

        public decimal Precio { get; set; }

        public int Stock {  get; set; }
    }
}
