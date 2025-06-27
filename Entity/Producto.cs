using System;

namespace Entity
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public abstract string TipoProducto { get; } //hay q eliminarla, no existe el tipo en abstraccion
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