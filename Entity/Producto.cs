using System;

namespace Entity
{
<<<<<<< HEAD
    public abstract class Producto
=======
    public class Producto
>>>>>>> da4321917357b2e56e637ebc664ca8595807f68b
    {
        public int Id { get; set; }
        public string TipoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Temporada { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
    }
}