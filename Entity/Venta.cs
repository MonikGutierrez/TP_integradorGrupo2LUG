namespace Entity
{
    public class Venta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public List<DetalleVenta> Detalles { get; set; }

        public Venta()
        {
            Detalles = new List<DetalleVenta>();
        }

        public decimal CalcularTotalVenta()
        {
            try
            {
                decimal total = 0;
                foreach (var detalle in Detalles)
                {
                    total += detalle.PrecioUnitario * detalle.Cantidad;
                }
                return total;

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}