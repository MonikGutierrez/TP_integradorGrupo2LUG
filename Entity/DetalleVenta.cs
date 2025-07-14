using Entity;

public class DetalleVenta
{
    public int Id { get; set; }
    public int VentaId { get; set; }
    public int ProductoId { get; set; }
    public Producto producto { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Subtotal
    {
        get
        {
            return PrecioUnitario * Cantidad;
        }
    }


    public DetalleVenta()
    {

    }


    public DetalleVenta(int ventaId, Producto producto, int cantidad)
    {
        VentaId = ventaId;
        this.producto = producto;
        Cantidad = cantidad;
    }

}
