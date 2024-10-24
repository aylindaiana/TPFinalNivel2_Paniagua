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
        [DisplayName("NÚMERO")]
        public string Nombre { get; set; }
        [DisplayName("DESCRIPCIÓN")]
        public string Descripcion { get; set; }

        [DisplayName("MARCA")]
        public Marca TipoMarca { get; set; }
        [DisplayName("CATEGORIA")]
        public Categoria TipoCategoria  { get; set; }
        [DisplayName("PRECIO")]
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }
    }
}
