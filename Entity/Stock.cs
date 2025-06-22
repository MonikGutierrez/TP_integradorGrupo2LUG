using System;

namespace Entity
{
    public class Stock
    {
        public int Id { get; set; }
        public string TipoProducto { get; set; }  // Calzado, Vestido, etc.
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}