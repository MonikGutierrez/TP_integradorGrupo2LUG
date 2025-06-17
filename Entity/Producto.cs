using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public int Id { get; set; }
        public string TipoProducto { get; set; } // Vestido o Calzado
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Temporada { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

        public bool ValidarStock()
        {
            return Stock > 0;
        }
    }
}

