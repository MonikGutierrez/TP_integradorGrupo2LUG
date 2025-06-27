using System;

namespace Entity
{
    public class Calzado : Producto
    {
        public decimal Numero { get; set; }
        public string Categoria { get; set; }
        public int StockMinimo { get; set; }
        public override string TipoProducto => "Calzado";

        public int StockCritico => 2;

        public int StockDisponible => Stock;

        public void ActualizarStock(int cantidad)
        {
            Stock += cantidad;
        }

        public bool TieneStock(int cantidad)
        {
            return Stock >= cantidad;
        }
    }
}

