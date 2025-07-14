using System.Runtime.InteropServices;

namespace Entity
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Temporada { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaCreacion { get; set; }

        public string ProductoCompleto
        {
            get { return $"{Id} - {Nombre} - ${Precio}"; }
        }


        public override string ToString()
        {
            return $"{Id} - {Nombre}";
        }

    }
}