using System;

namespace Entity
{
    public class Vestido : Producto
        
    {
        // public int Id { get; set; }

        // public string Nombre { get; set; }
        public override string TipoProducto => "Vestido";
        public string Estado { get; set; }
        public string Talle { get; set; }
        public string Disenador { get; set; }
        public int TiempoAjusteHoras { get; set; }
        public bool EsUnico { get; set; }
        public DateTime? FechaUltimoAjuste { get; set; }
    }
}